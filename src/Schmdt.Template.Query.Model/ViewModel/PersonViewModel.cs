using Schmidt.Template.Common.Enumerators;
using System;

namespace Schmidt.Template.Query.Model.ViewModel
{
    public class PersonViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public RaceType Race { get; set; }
    }
}
