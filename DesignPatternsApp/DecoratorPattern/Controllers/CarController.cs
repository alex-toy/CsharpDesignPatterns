using DecoratorPattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarMessageDecorator carMessageDecorator;

        public CarController(ILogger<CarController> logger, ICarMessageDecorator carMessageDecorator)
        {
            _logger = logger;
            this.carMessageDecorator = carMessageDecorator;
        }

        [HttpGet(Name = "Car")]
        public void Get()
        {
            carMessageDecorator.Decorate("Happy Birthday");
            carMessageDecorator.PrintOptions();
        }
    }
}