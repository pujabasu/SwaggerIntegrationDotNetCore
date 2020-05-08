using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SwaggerIntegration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
        }

        /// <summary>
        /// Returns a range of integers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<int> Get()
        {
            return Enumerable.Range(1, 5);
        }
    }
}
