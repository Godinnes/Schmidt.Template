using Microsoft.EntityFrameworkCore;
using Schmidt.Template.Query.Data.Abstraction;
using Schmidt.Template.Query.Model.Model;
using System.Linq;

namespace Schmidt.Template.Query.Data.Contexts
{
    public class QueryContext : ITemplateQuery
    {
        private readonly TemplateQueryContext _context;
        public QueryContext(TemplateQueryContext context)
        {
            _context = context;
        }
        public IQueryable<Person> Persons
        {
            get
            {
                return _context.Set<Person>()
                    .AsNoTracking();
            }
        }
    }
}
