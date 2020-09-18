using Microsoft.AspNetCore.Mvc;
using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Query.Application.Queries.Races;
using System.Threading.Tasks;

namespace Schmidt.Template.Definition.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RacesController : ControllerBase
    {
        private readonly IMyMediator _mediator;
        public RacesController(IMyMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("Search")]
        public async Task<IActionResult> GetAllAsync([FromQuery]GetRacesQuery query)
        {
            var races = await _mediator.SendAsync(query);
            return Ok(races);
        }
    }
}
