using System;
using System.Collections.Generic;
using FreshMvvm;
namespace Darwin.PageModels
{
    public class SearchPageModel : FreshBasePageModel
    {
        public static List<Models.Tile> GetDashData()
        {
            return new List<Models.Tile>() {
                new Models.Tile () {
                    BackgroundImage = "concert.jpg",
                    //IconImage = "button_play@2x.png",
                    Text = "Music",
                    Column = 0,
                    Row = 0,
                    NavigateType = typeof(Page1)
                },
                new Models.Tile () {
                    BackgroundImage = "concert.jpg",
                    //IconImage = "button_play@2x.png",
                    Text = "Comedy",
                    Column = 1,
                    Row = 0,
                    NavigateType = typeof(Page2)
                },
                new Models.Tile () {
                    BackgroundImage = "concert.jpg",
                   // IconImage = "button_play@2x.png",
                    Text = "News",
                    Column = 0,
                    Row = 1,
                    NavigateType = typeof(Page3)
                },
                new Models.Tile () {
                    BackgroundImage = "concert.jpg",
                    //IconImage = "button_play@2x.png",
                    Text = "Bedtime Stories",
                    Column = 1,
                    Row = 1,
                    NavigateType = typeof(Page4)
                }
                //new Models.Tile () {
                //    BackgroundImage = "accessoriesbg.png",
                //    IconImage = "accessories.png",
                //    Text = "Accessories",
                //    Column = 1,
                //    Row = 1,
                //    NavigateType = typeof(Page5)
                //},
                //new Models.Tile () {
                //    BackgroundImage = "housewaresbg.png",
                //    IconImage = "housewares.png",
                //    Text = "Housewares",
                //    Column = 2,
                //    Row = 1,
                //    NavigateType = typeof(Page6)
                //}
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
    }
}
