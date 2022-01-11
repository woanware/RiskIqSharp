using System.Text.Json;
using System.Text.Json.Serialization;

namespace RiskIqSharp
{
    /// <summary>
    /// 
    /// </summary>
    public class Reputation
    {
        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("classification")]
        public string Classification { get; set; }

        [JsonPropertyName("rules")]
        public Rule[] Rules { get; set; }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="json"></param>
        /// <returns></returns>
        public bool Parse(string json)
        {
            var data = JsonSerializer.Deserialize<Reputation>(json);

            this.Score = data.Score;
            this.Classification = data.Classification;
            this.Rules = data.Rules;

            return true;
        }
    }
}
