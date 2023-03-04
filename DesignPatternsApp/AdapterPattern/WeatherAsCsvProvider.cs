using Csv;

namespace AdapterPattern
{
    public class WeatherAsCsvProvider : IWeatherAsStringProvider
    {
        private readonly IWeatherForecastProvider _weatherForecastProvider;

        public WeatherAsCsvProvider(IWeatherForecastProvider weatherForecastProvider)
        {
            _weatherForecastProvider = weatherForecastProvider;
        }

        public string Get()
        {
            string[]? headers = new[] { "date", "temp", "summary" };
            IEnumerable<string[]>? csv = _weatherForecastProvider.Get().Select(wf => new string[] { wf.Date.ToString(), wf.TemperatureF.ToString(), wf.Summary });
            return CsvWriter.WriteToText(headers, csv);
        }
    }
}
