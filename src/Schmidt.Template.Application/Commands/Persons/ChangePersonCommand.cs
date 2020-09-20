using Schmidt.Template.Common.Abstraction;
using System;

namespace Schmidt.Template.Application.Commands.Persons
{
    public class ChangePersonCommand : ICommand
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
