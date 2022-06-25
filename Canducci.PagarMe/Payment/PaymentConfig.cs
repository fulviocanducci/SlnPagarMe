using System.Text.Json.Serialization;
namespace Canducci.PagarMe.Payment
{
    public class PaymentConfig
    {
        [JsonPropertyName("boleto")]
        public Boleto Boleto { get; set; }

        [JsonPropertyName("credit_card")]
        public CreditCard CreditCard { get; set; }

        [JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }
    }

}
