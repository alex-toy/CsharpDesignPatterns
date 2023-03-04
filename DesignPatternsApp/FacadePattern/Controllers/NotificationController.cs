using FacadePattern.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FacadePattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationController)
        {
            this._notificationService = notificationController;
        }

        // POST api/<NotificationController>
        [HttpPost]
        public void Notify([FromBody] string notification)
        {
            _notificationService.Send(notification);
        }
    }
}
