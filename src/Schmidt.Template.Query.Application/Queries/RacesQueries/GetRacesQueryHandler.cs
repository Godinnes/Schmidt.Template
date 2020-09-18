using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Common.Enumerators;
using Schmidt.Template.Query.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Schmidt.Template.Query.Application.Queries.RacesQueries
{
    public class GetRacesQueryHandler : ICommandHandler<GetRacesQuery, IEnumerable<RaceQueryViewModel>>
    {
        public async Task<IEnumerable<RaceQueryViewModel>> Handle(GetRacesQuery request, CancellationToken cancellationToken)
        {
            var races = Enum.GetNames(typeof(RaceType))
                .Select(r => new RaceQueryViewModel() { Name = r })
                .Where(r => string.IsNullOrEmpty(request.Name) || request.Name == r.Name);
            return races;
        }
    }
}
