﻿using CoinCheck.Domain.Model.Coin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoinCheck.Service.Implementation
{
    public class CurrencyService
    {
        private readonly HttpClient _httpClient;

        public CurrencyService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://api.coingecko.com/api/v3/") };
        }

        public async Task<RootCoin> GetTop7Coin()
        {
            try
            {
                string responseBody = await(await _httpClient.GetAsync($"search/trending")).EnsureSuccessStatusCode().Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<RootCoin>(responseBody);

                return responseObject;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                return new();
            }
        }
    }
}