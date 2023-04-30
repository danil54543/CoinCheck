using CoinCheck.Domain.Model.Coin;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinCheck.Domain
{
    public class Coin
    {
        [JsonProperty("id")]
        public string? Id { get; set; }


        [JsonProperty("name")]
        public string? Name { get; set; }


        [JsonProperty("symbol")]
        public string? Symbol { get; set; }


        [JsonProperty("rank")]
        public int Rank { get; set; }


        [JsonProperty("tickers")]
        public List<Ticker>? Tickers { get; set; }
    }
}
