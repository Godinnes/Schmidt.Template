using Microsoft.EntityFrameworkCore;
using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Query.Application.Specifications;
using Schmidt.Template.Query.Data.Abstraction;
using Schmidt.Template.Query.Model.Extentions;
using Schmidt.Template.Query.Model.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schmidt.Template.Query.Application.Queries.Persons
{
    public class GetPersonsQueryHandler : CommandHandlerAsync<GetPersonsQuery, IEnumerable<PersonViewModel>>
    {
        private readonly ITemplateQuery _query;
        public GetPersonsQueryHandler(ITemplateQuery query)
        {
            _query = query;
        }
        public override async Task<IEnumerable<PersonViewModel>> HandleAsync(GetPersonsQuery request)
        {
            var persons = await _query.Persons
                .Where(PersonSpecification.PersonName(request.Name))
                .Where(PersonSpecification.PersonRace(request.Race))
                .Select(p => p.ToViewModel())
                .ToListAsync();
            return persons;
        }
    }
}
