using System.Collections.Generic;
using aspnetcoreversioningSample.v1_0;

namespace Services.v1_0.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}