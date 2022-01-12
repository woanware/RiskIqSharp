using System.Text.Json;
using System.Text.Json.Serialization;

namespace RiskIqSharp
{
    public class Enrichment
    {
        [JsonPropertyName("classification")]
        public string Classification { get; set; }

        [JsonPropertyName("sinkhole")]
        public bool Sinkhole { get; set; }

        [JsonPropertyName("everCompromised")]
        public bool EverCompromised { get; set; }

        [JsonPropertyName("queryType")]
        public string QueryType { get; set; }

        [JsonPropertyName("primaryDomain")]
        public string PrimaryDomain { get; set; }

        [JsonPropertyName("tld")]
        public string Tld { get; set; }

        [JsonPropertyName("subdomains")]
        public string[] Subdomains { get; set; }

        [JsonPropertyName("global_tags")]
        public string[] GlobalTags { get; set; }

        [JsonPropertyName("tags")]
        public string[] Tags { get; set; }

        [JsonPropertyName("system_tags")]
        public string[] SystemTags { get; set; }

        [JsonPropertyName("dynamicDns")]
        public bool DynamicDns { get; set; }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="json"></param>
        /// <returns></returns>
        internal bool Parse(string json)
        {
            var data = JsonSerializer.Deserialize<Enrichment>(json);

            this.Classification = data.Classification;
            this.Sinkhole = data.Sinkhole;
            this.EverCompromised = data.EverCompromised;
            this.QueryType = data.QueryType;
            this.PrimaryDomain = data.PrimaryDomain;
            this.Tld = data.Tld;
            this.Subdomains = data.Subdomains;
            this.GlobalTags = data.GlobalTags;
            this.Tags = data.Tags;
            this.SystemTags = data.SystemTags;
            this.DynamicDns = data.DynamicDns;
 
            return true;
        }
    }
}
