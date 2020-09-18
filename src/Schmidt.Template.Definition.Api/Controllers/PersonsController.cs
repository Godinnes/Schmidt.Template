using Microsoft.AspNetCore.Mvc;
using Schmidt.Template.Application.Commands.Persons;
using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Query.Application.Queries.Persons;
using System.Threading.Tasks;

namespace Schmidt.Template.Definition.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IMyMediator _mediator;
        public PersonsController(IMyMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("Search")]
        public async Task<IActionResult> GetAllAsync([FromQuery] GetPersonsQuery query)
        {
            var persons = await _mediator.SendAsync(query);
            return Ok(persons);
        }
        [HttpPost()]
        public async Task<IActionResult> CreatePersonAsync([FromBody]CreatePersonCommand command)
        {
            var personID = await _mediator.SendAsync(command);
            return Ok(personID);
        }
    }
}
