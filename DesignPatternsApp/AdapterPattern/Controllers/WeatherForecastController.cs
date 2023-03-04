using Microsoft.AspNetCore.Mvc;

namespace AdapterPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherAsStringProvider _weatherAsStringProvider;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherAsStringProvider weatherAsStringProvider)
        {
            _logger = logger;
            _weatherAsStringProvider = weatherAsStringProvider;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return _weatherAsStringProvider.Get();
        }
    }
}