# RiskIqSharp

This is a simple C# library to interact with the RiskIQ API. It is implemented using .Net 6. Each API is implemented in two ways e.g. string or structured. The **structured** methods use defined objects with the library that are populated from the deserialised JSON returned from the originating API.

The following API's are implemented:

- Reputation (PassiveTotal)
- WhoIs (PassiveTotal)
- PassiveDns (PassiveTotal)
- Services (PassiveTotal)
- Enrichment (PassiveTotal)
- Enrichment - Malware (PassiveTotal)
- Enrichment - OS Int (PassiveTotal)
- Enrichment - Sub Domains (PassiveTotal)