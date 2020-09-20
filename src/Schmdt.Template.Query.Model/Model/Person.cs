using Schmidt.Template.Common.Enumerators;
using Schmidt.Template.Query.Model.ViewModel;
using System;

namespace Schmidt.Template.Query.Model.Model
{
    public class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public RaceType Race { get; set; }

        public static implicit operator PersonViewModel(Person person)
        {
            return new PersonViewModel
            {
                ID = person.ID,
                Name = person.Name,
                Race = person.Race
            };
        }
    }
}
