using Microsoft.EntityFrameworkCore;
using Schmidt.Template.Data.Abstraction;

namespace Schmidt.Template.Data.Contexts
{
    public class TemplateDbContext<TEntity> : RepositoryBase<TEntity>
        where TEntity : class
    {
        public TemplateDbContext(TemplateContext context, DbContextOptions options)
            : base(context, options)
        {
        }
    }
}
