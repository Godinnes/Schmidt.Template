using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Common.Enumerators;
using Schmidt.Template.Query.Model.ViewModel;
using System.Collections.Generic;

namespace Schmidt.Template.Query.Application.Queries.Persons
{
    public class GetPersonsQuery : ICommand<IEnumerable<PersonViewModel>>
    {
        public string Name { get; set; }
        public RaceType? Race { get; set; }
    }
}
