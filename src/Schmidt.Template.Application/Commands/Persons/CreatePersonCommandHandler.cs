﻿using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Data.Abstraction;
using Schmidt.Template.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Schmidt.Template.Application.Commands.Persons
{
    public class CreatePersonCommandHandler : CommandHandlerAsync<CreatePersonCommand, Guid>
    {
        private readonly IPersonRepository _personRepository;
        public CreatePersonCommandHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public override async Task<Guid> HandleAsync(CreatePersonCommand request)
        {
            var newPerson = Person.Create(request.Name, request.Race);
            _personRepository.Add(newPerson);
            await _personRepository.SaveChangesAsync();
            return newPerson.ID;
        }
    }
}
