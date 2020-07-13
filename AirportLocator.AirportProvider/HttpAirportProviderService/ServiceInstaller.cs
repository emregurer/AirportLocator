using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace AirportLocator.AirportProvider.HttpAirportProviderService
{
    public static class ServiceInstaller
    {
        public static IServiceCollection CustomAddHttpAirportProviderService(this IServiceCollection services, Action<Settings> settingsAction)
        {
            var serviceSettings = new Settings();
            settingsAction(serviceSettings);

            services.Configure(settingsAction);

            services.AddTransient(provider => provider.GetRequiredService<IOptions<Settings>>().Value);

            services.AddHttpClient<IAirportProviderService, Service>((provider, client) =>
            {
                var settings = provider.GetRequiredService<Settings>();
                client.BaseAddress = new Uri(settings.BaseAddress);
                client.Timeout = TimeSpan.FromSeconds(settings.RequestTimeoutInSecs);
            });

            return services;
        }
    }
}
