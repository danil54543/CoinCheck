using CoinCheck.Domain.Model;
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
            GetTopCoin();
        }

        private Coin? selectedCoin;

        public Coin? SelectedCoin
        {
            get { return selectedCoin; }
            set
            {
                selectedCoin = value;
                OnPropertyChanged("SelectedCoin");
            }
        }

        public List<Coin> Coins { get; set; }

        public void GetTopCoin()
        {
            try
            {
                Coins = new();
                var rootCoin = JsonConvert.DeserializeObject<RootCoin>(GetResponse("search/trending"));
                foreach (var coin in rootCoin.Coins)
                {
                    Coins.Add(coin.Coin);
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
