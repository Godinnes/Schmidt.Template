using Microsoft.EntityFrameworkCore;
using Schmidt.Template.Domain.Entities;

namespace Schmidt.Template.Data.Abstraction
{
    public class TemplateContext : DbContext
    {
        public TemplateContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(build =>
            {
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
