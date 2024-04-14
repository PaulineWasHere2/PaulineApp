using System;
using PaulineApp.Models;
using PaulineApp.Helpers;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using PaulineApp.Views;

namespace PaulineApp.ViewModels
{

    public class APIPage : BaseViewModel
    {
        public ObservableCollection<Root> LatestLaunchs { get; set; }

        private readonly HttpClient _client;

        public APIPage()
        {
            _client = new HttpClient();
            LatestLaunchs = new ObservableCollection<Root>();
        }

        public void PopulateLatestLaunchs()
        {
            foreach (Root lauch in RetriveAllLatestLaunchs())
            {
                LatestLaunchs.Add(lauch);
            }
        }

        private ObservableCollection<Root> RetriveAllLatestLaunchs()
        {
            var latestLaunchsSerialized = _client.GetStringAsync(Constants.BaseUrl + "launches/past").Result;
            var latestLaunchsDeserialized = JsonConvert.DeserializeObject<List<Root>>(latestLaunchsSerialized);

            ObservableCollection<Root> allLaunchs = new(latestLaunchsDeserialized);

            return allLaunchs;
        }
    }
}