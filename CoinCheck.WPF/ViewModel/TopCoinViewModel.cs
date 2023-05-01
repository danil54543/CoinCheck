using CoinCheck.Domain.Model.CoinGeckoModel.Coin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CoinCheck.WPF.ViewModel
{
    internal class TopCoinViewModel : BaseViewModel
    {
        public TopCoinViewModel()
        {
            Coins = GetTopCoin();
        }

        private CoinCoinGecko? selectedCoin;

        public CoinCoinGecko? SelectedCoin
        {
            get { return selectedCoin; }
            set
            {
                selectedCoin = value;
                OnPropertyChanged("SelectedCoin");
            }
        }

        public List<CoinCoinGecko> Coins { get; set; }

        public List<CoinCoinGecko> GetTopCoin()
        {
            try
            {
                var request = CoinGeckoClient().GetAsync($"search/trending").Result;
                var responseBody = request.EnsureSuccessStatusCode().Content.ReadAsStringAsync().Result;
                var rootCoin = JsonConvert.DeserializeObject<RootCoinCoinGecko>(responseBody);
                var coinList = new List<CoinCoinGecko>();
                foreach (var coin in rootCoin.Coins)
                {
                    coinList.Add(coin.Coin);
                }
                return coinList ?? throw new HttpRequestException("Response equals null.");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return new();
            }
        }

    }
}
