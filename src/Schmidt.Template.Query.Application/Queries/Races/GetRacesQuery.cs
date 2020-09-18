using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Common.Enumerators;
using Schmidt.Template.Query.Application.ViewModel;
using System.Collections.Generic;

namespace Schmidt.Template.Query.Application.Queries.Races
{
    public class GetRacesQuery : ICommand<IEnumerable<RaceQueryViewModel>>
    {
        public RaceType? Race { get; set; }
    }
}
