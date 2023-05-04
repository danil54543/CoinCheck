using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinCheck.Domain.Model
{
    public class RootCoinSearch
    {
        [JsonProperty("coins")]
        public List<Coin>? Coins { get; set; }
    }
}
