using Xamarin.Forms;
using System.Collections.Generic;

namespace Darwin.Pages
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();

            List<Models.Tile> squares = PageModels.SearchPageModel.GetDashData();

            foreach (var s in squares)
            {
                var widget = new Controls.TileView(s);
				widget.Tapped += async (object sender, Controls.TileTappedEventArgs e) => {
                    //var page = Activator.CreateInstance(e.Page) as Page;
					PageModels.SearchPageModel vm = this.BindingContext as PageModels.SearchPageModel;
					await vm.OpenPage();
                };
                Grid.Children.Add(widget, s.Column, s.Row);
             }
        }
    }
}
