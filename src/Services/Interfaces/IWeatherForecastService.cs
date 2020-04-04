using System.Collections.Generic;
using aspnetcoreversioningSample;

namespace Services.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
        IEnumerable<WeatherForecast> GetNew();
    }
}