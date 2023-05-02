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
                var request = CoinCapClient().GetAsync($"assets").Result;
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
    }
}
