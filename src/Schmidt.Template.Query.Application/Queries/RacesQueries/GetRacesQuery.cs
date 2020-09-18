using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Query.Application.ViewModel;
using System.Collections.Generic;

namespace Schmidt.Template.Query.Application.Queries.RacesQueries
{
    public class GetRacesQuery : ICommand<IEnumerable<RaceQueryViewModel>>
    {
        public string Name { get; set; }
    }
}
