using System.Collections.Generic;
using aspnetcoreversioningSample.v2_0;

namespace Services.v2_0.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
        IEnumerable<Summary> GetSummaries();
    }
}