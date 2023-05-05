using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinCheck.Domain.Model
{
    public class Ticker
    {
        [JsonProperty("market")]
        public Market? Markets { get; set; }


        [JsonProperty("trade_url")]
        public string? Url { get; set; }


    }
}
