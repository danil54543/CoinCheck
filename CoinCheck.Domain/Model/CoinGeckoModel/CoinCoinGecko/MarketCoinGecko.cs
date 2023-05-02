using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoinCheck.Domain.Model.CoinGeckoModel.CoinCoinGecko
{
    public class MarketCoinGecko
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }


        [JsonPropertyName("identifier")]
        public string? Identifier { get; set; }
    }
}
