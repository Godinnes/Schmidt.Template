using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Query.Application.Queries.Weather;
using System.Threading.Tasks;

namespace Schmidt.Template.Definition.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMyMediator _mediator;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                         IMyMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var query = new GetWeatherQuery();
            var weatherForecast = await _mediator.SendAsync(query);
            return Ok(weatherForecast);
        }
    }
}
