using System.Text.Json.Serialization;

namespace CoinCheck.Domain.Model.Exchange
{
    public class Exchange
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }


        [JsonPropertyName("identifier")]
        public string? Identifier { get; set; }
    }
}
