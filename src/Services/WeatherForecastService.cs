using System;
using System.Collections.Generic;
using System.Linq;
using aspnetcoreversioningSample;

namespace Services
{
    public class WeatherForecastService : Interfaces.IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] SummariesV2 = new[]
        {
            "[tag_hot]", "[tag_freezing]"
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

        public IEnumerable<WeatherForecast> GetNew()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = SummariesV2[rng.Next(SummariesV2.Length)]
            })
            .ToArray();
        }
    }
}