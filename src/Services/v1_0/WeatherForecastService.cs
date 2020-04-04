using System;
using System.Collections.Generic;
using System.Linq;
using aspnetcoreversioningSample.v1_0;

namespace Services.v1_0
{
    public class WeatherForecastService : Interfaces.IWeatherForecastService
    {
        public virtual IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
            })
            .ToArray();
        }
    }
}