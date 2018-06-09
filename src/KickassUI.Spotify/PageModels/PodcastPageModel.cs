using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using Darwin.Models;
using PropertyChanged;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Darwin.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class PodcastPageModel : FreshBasePageModel
    {
        bool openingPage;

        public Podcast Podcast { get; set; }
		public List<Podcast> Episodes { get; set; }

        public async void OnPodcastSelected (object sender, SelectedItemChangedEventArgs e)
        {

            //var episdoe = e.SelectedItem as AudioFile;
            //if (episdoe == null)
                //return;
            
			await CoreMethods.PushPageModel<PlayerPageModel>(Podcast, true, true);
        }

        // FreshMVVM Constructor
        public override void Init(object initData)
        {
            base.Init(initData);

            Podcast = initData as Podcast;

			Episodes = new List<Podcast>()
			{
				new Podcast() { Author=Podcast.Author, Title="Episode 10" },
				new Podcast() { Author=Podcast.Author, Title="Episode 9" },
				new Podcast() { Author=Podcast.Author, Title="Episode 8" },
				new Podcast() { Author=Podcast.Author, Title="Episode 7" },
				new Podcast() { Author=Podcast.Author, Title="Episode 6" },
				new Podcast() { Author=Podcast.Author, Title="Episode 5" },
				new Podcast() { Author=Podcast.Author, Title="Episode 4" },
				new Podcast() { Author=Podcast.Author, Title="Episode 3" }

			};
            
			// LOAD EPISODES
			//var client = new HttpClient();
   //         client.BaseAddress = new Uri("http://ec2-18-219-52-58.us-east-2.compute.amazonaws.com:5000");
   //         client.DefaultRequestHeaders.Add("User-Agent", "Anything");
   //         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			//var response = client.GetAsync($"api_pc_epsd/{Podcast.Title}").Result;

   //         response.EnsureSuccessStatusCode();
   //         var stream = response.Content.ReadAsStringAsync().Result;
			//Podcast.Episodes = JsonConvert.DeserializeObject<List<AudioFile>>(stream); 

        }

        ICommand openPlayerCommand;
        public ICommand OpenPlayerCommand
        {
            get
            {
				return openPlayerCommand ?? (openPlayerCommand = new Command<Podcast>(async (item) => await OpenPlayer(item), (arg) => !openingPage));
            }
        }
        

        public async Task OpenPlayer(Podcast item)
        {
           await CoreMethods.PushPageModel<PlayerPageModel>(item, true, true);
        }

    }
}
