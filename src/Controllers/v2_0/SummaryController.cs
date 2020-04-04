using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcoreversioningSample.v2_0;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspnetcoreversioningSample.Controllers.v2_0
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("2.0")]
    public class SummaryController : ControllerBase
    {        

        private readonly ILogger<SummaryController> logger;
        private readonly Services.v2_0.Interfaces.IWeatherForecastService service;

        public SummaryController(ILogger<SummaryController> logger, Services.v2_0.Interfaces.IWeatherForecastService service)
        {
            this.logger = logger;
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Summary> Get()
        {
            return service.GetSummaries();
        }
    }
}
