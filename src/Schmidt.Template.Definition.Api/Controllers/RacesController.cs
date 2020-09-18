using Microsoft.AspNetCore.Mvc;
using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Query.Application.Queries.RacesQueries;
using System.Threading.Tasks;

namespace Schmidt.Template.Definition.Api.Controllers
{
    public class RacesController : Controller
    {
        private readonly IMyMediator _mediator;
        public RacesController(IMyMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("Search")]
        public async Task<IActionResult> GetAll(GetRacesQuery query)
        {
            var races = await _mediator.SendAsync(query);
            return Ok(races);
        }
    }
}
