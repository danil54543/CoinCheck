using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCheck.Domain.Model.Coin
{
    public class RootCoin
    {
        [JsonProperty("coins")]
        public List<Coins>? Coins { get; set; }
    }
}
