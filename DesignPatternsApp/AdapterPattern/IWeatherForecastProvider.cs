
namespace AdapterPattern
{
    public interface IWeatherForecastProvider
    {
        IEnumerable<WeatherForecast> Get();
    }
}