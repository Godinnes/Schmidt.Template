using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Schmidt.Template.Data.Abstraction
{
    public abstract class RepositoryBase<TEntity>
        where TEntity : class
    {
        protected readonly DbContext Context;
        protected DbSet<TEntity> Entity { get; set; }
        public RepositoryBase(DbContext context)
        {
            Context = context;

            Entity = context.Set<TEntity>();
        }
        public async virtual Task<TEntity> FindAsync(Guid id)
        {
            return await Entity.FindAsync(id);
        }
        public virtual void Add(TEntity entity)
        {
            Entity.Add(entity);
        }
        public virtual void Remove(TEntity entity)
        {
            Entity.Remove(entity);
        }
        public async virtual Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
