using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Data.Abstraction;
using System.Threading.Tasks;

namespace Schmidt.Template.Application.Commands.Persons
{
    public class RemovePersonCommandHandler : CommandHandlerAsync<RemovePersonCommand>
    {
        private readonly IPersonRepository _personRepository;
        public RemovePersonCommandHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public async override Task HandleAsync(RemovePersonCommand request)
        {
            var person = await _personRepository.FindAsync(request.ID);
            _personRepository.Remove(person);
            await _personRepository.SaveChangesAsync();
        }
    }
}
