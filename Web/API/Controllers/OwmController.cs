using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Dm.Owm.Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwmController : ControllerBase
    {
        private readonly ILogger<OwmController> _logger;
        private readonly IConfiguration _config;

        public OwmController(ILogger<OwmController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string apiKey = _config.GetValue<string>("OpenWeatherMap:APIKey");

            return Ok(apiKey);
        }
    }
}
