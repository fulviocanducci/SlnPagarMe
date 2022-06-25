using Refit;
using System.Threading.Tasks;
namespace Canducci.PagarMe.Payment
{
    public interface IPaymentRequest
    {
        [Post("/payment_links")]
        Task<PaymentLinks> Create([Body] PaymentLinks model, [Query][AliasAs("api_key")] string apiKey);

        [Get("/payment_links")]
        Task<PaymentLinks> All([Query][AliasAs("api_key")] string apiKey);

        [Get("/payment_links/{paymentLinkId}")]
        Task<PaymentLinks> Get(string paymentLinkId, [Query][AliasAs("api_key")] string apiKey);
        
        [Post("/payment_links/{payment_link_id}/cancel")]
        Task<PaymentLinks> Cancel(string paymentLinkId, [Query][AliasAs("api_key")] string apiKey);
    }
}