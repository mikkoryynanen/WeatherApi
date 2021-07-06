using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace weatherapi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        private readonly IOptions<AppOptions> _options;

        public WeatherForecastController(IWeatherService weatherService, IOptions<AppOptions> options)
        {
            _weatherService = weatherService;
            _options = options;
        }

        [HttpGet]
        public async Task<string> Get(string cityName)
        {
            return await _weatherService.GetWeather(cityName, _options.Value.WeatherApiKey);  
        }
    }
}
