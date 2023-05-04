using Newtonsoft.Json;

namespace CoinCheck.Domain.Model
{
    public class MarketData
    {
        [JsonProperty("current_price")]
        public CurrentPrice? CurrentPrice { get; set; }
    }
}
