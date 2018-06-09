using System.Threading.Tasks;
using FreshMvvm;
using System.Collections.Generic;

namespace Darwin.PageModels
{
    public class SearchPageModel : FreshBasePageModel
    {
        public static List<Models.Tile> GetDashData()
        {
            return new List<Models.Tile>() {
                new Models.Tile () {
                    BackgroundImage = "film-tv.jpg",
                    //IconImage = "button_play@2x.png",
                    Text = "Film and TV",
                    Column = 0,
                    Row = 0,
                    NavigateType = typeof(Page1)
                },
                new Models.Tile () {
                    BackgroundImage = "history.png",
                    //IconImage = "button_play@2x.png",
                    Text = "History",
                    Column = 1,
                    Row = 0,
                    NavigateType = typeof(Page2)
                },
                new Models.Tile () {
                    BackgroundImage = "sports.jpg",
                   // IconImage = "button_play@2x.png",
                    Text = "Sports",
                    Column = 0,
                    Row = 1,
                    NavigateType = typeof(Page3)
                },
                new Models.Tile () {
					BackgroundImage = "health.png",
                    //IconImage = "button_play@2x.png",
                    Text = "Health",
                    Column = 1,
                    Row = 1,
                    NavigateType = typeof(Page4)
                },
                new Models.Tile () {
					BackgroundImage = "technology.jpg",
                  //  IconImage = "accessories.png",
                    Text = "Technology",
                    Column = 0,
                    Row = 2,
                    NavigateType = typeof(Page5)
                },
                new Models.Tile () {
					BackgroundImage = "business.jpg",
                   // IconImage = "housewares.png",
                    Text = "Buisness",
                    Column = 1,
                    Row = 2,
                    NavigateType = typeof(Page6)
                }
                //new Models.Tile () {
                //    BackgroundImage = "giftsbg.png",
                //    IconImage = "gifts.png",
                //    Text = "Gifts",
                //    Column = 0,
                //    Row = 2,
                //    NavigateType = typeof(Page7)
                //},
                //new Models.Tile () {
                //    BackgroundImage = "foodbg.png",
                //    IconImage = "food.png",
                //    Text = "Food",
                //    Column = 1,
                //    Row = 2,
                //    NavigateType = typeof(Page8)
                //},
                //new Models.Tile () {
                //    BackgroundImage = "restroomsbg.png",
                //    IconImage = "restrooms.png",
                //    Text = "Restrooms",
                //    Column = 2,
                //    Row = 2,
                //    NavigateType = typeof(Page9)
                //},
                //new Models.Tile () {
                //    BackgroundImage = "vendingbg.png",
                //    IconImage = "vending.png",
                //    Text = "Vending",
                //    Column = 0,
                //    Row = 3,
                //    NavigateType = typeof(Page10)
                //},
                //new Models.Tile () {
                //    BackgroundImage = "servicesbg.png",
                //    IconImage = "services.png",
                //    Text = "Services",
                //    Column = 1,
                //    Row = 3,
                //    NavigateType = typeof(Page11)
                //},
                //new Models.Tile () { BackgroundImage = "hoursbg.png",
                //    IconImage = "hours.png",
                //    Text = "Hours",
                //    Column = 2,
                //    Row = 3,
                //    NavigateType = typeof(Page12)
                //}
            };


        }

		public async Task OpenPage()
        {
			await CoreMethods.PushPageModel<PlaylistPageModel>(true);
        }

    }
}
