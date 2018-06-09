using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Darwin.Models;
using Xamarin.Forms;

namespace Darwin.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        bool openingPage;

        public List<Album> Albums { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<AudioFile> Songs { get; set; }
        public List<AudioFile> Podcasts { get; set;  }

        /// <summary>
        /// LISTS FOR HOME PAGE
        /// </summary>
        /// <value>Up next.</value>
		public List<Podcast> UpNext { get; set; }
		public List<Podcast> Friends { get; set; }
		public List<Podcast> Trending { get; set; }


        ICommand openPlayerCommand;
        public ICommand OpenPlayerCommand
        {
            get
            {
				return openPlayerCommand ?? (openPlayerCommand = new Command<Podcast>(async (item) => await OpenPlayer(item), (arg) => !openingPage));
            }
        }

        public MainPageModel()
        {
            // LOAD UP NEXT
			var client = new HttpClient();
            client.BaseAddress = new Uri("http://ec2-18-219-52-58.us-east-2.compute.amazonaws.com");
            client.DefaultRequestHeaders.Add("User-Agent", "Anything");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync("api_up_next").Result;

            response.EnsureSuccessStatusCode();
            var stream = response.Content.ReadAsStringAsync().Result;
			UpNext = JsonConvert.DeserializeObject<List<Podcast>>(stream);  
            //

            // LOAD FRIENDS
			response = client.GetAsync("api_friends").Result;

            response.EnsureSuccessStatusCode();
            stream = response.Content.ReadAsStringAsync().Result;
			Friends = JsonConvert.DeserializeObject<List<Podcast>>(stream); 
            //

            // LOAD TRENDING
			response = client.GetAsync("api_trending").Result;

            response.EnsureSuccessStatusCode();
            stream = response.Content.ReadAsStringAsync().Result;
			Trending = JsonConvert.DeserializeObject<List<Podcast>>(stream); 
            //

            

            // LOAD UP NEXT EPIDOSDES
			//foreach (Podcast p in UpNext)
			//{
			//	response = client.GetAsync($"api_pc_epsd/{p.Title}").Result;
			//	response.EnsureSuccessStatusCode();
   //             stream = response.Content.ReadAsStringAsync().Result;
			//	p.Episodes = JsonConvert.DeserializeObject<List<AudioFile>>(stream);
			//}
            

            Albums = new List<Album> {
                new Album(){ Author="Royal Blood", Name="Royal Blood", ImageUrl="https://upload.wikimedia.org/wikipedia/en/b/b0/Royal_Blood_-_Royal_Blood_%28Artwork%29.jpg"},
                new Album(){ Author="Fall Out Boy", Name="Infinity On High", ImageUrl="https://upload.wikimedia.org/wikipedia/en/6/69/Infinityonhigh.jpg"},
                new Album(){ Author="Muse", Name="Drones", ImageUrl="https://upload.wikimedia.org/wikipedia/en/4/44/MuseDronesCover.jpg"},
                new Album(){ Author="System Of A Down", Name="Mesmerize", ImageUrl="https://upload.wikimedia.org/wikipedia/en/0/02/Mezmerize-LP.jpg"},
                new Album(){ Author="Muse", Name="Black Holes And Revelations", ImageUrl="https://upload.wikimedia.org/wikipedia/en/c/c5/BlackHolesCover.jpg"},
            };

            Playlists = new List<Playlist>()
            {
                    new Playlist(){ Name="Funk Rock", NrOfFollowers=49205, ImageUrl="https://i.scdn.co/image/a9cdead5cf5d85a33e7bc12b49d1006821650ca4"},
                    new Playlist(){ Name="Rock Solid", NrOfFollowers=5025, ImageUrl="https://i.scdn.co/image/993ea43e0521938d5bf7a4fbe4f349acf6500975"},
                    new Playlist(){ Name="This Is: Muse", NrOfFollowers=2140415, ImageUrl="https://i.scdn.co/image/3770c6d556b864e60684d0706013ff08dac76918"},
                    new Playlist(){ Name="100% Scooter", NrOfFollowers=7447, ImageUrl="https://i.scdn.co/image/98cc42f3671e7c14b2593cce05cf2abb87247ab2"},
                    new Playlist(){ Name="Feeling Good, Feeling Great", NrOfFollowers=250211, ImageUrl="https://i.scdn.co/image/9c003edf2bcc3386c400d087b3bb4adb75ee1f5a"},
            };

            Songs = new List<AudioFile>()
            {
                    new Song(){ Author="Muse", Title="Dig Down", LengthInSeconds=228, Image="https://i.scdn.co/image/08d56eac0c7d48bb8bf7752b2202c3314db79394"},
                    new Song(){ Author="Gorillaz", Title="Clint Eastwood", LengthInSeconds=341, Image="https://i.scdn.co/image/6c6086f6922b9a44920310b34ef98161bd7adf78"},
                    new Song(){ Author="Jamiroquai", Title="Virtual Insanity", LengthInSeconds=229, Image="https://i.scdn.co/image/bb3810cd18de42b93c54536d7e9ab7f8c10a8229"},
                    new Song(){ Author="Biffy Clyro", Title="The Captain", LengthInSeconds=223, Image="https://i.scdn.co/image/f8d0b0bdf4a541fb2d13cb63e958aa760e3547e5"},
                    new Song(){ Author="System of a Down", Title="Hypnotize", LengthInSeconds=189, Image="https://i.scdn.co/image/66eb75e0f3a8a91822ba7154e4b41066e63e51f2"},
                    new Song(){ Author="Paramore", Title="Hard Times", LengthInSeconds=182, Image="https://i.scdn.co/image/d8296568ae1b856050976111fa892d8db693efd5"}
            };

            Podcasts = new List<AudioFile>()
            {
                new Podcast() { Author="Barstool Sports", Title="Pardon My Take", LengthInSeconds=69, Image="https://www.podcastone.com/imagesproc/L2ltYWdlcy9sb2dvcy8zMDB4MzAwL3BvZF9QTVRfMl8zMDAuanBn_H_SW300_MH300.jpg" },
                new Podcast() { Author="Kehlani", Title="Good As Hell", LengthInSeconds=69, Image="https://spotifyblogcom.files.wordpress.com/2018/02/podcast-cover-key-art_good_as_hell-1.jpg?w=730&h=730&zoom=2"},
                new Podcast() { Author="Andrew Zarian & Paul Thurott", Title="What The Tech?", LengthInSeconds=69, Image="https://pbs.twimg.com/profile_images/555049025930407936/rUdJjyZn.jpeg"}
            };

    //        foreach (Podcast p in Podcasts)
    //        {
				//p.Episodes = new List<AudioFile>()
     //           {
					//new AudioFile() { Author="Barstool Sports", Title = "Episode 1", LengthInSeconds=228, Image="https://www.podcastone.com/imagesproc/L2ltYWdlcy9sb2dvcy8zMDB4MzAwL3BvZF9QTVRfMl8zMDAuanBn_H_SW300_MH300.jpg"},
					//new AudioFile() { Author="Barstool Sports", Title = "Episode 2", Image="https://www.podcastone.com/imagesproc/L2ltYWdlcy9sb2dvcy8zMDB4MzAwL3BvZF9QTVRfMl8zMDAuanBn_H_SW300_MH300.jpg"},
					//new AudioFile() { Author="Barstool Sports", Title = "Episode 3", Image="https://www.podcastone.com/imagesproc/L2ltYWdlcy9sb2dvcy8zMDB4MzAwL3BvZF9QTVRfMl8zMDAuanBn_H_SW300_MH300.jpg"},
					//new AudioFile() { Author="Barstool Sports", Title = "Episode 4", Image="https://www.podcastone.com/imagesproc/L2ltYWdlcy9sb2dvcy8zMDB4MzAwL3BvZF9QTVRfMl8zMDAuanBn_H_SW300_MH300.jpg"}

            //    };
            //}
        
        }

		async Task OpenPlayer(Podcast item)
        {
           await CoreMethods.PushPageModel<PodcastPageModel>(item);
                
        }
    }
}
