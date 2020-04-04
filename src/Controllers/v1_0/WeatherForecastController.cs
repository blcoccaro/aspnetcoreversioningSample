using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcoreversioningSample.v1_0;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspnetcoreversioningSample.Controllers.v1_0
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0")]
    public class WeatherForecastController : ControllerBase
    {        

        private readonly ILogger<WeatherForecastController> logger;
        private readonly Services.v1_0.Interfaces.IWeatherForecastService service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, Services.v1_0.Interfaces.IWeatherForecastService service)
        {
            this.logger = logger;
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return service.Get();
        }
    }
}
