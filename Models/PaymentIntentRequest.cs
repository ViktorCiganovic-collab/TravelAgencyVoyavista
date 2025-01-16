namespace TravelAgencyVoyavista.Models
{
    public class PaymentIntentRequest
    {
        public int OrderId { get; set; }  // Order ID to associate with the payment
        public decimal Amount { get; set; }  // Amount to charge for the order
    }
}
