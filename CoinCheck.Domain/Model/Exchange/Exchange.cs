using Newtonsoft.Json;

namespace CoinCheck.Domain.Model.Exchange
{
    public class Exchange
    {
        [JsonProperty("id")]
        public string? Id { get; set; }


        [JsonProperty("name")]
        public string? Name { get; set; }


        [JsonProperty("year_established")]
        public string? YearEstablished { get; set; }


        [JsonProperty("country")]
        public string? Country { get; set; }


        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
