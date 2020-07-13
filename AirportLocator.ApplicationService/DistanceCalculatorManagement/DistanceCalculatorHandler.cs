using System.Threading;
using System.Threading.Tasks;
using AirportLocator.AirportProvider;
using AirportLocator.ApplicationService.Infrastructure;
using AirportLocator.DistanceCalculator;
using AirportLocator.DistanceCalculator.Model;

namespace AirportLocator.ApplicationService.DistanceCalculatorManagement
{
    public class DistanceCalculatorHandler : IRequestHandler<DistanceCalculatorRequestDto, DistanceCalculatorResponseDto>
    {
        private readonly IAirportProviderService airportProviderService;
        private readonly ICalculator calculator;

        public DistanceCalculatorHandler(IAirportProviderService airportProviderService, ICalculator calculator)
        {
            this.airportProviderService = airportProviderService;
            this.calculator = calculator;
        }

        public async Task<DistanceCalculatorResponseDto> Handle(DistanceCalculatorRequestDto request, CancellationToken cancellationToken)
        {
            var result = new DistanceCalculatorResponseDto();

            var originAirport = await airportProviderService.GetAirportInformation(request.OriginAirportCode);
            var destinationAirport = await airportProviderService.GetAirportInformation(request.DestinationAirportCode);

            Location originLocation = new Location()
            {
                Latitude = originAirport.location.lat,
                Longitude = originAirport.location.lon
            };

            Location destinationLocation = new Location()
            {
                Latitude = destinationAirport.location.lat,
                Longitude = destinationAirport.location.lon
            };

            result.Distance = calculator.CalculateDistance(originLocation, destinationLocation);

            return await Task.FromResult(result);
        }
    }
}
