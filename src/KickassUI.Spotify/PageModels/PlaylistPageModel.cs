using System;
using System.Collections.Generic;
using FreshMvvm;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Darwin.PageModels
{
	public class PlaylistPageModel : FreshBasePageModel
    {
		public List<Models.Podcast> Playlist { get; set; }

        public PlaylistPageModel()
        {
			// Get using home API
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://ec2-18-219-52-58.us-east-2.compute.amazonaws.com");
            client.DefaultRequestHeaders.Add("User-Agent", "Anything");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync("api_play_list").Result;

            response.EnsureSuccessStatusCode();
            var stream = response.Content.ReadAsStringAsync().Result;
			Playlist = JsonConvert.DeserializeObject<List<Models.Podcast>>(stream);      
        }

		public async Task OpenPlayer(Models.Podcast item)
        {
            await CoreMethods.PushPageModel<PlayerPageModel>(item, true, true);
        }
    }
}
