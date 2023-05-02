using CoinCheck.Domain.Model.CoinCapModel.CoinCoinCap;
using CoinCheck.Domain.Model.CoinGeckoModel.CoinCoinGecko;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CoinCheck.WPF.ViewModel
{
    internal class CoinListViewModel : BaseViewModel
    {
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
        public List<CoinCoinCap> Coins { get; set; } = new();

        public void GetAllCoin()
        {
            try
            {
                Coins.Clear();
                var request = CoinCapClient().GetAsync("assets").Result;
                var responseBody = request.EnsureSuccessStatusCode().Content.ReadAsStringAsync().Result;
                var coinList = JsonConvert.DeserializeObject<CoinsCoinCap>(responseBody);
                foreach (var coin in coinList.Coins)
                {
                    Coins.Add(coin);
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Search(string query)
        {
            try
            {
                Coins.Clear();
                var request = CoinGeckoClient().GetAsync("search?query=" + query).Result;
                var responseBody = request.EnsureSuccessStatusCode().Content.ReadAsStringAsync().Result;
                var rootCoin = JsonConvert.DeserializeObject<RootCoinCoinGeckoSearch>(responseBody);
                var coinList = new List<CoinCoinGecko>();
                foreach (var coin in rootCoin.Coins)
                {
                    
                    Coins.Add(new()
                    {
                        Id = coin.Id,
                        Name = coin.Name,
                        Symbol = coin.Symbol,
                    });
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
