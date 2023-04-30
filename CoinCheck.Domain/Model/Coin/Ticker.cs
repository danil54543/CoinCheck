using Newtonsoft.Json;
using System.Collections.Generic;


namespace CoinCheck.Domain.Model.Coin
{
    public class Ticker
    {
        [JsonProperty("market")]
        public List<Exchange.Exchange>? Exchanges { get; set; }

        
        [JsonProperty("trade_url")]
        public string? Url { get; set; }
    }
}
