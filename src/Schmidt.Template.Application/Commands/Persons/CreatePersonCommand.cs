using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Common.Enumerators;
using System;

namespace Schmidt.Template.Application.Commands.Persons
{
    public class CreatePersonCommand : ICommand<Guid>
    {
        public string Name { get; set; }
        public RaceType Race { get; set; }
    }
}
