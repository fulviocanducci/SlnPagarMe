using System.Text.Json.Serialization;
namespace Canducci.PagarMe.Payment
{
    public class PostbackConfig
    {
        [JsonPropertyName("orders")]
        public string Orders { get; set; }

        [JsonPropertyName("transactions")]
        public string Transactions { get; set; }
    }

}
