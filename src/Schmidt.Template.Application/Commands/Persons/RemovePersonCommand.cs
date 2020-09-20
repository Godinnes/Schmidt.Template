using Schmidt.Template.Common.Abstraction;
using System;

namespace Schmidt.Template.Application.Commands.Persons
{
    public class RemovePersonCommand : ICommand
    {
        public Guid ID { get; set; }
    }
}
