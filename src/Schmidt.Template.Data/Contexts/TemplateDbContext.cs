using Schmidt.Template.Data.Abstraction;

namespace Schmidt.Template.Data.Contexts
{
    public class TemplateDbContext<TEntity> : RepositoryBase<TEntity>
        where TEntity : class
    {
        public TemplateDbContext(TemplateContext context)
            : base(context)
        {
            context.Database.EnsureCreated();
        }
    }
}
