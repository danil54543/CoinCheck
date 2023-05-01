using CoinCheck.Domain.Model.Coin;
using CoinCheck.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoinCheck.Service.Implementation
{
    public class CurrencyService 
    {
        private  HttpClient _httpClient;

        public CurrencyService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://api.coingecko.com/api/v3/") };
        }

       
    }
}
