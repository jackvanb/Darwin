using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Darwin.Controls;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Darwin.Pages
{
    public partial class PodcastPage : ContentPage
    {
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //Darwin.PageModels.PodcastPageModel pageModel;

        public PodcastPage()
        {
            InitializeComponent();
            //BindingContext = new Darwin.PageModels.PodcastPageModel();
            //pageModel = new PageModels.PodcastPageModel();
           // lstView.ItemsSource = new Darwin.PageModels.PodcastPageModel().Podcast.Episodes;
         }

        //async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        //{
        //    var episode = args.SelectedItem as Darwin.Models.AudioFile;
        //    if (episode == null)
        //        return;
            
        //    await pageModel.OpenPlayer(episode);
        //}

        public async void OnPodcastSelected(object sender, SelectedItemChangedEventArgs e)
        {
           // var episode = e.SelectedItem as Models.AudioFile;

            PageModels.PodcastPageModel vm = this.BindingContext as PageModels.PodcastPageModel;
			await vm.OpenPlayer(vm.Podcast);
        }
    }
}
