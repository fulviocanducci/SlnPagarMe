using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Canducci.PagarMe.Payment
{
    public class Customer
    {
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("documents")]
        public List<Document> Documents { get; set; } = new List<Document>();

        [JsonPropertyName("phone_numbers")]
        public List<string> PhoneNumbers { get; set; } = new List<string>();

        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }
    }

}
