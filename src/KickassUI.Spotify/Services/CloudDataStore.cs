using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

//namespace Darwin.Services
//{
//	internal class CloudDataStore
//	{
//		private static void Main()
//		{
//			WebRequest webRequest;
//			List<Models.TestPodcast> testPodcasts = new List<Models.TestPodcast>();

//			webRequest = WebRequest.Create("http://ec2-18-219-52-58.us-east-2.compute.amazonaws.com:5000/api_home") as HttpWebRequest;
//			if (webRequest == null)
//			{
//				return;
//			}

//			webRequest.ContentType = "application/json";
//			//webRequest.UserAgent = "Nothing";
            

//			using (var s = webRequest.GetResponse().GetResponseStream())
//			{
//				using (var sr = new StreamReader(s))
//				{
//					var contributorsAsJson = sr.ReadToEnd();
//					var contributors = JsonConvert.DeserializeObject<List<Models.TestPodcast>>(contributorsAsJson);
//					contributors.ForEach(Console.WriteLine);
//				}
//			}
//		}
//	}
//}

  //      public CloudDataStore()
  //      {
		//	Client = new AWSHttpClient();
		//	Client.BaseAddress = new Uri("http://ec2-18-219-52-58.us-east-2.compute.amazonaws.com:5000/api_home");    


		//	testPodcasts = new List<Models.TestPodcast>();   
    
  //      }

		//public async Task<IEnumerable<Models.TestPodcast>> GetItemsAsync()
  //      {
  //          if (true)
		//	{
		//		var json = await Client.GetStreamAsync("api_home");
		//		testPodcasts = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Models.TestPodcast>>(json));
  //          }

		//	return testPodcasts;
  //      }

		////HttpClient client;
        ////IEnumerable<Item> items;

        ////public CloudDataStore()
        ////{
        ////    client = new HttpClient();
        ////    client.BaseAddress = new Uri($"{App.BackendUrl}/");

        ////    items = new List<Item>();
        ////}

        ////public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        ////{
        ////    if (forceRefresh && CrossConnectivity.Current.IsConnected)
        ////    {
        ////        var json = await client.GetStringAsync($"api/item");
        ////        items = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Item>>(json));
        ////    }

        ////    return items;
        ////}

        ////public async Task<Item> GetItemAsync(string id)
        ////{
        ////    if (id != null && CrossConnectivity.Current.IsConnected)
        ////    {
        ////        var json = await client.GetStringAsync($"api/item/{id}");
        ////        return await Task.Run(() => JsonConvert.DeserializeObject<Item>(json));
        ////    }

        ////    return null;
        ////}

        
//    }
//}
