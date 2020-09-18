using Microsoft.Extensions.DependencyInjection;
using Schmidt.Template.Common.Extensions;
using Schmidt.Template.Definition.Api.Controllers;
using Schmidt.Template.Query.Application.Queries.RacesQueries;

namespace Schmidt.Template.Bootstrap.Extensions
{
    public static class ConfigurationExtentions
    {
        public static void AddApiConfigurations(this IServiceCollection services)
        {
            services.AddSingleton(typeof(Controller));

            services.AddMyMediator(typeof(GetRacesQueryHandler));
        }
    }
}
