﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Schmidt.Template.Common.Extensions;
using Schmidt.Template.Domain.Entities;
using System.Reflection;

namespace Schmidt.Template.Data.Abstraction
{
    public class TemplateContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public TemplateContext(DbContextOptions<TemplateContext> options,
                               IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString(), options => options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(build =>
            {
                build.ToTable("Persons");
                build.HasKey(k => k.ID);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
