using Newtonsoft.Json;

namespace CoinCheck.Domain.Model.CoinGeckoModel.Coin
{
    public class CoinsCoinGecko
    {
        [JsonProperty("item")]
        public CoinCoinGecko? Coin { get; set; }
    }
}
