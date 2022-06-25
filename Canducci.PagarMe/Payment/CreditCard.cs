using System.Text.Json.Serialization;
namespace Canducci.PagarMe.Payment
{
    public class CreditCard
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("free_installments")]
        public int FreeInstallments { get; set; }

        [JsonPropertyName("interest_rate")]
        public int InterestRate { get; set; }

        [JsonPropertyName("max_installments")]
        public int MaxInstallments { get; set; }
    }

}
