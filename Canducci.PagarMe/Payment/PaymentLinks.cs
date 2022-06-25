using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Canducci.PagarMe.Payment
{
    public class PaymentLinks
    {
        [JsonPropertyName("api_key")]
        public string ApiKey { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; } = new List<Item>();

        [JsonPropertyName("payment_config")]
        public PaymentConfig PaymentConfig { get; set; }

        [JsonPropertyName("postback_config")]
        public PostbackConfig PostbackConfig { get; set; }

        [JsonPropertyName("customer_config")]
        public CustomerConfig CustomerConfig { get; set; }

        [JsonPropertyName("max_orders")]
        public int MaxOrders { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }

}
