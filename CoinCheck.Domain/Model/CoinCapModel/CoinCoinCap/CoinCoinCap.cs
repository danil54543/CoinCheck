using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public decimal PriceUsd { get; set; }


        [JsonProperty("changePercent24Hr")]
        public decimal ChangePercent24Hr { get; set; }
    }
}
