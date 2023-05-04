using CoinCheck.Domain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CoinCheck.WPF.ViewModel
{
    internal class CoinListViewModel : BaseViewModel
    {
        private Coin selectedCoin;

        public Coin SelectedCoin
        {
            get { return selectedCoin; }
            set
            {
                selectedCoin = value;
                OnPropertyChanged("SelectedCoin");
            }
        }
        public List<Coin> Coins { get; set; } = new();

        public void GetAllCoin()
        {
            try
            {
                Coins.Clear();
                var coinList = JsonConvert.DeserializeObject<RootCoinSearch>(GetResponse("search?query=%20"));
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
                var rootCoin = JsonConvert.DeserializeObject<RootCoinSearch>(GetResponse("search?query=" + query));
                var coinList = new List<Coin>();
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
