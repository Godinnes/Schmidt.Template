using Schmidt.Template.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Schmidt.Template.Data.Abstraction
{
    public interface IPersonRepository
    {
        Task<Person> FindAsync(Guid id);
        void Add(Person person);
        void Remove(Person person);
        Task SaveChangesAsync();
    }
}
