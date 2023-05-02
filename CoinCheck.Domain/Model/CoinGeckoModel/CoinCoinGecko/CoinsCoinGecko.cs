using Newtonsoft.Json;

namespace CoinCheck.Domain.Model.CoinGeckoModel.CoinCoinGecko
{
    public class CoinsCoinGecko
    {
        [JsonProperty("item")]
        public CoinCoinGecko? Coin { get; set; }
    }
}
