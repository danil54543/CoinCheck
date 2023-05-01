using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCheck.Domain.Model.CoinGeckoModel.Coin
{
    public class TickerCoinGecko
    {
        [JsonProperty("market")]
        public List<MarketCoinGecko>? Markets { get; set; }


        [JsonProperty("trade_url")]
        public string? Url { get; set; }
    }
}
