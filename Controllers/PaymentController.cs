

using Microsoft.AspNetCore.Mvc;
using Stripe;
using TravelAgencyVoyavista.Models;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;
using TravelAgencyVoyavista.Data;


namespace TravelAgencyVoyavista.Controllers
{
    public class PaymentController : Controller
    {
        private readonly StripeSettings _stripeSettings;
        private readonly ApplicationDbContext _dbContext;

        // Inject Stripe settings and ApplicationDbContext
        public PaymentController(IOptions<StripeSettings> stripeSettings, ApplicationDbContext dbContext)
        {
            _stripeSettings = stripeSettings.Value;
            StripeConfiguration.ApiKey = _stripeSettings.SecretKey;
            _dbContext = dbContext;
        }

        // GET method to load the payment page with order details
        public IActionResult Index(int orderId)
        {
            var order = GetOrderById(orderId);
            if (order == null)
            {
                return NotFound();  // Return a 404 if order is not found
            }

            var model = new PaymentIntentRequest
            {
                OrderId = order.OrderId,
                Amount = order.TotalCost,  // Pass the total cost to the view
            };

            ViewData["PublishableKey"] = _stripeSettings.PublishableKey;
            return View(model);
        }

        // Combined method to create PaymentIntent and update payment status
        [HttpPost]
        public async Task<IActionResult> ProcessPayment([FromBody] PaymentIntentRequest request)
        {
            try
            {
                var options = new PaymentIntentCreateOptions
                {
                    Amount = (long)(request.Amount * 100),  // Convert dollars to cents
                    Currency = "usd",
                    Metadata = new Dictionary<string, string>
                    {
                        { "orderId", request.OrderId.ToString() }
                    }
                };

                var service = new PaymentIntentService();
                var paymentIntent = await service.CreateAsync(options);

                // Update payment status in the same request
                var order = _dbContext.Orders.FirstOrDefault(x => x.OrderId == request.OrderId);
                if (order != null)
                {
                    order.paymentStatus = true;
                    order.orderActive = true;
                    _dbContext.SaveChanges();
                }

                return Ok(new
                {
                    clientSecret = paymentIntent.ClientSecret
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }

        // Fetch order details by orderId
        private Order GetOrderById(int orderId)
        {
            return _dbContext.Orders.FirstOrDefault(o => o.OrderId == orderId);  // Query the database to find the order by orderId
        }

        // Method to handle the payment success page
        public IActionResult PaymentSuccess(int orderId)
        {
            var order = GetOrderById(orderId);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
    }
}

