using Newtonsoft.Json;
using System;

namespace CoinCheck.Domain.Model.CoinCapModel.CoinCoinCap
{
    public class CoinCoinCap
    {

        [JsonProperty("id")]
        public string? Id { get; set; }


        [JsonProperty("rank")]
        public int Rank { get; set; }


        [JsonProperty("symbol")]
        public string? Symbol { get; set; }


        [JsonProperty("name")]
        public string? Name { get; set; }


        [JsonProperty("priceUsd")]
        public string PriceUsd { get; set; }



        [JsonProperty("changePercent24Hr")]
        public string ChangePercent24Hr { get; set; }
    
        

    }
}
