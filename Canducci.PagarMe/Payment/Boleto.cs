using System.Text.Json.Serialization;
namespace Canducci.PagarMe.Payment
{
    public class Boleto
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }

}
