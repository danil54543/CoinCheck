using CoinCheck.Domain.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace CoinCheck.WPF.ViewModel
{
    internal class CoinInfoViewModel : BaseViewModel
    {
        public Coin Coin { get; set; }
        public void GetData(string id)
        {
            try
            {
                Coin = JsonConvert.DeserializeObject<Coin>(GetResponse("/coins/" + id));              
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
