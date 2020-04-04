using System.Collections.Generic;
using aspnetcoreversioningSample.v1_1;

namespace Services.v1_1.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}