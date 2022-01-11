using System.Text.Json.Serialization;

namespace RiskIqSharp
{
    public class Rule
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("severity")]
        public int Severity { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }
    }
}
