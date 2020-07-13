using AirportLocator.ApplicationService.DistanceCalculatorManagement;
using Microsoft.Extensions.DependencyInjection;

namespace AirportLocator.ApplicationService.Infrastructure
{
    public static class RequestHandlerExtensions
    {
        public static IServiceCollection CustomAddRequestHandler(this IServiceCollection services)
        {
            services.Add(ServiceDescriptor.Transient(typeof(IRequestHandler<DistanceCalculatorRequestDto, DistanceCalculatorResponseDto>), typeof(DistanceCalculatorHandler)));

            return services;
        }
    }
}
