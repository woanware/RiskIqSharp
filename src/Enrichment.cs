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

    public class EnrichmentMalware
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("results")]
        public MalwareMeta[] Results { get; set; }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="json"></param>
        /// <returns></returns>
        internal bool Parse(string json)
        {
            var data = JsonSerializer.Deserialize<EnrichmentMalware>(json);

            this.Success = data.Success;
            this.Results = data.Results;

            return true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MalwareMeta
    {
        [JsonPropertyName("collectionDate")]
        public string CollectionDate { get; set; }

        [JsonPropertyName("sample")]
        public string Sample { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("sourceUrl")]
        public string SourceUrl { get; set; }
    }

    public class EnrichmentOsint
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("results")]
        public OsintMeta[] Results { get; set; }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="json"></param>
        /// <returns></returns>
        internal bool Parse(string json)
        {
            var data = JsonSerializer.Deserialize<EnrichmentOsint>(json);

            this.Success = data.Success;
            this.Results = data.Results;

            return true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class OsintMeta
    {
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("sourceUrl")]
        public string SourceUrl { get; set; }

        [JsonPropertyName("indicators")]
        public string[] Indicators { get; set; }

        [JsonPropertyName("compromised")]
        public string[] Compromised { get; set; }

        [JsonPropertyName("tags")]
        public string[] Tags { get; set; }

        [JsonPropertyName("derived")]
        public string[] Derived { get; set; }

        [JsonPropertyName("inReport")]
        public string[] InReport { get; set; }
    }

    public class EnrichmentSubDomains
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("primaryDomain")]
        public string PrimaryDomain { get; set; }

        [JsonPropertyName("subdomains")]
        public string[] SubDomains { get; set; }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="json"></param>
        /// <returns></returns>
        internal bool Parse(string json)
        {
            var data = JsonSerializer.Deserialize<EnrichmentSubDomains>(json);

            this.Success = data.Success;
            this.PrimaryDomain = data.PrimaryDomain;
            this.SubDomains = data.SubDomains;

            return true;
        }
    }
}
