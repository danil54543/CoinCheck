using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCheck.Domain.Model.CoinCapModel.CoinCoinCap
{
    public class CoinsCoinCap
    {
        [JsonProperty("data")]
        public List<CoinCoinCap>? Coins { get; set; }
    }
}
