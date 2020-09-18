using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Schmidt.Template.Application.Commands.Persons
{
    public class CreatePersonCommandHandler : ICommandHandler<CreatePersonCommand, Guid>
    {
        public async Task<Guid> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var newPerson = Person.Create(request.Name, request.Race);
            return newPerson.ID;
        }
    }
}
