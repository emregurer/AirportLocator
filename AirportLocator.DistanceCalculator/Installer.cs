using AirportLocator.DistanceCalculator.Impl;
using Microsoft.Extensions.DependencyInjection;

namespace AirportLocator.DistanceCalculator
{
    public static class Installer
    {
        public static IServiceCollection CustomAddCalculator(this IServiceCollection services)
        {
            services.AddTransient<ICalculator, Calculator>();

            return services;
        }
    }
}
