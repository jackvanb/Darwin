using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using Darwin.Models;
using PropertyChanged;
using Xamarin.Forms;

namespace Darwin.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class PodcastPageModel : FreshBasePageModel
    {
        bool openingPage;

        public Podcast Podcast { get; set; }

        public async void OnPodcastSelected (object sender, SelectedItemChangedEventArgs e)
        {

            var episdoe = e.SelectedItem as AudioFile;
            if (episdoe == null)
                return;
            
            await CoreMethods.PushPageModel<PlayerPageModel>(episdoe, true, true);
        }

        // FreshMVVM Constructor
        public override void Init(object initData)
        {
            base.Init(initData);

            Podcast = initData as Podcast;

        }

        ICommand openPlayerCommand;
        public ICommand OpenPlayerCommand
        {
            get
            {
                return openPlayerCommand ?? (openPlayerCommand = new Command<AudioFile>(async (item) => await OpenPlayer(item), (arg) => !openingPage));
            }
        }
        

        public async Task OpenPlayer(AudioFile item)
        {
           await CoreMethods.PushPageModel<PlayerPageModel>(item, true, true);
        }

    }
}
