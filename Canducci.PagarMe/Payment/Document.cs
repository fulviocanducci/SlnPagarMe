using System.Text.Json.Serialization;
namespace Canducci.PagarMe.Payment
{
    public class Document
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }
    }

}
