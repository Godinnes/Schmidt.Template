using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Common.Enumerators;
using Schmidt.Template.Query.Application.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Schmidt.Template.Query.Application.Queries.Races
{
    public class GetRacesQueryHandler : ICommandHandler<GetRacesQuery, IEnumerable<RaceQueryViewModel>>
    {
        public async Task<IEnumerable<RaceQueryViewModel>> Handle(GetRacesQuery request, CancellationToken cancellationToken)
        {
            var races = RaceType.GetNames(typeof(RaceType))
                .Select(r => new RaceQueryViewModel() { Name = r })
                .Where(r => !request.Race.HasValue || request.Race.ToString() == r.Name);
            return races;
        }
    }
}
