using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RiskIqSharp
{
    public class Services
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonPropertyName("results")]
        public Result[] Results { get; set; }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="json"></param>
        /// <returns></returns>
        internal bool Parse(string json)
        {
            var data = JsonSerializer.Deserialize<Services>(json);

            this.Success = data.Success;
            this.TotalRecords = data.TotalRecords;
            this.Results = data.Results;

            return true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Result
    {
        [JsonPropertyName("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonPropertyName("lastSeen")]
        public string LastSeen { get; set; }

        [JsonPropertyName("portNumber")]
        public int PortNumber { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        [JsonPropertyName("banners")]
        public BannerMeta[] Banners { get; set; }

        [JsonPropertyName("currentServices")]
        public ServiceMeta[] CurrentServices { get; set; }

        [JsonPropertyName("recentServices")]
        public ServiceMeta[] RecentServices { get; set; }

        [JsonPropertyName("mostRecentSslCert")]
        public SslCert MostRecentSslCert { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class BannerMeta
    {
        [JsonPropertyName("banner")]
        public string Banner { get; set; }

        [JsonPropertyName("scanType")]
        public string ScanType { get; set; }

        [JsonPropertyName("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonPropertyName("lastSeen")]
        public string LastSeen { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ServiceMeta
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonPropertyName("lastSeen")]
        public string LastSeen { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SslCert
    {
        [JsonPropertyName("firstSeen")]
        public long FirstSeen { get; set; }

        [JsonPropertyName("lastSeen")]
        public long LastSeen { get; set; }

        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonPropertyName("sslVersion")]
        public string SslVersion { get; set; }

        [JsonPropertyName("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonPropertyName("issueDate")]
        public string IssueDate { get; set; }

        [JsonPropertyName("sha1")]
        public string Sha1 { get; set; }

        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonPropertyName("subjectCountry")]
        public string SubjectCountry { get; set; }

        [JsonPropertyName("issuerCommonName")]
        public string IssuerCommonName { get; set; }

        [JsonPropertyName("issuerProvince")]
        public string IssuerProvince { get; set; }

        [JsonPropertyName("subjectStateOrProvinceName")]
        public string SubjectStateOrProvinceName { get; set; }

        [JsonPropertyName("subjectStreetAddress")]
        public string SubjectStreetAddress { get; set; }

        [JsonPropertyName("issuerStateOrProvinceName")]
        public string IssuerStateOrProvinceName { get; set; }

        [JsonPropertyName("subjectSurname")]
        public string SubjectSurname { get; set; }

        [JsonPropertyName("issuerCountry")]
        public string IssuerCountry { get; set; }

        [JsonPropertyName("subjectLocalityName")]
        public string SubjectLocalityName { get; set; }

        [JsonPropertyName("subjectAlternativeNames")]
        public string[] SubjectAlternativeNames { get; set; }

        [JsonPropertyName("issuerOrganizationUnitName")]
        public string IssuerOrganizationUnitName { get; set; }

        [JsonPropertyName("issuerOrganizationName")]
        public string IssuerOrganizationName { get; set; }

        [JsonPropertyName("subjectEmailAddress")]
        public string SubjectEmailAddress { get; set; }

        [JsonPropertyName("subjectOrganizationName")]
        public string SubjectOrganizationName { get; set; }

        [JsonPropertyName("issuerLocalityName")]
        public string IssuerLocalityName { get; set; }

        [JsonPropertyName("subjectCommonName")]
        public string SubjectCommonName { get; set; }

        [JsonPropertyName("subjectProvince")]
        public string SubjectProvince { get; set; }

        [JsonPropertyName("issuerGivenName")]
        public string IssuerGivenName { get; set; }

        [JsonPropertyName("subjectOrganizationUnitName")]
        public string SubjectOrganizationUnitName { get; set; }

        [JsonPropertyName("issuerEmailAddress")]
        public string IssuerEmailAddress { get; set; }

        [JsonPropertyName("subjectGivenName")]
        public string SubjectGivenName { get; set; }

        [JsonPropertyName("subjectSerialNumber")]
        public string SubjectSerialNumber { get; set; }

        [JsonPropertyName("issuerStreetAddress")]
        public string IssuerStreetAddress { get; set; }

        [JsonPropertyName("issuerSerialNumber")]
        public string IssuerSerialNumber { get; set; }

        [JsonPropertyName("issuerSurname")]
        public string IssuerSurname { get; set; }
    }
}
