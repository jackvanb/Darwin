using System;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using Plugin.MediaManager.Abstractions.Enums;
using Plugin.MediaManager.Abstractions.EventArguments;
using Plugin.MediaManager.Abstractions.Implementations;
using Darwin.Models;
using PropertyChanged;
using Xamarin.Forms;

namespace Darwin.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class PlayerPageModel : FreshBasePageModel
    {
        

        public AudioFile Song { get; set; }
        public bool IsPlaying { get; set; }

        [AlsoNotifyFor(nameof(TicksLeft))]
        public int Ticks { get; set; }
        public int TicksLeft => Song.LengthInSeconds - Ticks;

        public PlayerPageModel()
        {
            CrossMediaManager.Current.VolumeManager.CurrentVolume = 50;
        }

        ICommand closePlayerCommand;
        public ICommand ClosePlayerCommand
        {
            get
            {
                return closePlayerCommand ?? (closePlayerCommand = new Command(async () => await ClosePlayer()));
            }
        }

        ICommand playCommand;
        public ICommand PlayCommand
        {
            get
            {
                return playCommand ?? (playCommand = new Command(() => StartStopPlaying()));
            }
        }

        private void StartStopPlaying()
        {

            var mediaFile = new MediaFile
            {
                Type = MediaFileType.Audio,
                Availability = ResourceAvailability.Remote,
                Url = "https://audioboom.com/posts/5766044-follow-up-305.mp3"

            };

            if (!IsPlaying)
            {
                IsPlaying = true;

                CrossMediaManager.Current.Play(mediaFile);
  
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    Ticks += 1;

                    // Stop playing when at the end.
                    if (Ticks == Song.LengthInSeconds)
                        IsPlaying = false;

                    // While the song is not over, return true for another tick.
                    return Ticks <= Song.LengthInSeconds && IsPlaying;
                });
            }
            else
            {
                // If it is currently playing, set it to false.
                IsPlaying = false;
                CrossMediaManager.Current.Pause();
            }
        }

        private async Task ClosePlayer()
        {
            await CrossMediaManager.Current.Stop();
            await CoreMethods.PopPageModel(true, true);
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            Song = initData as AudioFile;
        }
    }
}
