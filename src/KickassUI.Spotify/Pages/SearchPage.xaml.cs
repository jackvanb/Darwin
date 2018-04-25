using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

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
                widget.Tapped += (object sender, Controls.TileTappedEventArgs e) => {
                    var page = Activator.CreateInstance(e.Page) as Page;
                    Navigation.PushAsync(page);
                };
                Grid.Children.Add(widget, s.Column, s.Row);
             }
        }
    }
}
