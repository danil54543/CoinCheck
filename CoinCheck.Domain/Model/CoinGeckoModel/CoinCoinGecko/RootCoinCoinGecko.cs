using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCheck.Domain.Model.CoinGeckoModel.CoinCoinGecko
{
    public class RootCoinCoinGecko
    {
        [JsonProperty("coins")]
        public List<CoinsCoinGecko>? Coins { get; set; }
    }
}
