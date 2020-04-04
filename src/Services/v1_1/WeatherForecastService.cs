using System;
using System.Collections.Generic;
using System.Linq;
using aspnetcoreversioningSample.v1_1;

namespace Services.v1_1
{
    public class WeatherForecastService : v1_1.Interfaces.IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "[tag_freezing]", "[tag_bracing]", "[tag_chilly]", "[tag_cool]", "[tag_mild]", "[tag_warm]", "[tag_balmy]", "[tag_Hot]", "[tag_sweltering]", "[tag_scorching]"
        };

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}