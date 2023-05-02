using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinCheck.Domain.Model.CoinGeckoModel.CoinCoinGecko
{
    public class RootCoinCoinGeckoSearch
    {
        [JsonProperty("coins")]
        public List<CoinCoinGecko>? Coins { get; set; }
    }
}
