using System;
using System.Collections.Generic;
using System.Linq;
using aspnetcoreversioningSample.v2_0;

namespace Services.v2_0
{
    public class WeatherForecastService : v2_0.Interfaces.IWeatherForecastService
    {
        public IEnumerable<Summary> Summaries;
        public WeatherForecastService()
        {
            Summaries = new List<Summary>() {
                new Summary() { Id = 1, Name = "Freezing" },
                new Summary() { Id = 2, Name = "Bracing" },
                new Summary() { Id = 3, Name = "Chilly" },
                new Summary() { Id = 4, Name = "Cool" },
                new Summary() { Id = 5, Name = "Mild" },
                new Summary() { Id = 6, Name = "Warm" },
                new Summary() { Id = 7, Name = "Balmy" },
                new Summary() { Id = 8, Name = "Hot" },
                new Summary() { Id = 9, Name = "Sweltering" },
            };
        }
        public IEnumerable<Summary> GetSummaries() {
            return Summaries;
        }

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries.ElementAt(rng.Next(Summaries.Count())).Id
            })
            .ToArray();
        }
    }
}