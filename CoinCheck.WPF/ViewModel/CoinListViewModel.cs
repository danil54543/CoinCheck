using CoinCheck.Domain.Model.CoinCapModel.CoinCoinCap;
using CoinCheck.Domain.Model.CoinGeckoModel.Coin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CoinCheck.WPF.ViewModel
{
    internal class CoinListViewModel : BaseViewModel
    {
        private CoinCoinGecko? selectedCoin;

        public CoinListViewModel()
        {
            Coins = GetAllCoin();
        }

        public CoinCoinGecko? SelectedCoin  
        {
            get { return selectedCoin; }
            set
            {
                selectedCoin = value;
                OnPropertyChanged("SelectedCoin");
            }
        }
        public List<CoinCoinCap> Coins { get; set; }

        public List<CoinCoinCap> GetAllCoin()
        {
            try
            {
                var request = CoinCapClient().GetAsync($"assets").Result;
                var responseBody = request.EnsureSuccessStatusCode().Content.ReadAsStringAsync().Result;
                var coinList = JsonConvert.DeserializeObject<CoinsCoinCap>(responseBody);
                List<CoinCoinCap> result = new();
                foreach (var coin in coinList.Coins)
                {
                    result.Add(coin);
                }
                return result ?? throw new HttpRequestException("CoinCap api response equals null.");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return new();
            }
        }
    }
}
