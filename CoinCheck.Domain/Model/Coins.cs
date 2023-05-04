using Newtonsoft.Json;

namespace CoinCheck.Domain.Model
{
    public class Coins
    {
        [JsonProperty("item")]
        public Coin? Coin { get; set; }
    }
}
