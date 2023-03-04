using BridgePattern.BridgeProcessors;
using BridgePattern.Processors;
using Microsoft.AspNetCore.Mvc;

namespace BridgePattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        //private readonly NotificationProcessor _notificationProcessor;
        private readonly INotificationProcessor _notificationProcessor;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastController(ILogger<WeatherForecastController> logger, INotificationProcessor notificationProcessor)
        {
            _logger = logger;
            _notificationProcessor = notificationProcessor;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _notificationProcessor.ProcessNotification("hi there!");

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}