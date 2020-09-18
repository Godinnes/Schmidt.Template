using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Query.Application.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Schmidt.Template.Query.Application.Queries.Persons
{
    public class GetPersonsQueryHandler : ICommandHandler<GetPersonsQuery, IEnumerable<PersonQueryViewModel>>
    {
        public async Task<IEnumerable<PersonQueryViewModel>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
        {
            var persons = Enumerable.Empty<PersonQueryViewModel>();
            return persons;
        }
    }
}
