using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RiskIqSharp
{
    public class PassiveDns
    {
        [JsonPropertyName("pager")]
        public string Pager { get; set; }

        [JsonPropertyName("queryValue")]
        public string QueryValue { get; set; }

        [JsonPropertyName("queryType")]
        public string QueryType { get; set; }

        [JsonPropertyName("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonPropertyName("lastSeen")]
        public string LastSeen { get; set; }

        [JsonPropertyName("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonPropertyName("results")]
        public PassiveDnsMeta[] Results { get; set; }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="json"></param>
        /// <returns></returns>
        internal bool Parse(string json)
        {
            var data = JsonSerializer.Deserialize<PassiveDns>(json);

            this.Pager = data.Pager;
            this.QueryValue = data.QueryValue;
            this.QueryType = data.QueryType;
            this.FirstSeen = data.FirstSeen;
            this.LastSeen = data.LastSeen;
            this.TotalRecords = data.TotalRecords;
            this.Results = data.Results;

            return true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class PassiveDnsMeta
    {
        [JsonPropertyName("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonPropertyName("lastSeen")]
        public string LastSeen { get; set; }

        [JsonPropertyName("source")]
        public string[] Source { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("collected")]
        public string Collected { get; set; }

        [JsonPropertyName("recordType")]
        public string RecordType { get; set; }

        [JsonPropertyName("resolve")]
        public string Resolve { get; set; }

        [JsonPropertyName("resolveType")]
        public string ResolveType { get; set; }

        [JsonPropertyName("recordHash")]
        public string RecordHash { get; set; }
    }
}
