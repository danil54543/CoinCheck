using Newtonsoft.Json;

namespace CoinCheck.Domain.Model
{
    public class CurrentPrice
    {
        [JsonProperty("usd")]
        public double Usd { get; set; }


        [JsonProperty("uah")]
        public double Uah { get; set; }
    }
}
