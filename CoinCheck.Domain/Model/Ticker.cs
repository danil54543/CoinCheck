using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinCheck.Domain.Model
{
    public class Ticker
    {
        [JsonProperty("market")]
        public List<Market>? Markets { get; set; }


        [JsonProperty("trade_url")]
        public string? Url { get; set; }


    }
}
