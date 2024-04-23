using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace LearnMediator
{
    public static class DependencyInversions
    {
        public static IServiceCollection AddLearnMediator(this IServiceCollection services)
        {
            services.AddMediatR(typeof(DependencyInversions));
            return services;
        }
    }
}
