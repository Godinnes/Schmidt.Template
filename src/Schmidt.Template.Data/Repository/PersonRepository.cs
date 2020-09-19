using Microsoft.EntityFrameworkCore;
using Schmidt.Template.Data.Abstraction;
using Schmidt.Template.Data.Contexts;
using Schmidt.Template.Domain.Entities;

namespace Schmidt.Template.Data.Repository
{
    public class PersonRepository : TemplateDbContext<Person>, IPersonRepository
    {
        public PersonRepository(TemplateContext context, DbContextOptions options)
            : base(context, options)
        {
        }
    }
}
