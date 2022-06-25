using System.Text.Json.Serialization;
namespace Canducci.PagarMe.Payment
{
    public class Shipping
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("fee")]
        public int Fee { get; set; }

        [JsonPropertyName("delivery_date")]
        public string Delivery_date { get; set; }

        [JsonPropertyName("expedited")]
        public bool Expedited { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }
    }

}
