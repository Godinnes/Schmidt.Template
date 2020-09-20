using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Schmidt.Template.Application.Commands.Persons;
using Schmidt.Template.Common.Extensions;
using Schmidt.Template.Data.Abstraction;
using Schmidt.Template.Data.Repository;
using Schmidt.Template.Query.Application.Queries.Races;
using Schmidt.Template.Query.Data.Abstraction;
using Schmidt.Template.Query.Data.Contexts;

namespace Schmidt.Template.Bootstrap
{
    public static class TemplateConfiguration
    {
        public static void ConfigureApi(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddMyMediator(typeof(GetRacesQueryHandler),
                                  typeof(CreatePersonCommandHandler));

            serviceCollection.AddTransient<IPersonRepository, PersonRepository>();
            serviceCollection.AddTransient<ITemplateQuery, QueryContext>();

            var serviceColletion = new ServiceCollection()
                .AddEntityFrameworkSqlite()
                .BuildServiceProvider();
            serviceCollection.AddDbContext<TemplateContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString());
                options.UseInternalServiceProvider(serviceColletion);
            });
            serviceCollection.AddDbContext<TemplateQueryContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString());
                options.UseInternalServiceProvider(serviceColletion);
            });
        }
    }
}