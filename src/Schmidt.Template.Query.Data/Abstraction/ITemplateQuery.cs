using Schmidt.Template.Query.Model.Model;
using System.Linq;

namespace Schmidt.Template.Query.Data.Abstraction
{
    public interface ITemplateQuery
    {
        IQueryable<Person> Persons { get; }
    }
}
