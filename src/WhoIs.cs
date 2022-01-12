using System.Text.Json;
using System.Text.Json.Serialization;

namespace RiskIqSharp
{
    /// <summary>
    /// 
    /// </summary>
    public class WhoIs
    {
        [JsonPropertyName("admin")]
        public WhoIsMeta Admin { get; set; }

        [JsonPropertyName("billing")]
        public WhoIsMeta Billing { get; set; }

        [JsonPropertyName("registrant")]
        public WhoIsMeta Registrant { get; set; }

        [JsonPropertyName("tech")]
        public WhoIsMeta Tech { get; set; }

        [JsonPropertyName("zone")]
        public WhoIsMeta Zone { get; set; }

        [JsonPropertyName("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonPropertyName("lastLoadedAt")]
        public string LastLoadedAt { get; set; }

        [JsonPropertyName("registered")]
        public string Registered { get; set; }

        [JsonPropertyName("registrar")]
        public string Registrar { get; set; }

        [JsonPropertyName("registryUpdatedAt")]
        public string RegistryUpdatedAt { get; set; }

        [JsonPropertyName("organization")]
        public string Organization { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }

        [JsonPropertyName("domainStatus")]
        public string DomainStatus { get; set; }

        [JsonPropertyName("rawText")]
        public string RawText { get; set; }

        [JsonPropertyName("nameServers")]
        public string[] NameServers { get; set; }

        /// <summary>
        /// </summary>
        /// 
        /// <param name="json"></param>
        /// <returns></returns>
        internal bool Parse(string json)
        {
            var data = JsonSerializer.Deserialize<WhoIs>(json);

            this.Admin = data.Admin;
            this.Billing = data.Billing;
            this.Registrant = data.Registrant;
            this.Tech = data.Tech;
            this.Zone = data.Zone;
            this.ContactEmail = data.ContactEmail;
            this.Domain = data.Domain;
            this.ExpiresAt = data.ExpiresAt;
            this.LastLoadedAt = data.LastLoadedAt;
            this.Registered = data.Registered;
            this.Registrar = data.Registrar;
            this.RegistryUpdatedAt = data.RegistryUpdatedAt;
            this.Organization = data.Organization;
            this.Name = data.Name;
            this.Telephone = data.Telephone;
            this.DomainStatus = data.DomainStatus;
            this.RawText = data.RawText;

            return true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class WhoIsMeta
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }
    }
}
