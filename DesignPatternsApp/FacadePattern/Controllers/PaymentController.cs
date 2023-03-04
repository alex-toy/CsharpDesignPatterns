using FacadePattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace FacadePattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet(Name = "Pay")]
        public void Pay(string item, double amount)
        {
            _paymentService.Pay(amount, item);
        }
    }
}