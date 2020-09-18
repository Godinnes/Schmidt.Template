using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Schmidt.Template.Common.Abstraction;
using Schmidt.Template.Common.Implementations;
using System;

namespace Schmidt.Template.Common.Extensions
{
    public static class MediatorExtensions
    {
        public static IServiceCollection AddMyMediator(this IServiceCollection serviceCollection, params Type[] types)
        {
            serviceCollection.AddMediatR(types);
            serviceCollection.AddTransient<IMyMediator, MyMediator>();

            return serviceCollection;
        }
    }
}
