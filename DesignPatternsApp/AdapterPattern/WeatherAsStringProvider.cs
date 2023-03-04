namespace AdapterPattern
{
    public class WeatherAsStringProvider : IWeatherAsStringProvider
    {
        private readonly IWeatherForecastProvider _weatherForecastProvider;

        public WeatherAsStringProvider(IWeatherForecastProvider weatherForecastProvider)
        {
            _weatherForecastProvider = weatherForecastProvider;
        }

        public string Get()
        {
            IEnumerable<string>? forecasts = _weatherForecastProvider.Get().Select(wf => $"{wf.Date} - {wf.TemperatureF} - {wf.Summary}");
            return string.Join(Environment.NewLine, forecasts);
        }
    }
}
