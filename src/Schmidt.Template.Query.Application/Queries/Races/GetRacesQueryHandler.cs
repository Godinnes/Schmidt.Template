using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Common.Enumerators;
using Schmidt.Template.Query.Application.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schmidt.Template.Query.Application.Queries.Races
{
    public class GetRacesQueryHandler : CommandHandlerAsync<GetRacesQuery, IEnumerable<RaceQueryViewModel>>
    {
        public override async Task<IEnumerable<RaceQueryViewModel>> HandleAsync(GetRacesQuery request)
        {
            var races = RaceType.GetNames(typeof(RaceType))
                .Select(r => new RaceQueryViewModel() { Name = r })
                .Where(r => !request.Race.HasValue || request.Race.ToString() == r.Name);
            return races;
        }
    }
}
