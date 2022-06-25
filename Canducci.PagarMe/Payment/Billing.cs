using System.Text.Json.Serialization;
namespace Canducci.PagarMe.Payment
{
    public class Billing
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }
    }

}
