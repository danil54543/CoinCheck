using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinCheck.Domain.Model.Coin
{
    public class Coins
    {
        [JsonProperty("item")]
        public Coin? Coin { get; set; }
    }
}
