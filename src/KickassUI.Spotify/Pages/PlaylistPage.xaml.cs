using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Darwin.Pages
{
    public partial class PlaylistPage : ContentPage
    {
        public PlaylistPage()
        {
            InitializeComponent();
        }

		public async void OnPodcastSelected(object sender, SelectedItemChangedEventArgs e)
        {
			var podcast = e.SelectedItem as Models.Podcast;

			PageModels.PlaylistPageModel vm = this.BindingContext as PageModels.PlaylistPageModel;
			await vm.OpenPlayer(podcast);
        }
    }
}
