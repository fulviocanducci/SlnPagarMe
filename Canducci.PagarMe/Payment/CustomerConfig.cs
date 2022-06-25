using System.Text.Json.Serialization;
namespace Canducci.PagarMe.Payment
{
    public class CustomerConfig
    {
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        [JsonPropertyName("billing")]
        public Billing Billing { get; set; }

        [JsonPropertyName("shipping")]
        public Shipping Shipping { get; set; }
    }

}
