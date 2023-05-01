using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinCheck.Domain.Model.CoinGeckoModel.Coin
{
    public class CoinCoinGecko
    {
        [JsonProperty("id")]
        public string? Id { get; set; }


        [JsonProperty("name")]
        public string? Name { get; set; }


        [JsonProperty("symbol")]
        public string? Symbol { get; set; }


        [JsonProperty("tickers")]
        public List<TickerCoinGecko>? Tickers { get; set; }
    }
}
