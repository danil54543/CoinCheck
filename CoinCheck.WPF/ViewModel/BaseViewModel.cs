using System;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace CoinCheck.WPF.ViewModel
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        private const string CoinGeckoApi = "https://api.coingecko.com/api/v3/";
        private const string CoinCapApi = "https://api.coincap.io/v2/";



        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public HttpClient CoinGeckoClient()
        {
            return new() { BaseAddress = new Uri(CoinGeckoApi) };
        }
        public HttpClient CoinCapClient()
        {
            return new() { BaseAddress = new Uri(CoinCapApi) };
        }
    }
}
