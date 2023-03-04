using FacadePattern.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FacadePattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;
        private readonly IPaymentService _paymentService;
        private readonly INotificationService _notificationService;

        public PurchaseController(IInventoryService inventoryService, IPaymentService paymentService, INotificationService notificationService)
        {
            this._inventoryService = inventoryService;
            this._paymentService = paymentService;
            this._notificationService = notificationService;
        }

        [HttpGet(Name = "Post")]
        public IActionResult Purchase([FromBody] string item, double amount)
        {
            string[]? inventory = _inventoryService.Get();
                
            bool hasItem = inventory.Any(i => i == item);
            if (!hasItem) return BadRequest();

            _paymentService.Pay(amount, item);

            _notificationService.Send($"{item} purchased with amount {amount}");

            return Ok();
        }
    }
}
