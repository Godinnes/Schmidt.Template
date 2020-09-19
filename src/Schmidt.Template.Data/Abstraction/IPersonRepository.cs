using Schmidt.Template.Domain.Entities;
using System.Threading.Tasks;

namespace Schmidt.Template.Data.Abstraction
{
    public interface IPersonRepository
    {

        void Add(Person person);
        void Remove(Person person);
        Task SaveChangesAsync();
    }
}
