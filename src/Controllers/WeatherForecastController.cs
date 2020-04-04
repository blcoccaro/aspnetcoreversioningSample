using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspnetcoreversioningSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class WeatherForecastController : ControllerBase
    {        

        private readonly ILogger<WeatherForecastController> logger;
        private readonly Services.Interfaces.IWeatherForecastService service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, Services.Interfaces.IWeatherForecastService service)
        {
            this.logger = logger;
            this.service = service;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        public IEnumerable<WeatherForecast> Get()
        {
            return service.Get();
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        public IEnumerable<WeatherForecast> GetNew()
        {
            return service.GetNew();
        }
    }
}
