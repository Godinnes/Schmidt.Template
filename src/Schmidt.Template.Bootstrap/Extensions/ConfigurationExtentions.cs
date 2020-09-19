using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Schmidt.Template.Application.Commands.Persons;
using Schmidt.Template.Common.Extensions;
using Schmidt.Template.Data.Abstraction;
using Schmidt.Template.Data.Repository;
using Schmidt.Template.Query.Application.Queries.Races;

namespace Schmidt.Template.Bootstrap.Extensions
{
    public static class ConfigurationExtentions
    {
        public static void AddApiConfigurations(this IServiceCollection services)
        {
            services.AddMyMediator(typeof(GetRacesQueryHandler),
                                   typeof(CreatePersonCommandHandler));

            services.AddDbContext<TemplateContext>(options => options.UseInMemoryDatabase("TemplateDatabase"));

            services.AddTransient<IPersonRepository, PersonRepository>();
        }
    }
}
