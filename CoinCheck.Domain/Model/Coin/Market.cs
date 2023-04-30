using System.Text.Json.Serialization;

namespace CoinCheck.Domain.Model.Coin
{
    public class Market
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }


        [JsonPropertyName("identifier")]
        public string? Identifier { get; set; }
    }
}
