using CoinCheck.Domain.Model.Coin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CoinCheck.WPF.ViewModel
{
    class TopCoinViewModel : BaseViewModel
    {
        private Coin selectedCoin;
        private HttpClient _httpClient;
        public Coin SelectedCoin
        {
            get { return selectedCoin; }
            set
            {
                selectedCoin = value;
                OnPropertyChanged("SelectedPhone");
            }
        }
        public List<Coin> Coins { get; set; }


        public TopCoinViewModel()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://api.coingecko.com/api/v3/") };
            Coins = GetTop7Coin();
        }
        public List<Coin> GetTop7Coin()
        {
            try
            {
                var request = _httpClient.GetAsync($"search/trending").Result;
                var responseBody = request.EnsureSuccessStatusCode().Content.ReadAsStringAsync().Result;
                var rootCoin = JsonConvert.DeserializeObject<RootCoin>(responseBody);
                var coinList = new List<Coin>();
                foreach (var coin in rootCoin.Coins)
                {
                    coinList.Add(coin.Coin);
                }
                return coinList;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return new();
            }
        }

    }
}
