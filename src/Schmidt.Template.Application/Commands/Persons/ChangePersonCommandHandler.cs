using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Data.Abstraction;
using System.Threading.Tasks;

namespace Schmidt.Template.Application.Commands.Persons
{
    public class ChangePersonCommandHandler : CommandHandlerAsync<ChangePersonCommand>
    {
        private readonly IPersonRepository _personRepository;
        public ChangePersonCommandHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public override async Task HandleAsync(ChangePersonCommand request)
        {
            var person = await _personRepository.FindAsync(request.ID);
            person.UpdateName(request.Name);
            await _personRepository.SaveChangesAsync();
        }
    }
}
