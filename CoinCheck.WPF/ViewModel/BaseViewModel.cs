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
       
        public string GetResponse(string address)
        {
            try
            {
                var client = new HttpClient() { BaseAddress = new Uri(CoinGeckoApi) };
                var request = client.GetAsync(address).Result;
                return request.EnsureSuccessStatusCode().Content.ReadAsStringAsync().Result;
            }
            catch (HttpRequestException ex)
            {              
                Console.WriteLine(ex.Message);
                return "";
            }

        }

    }
}
