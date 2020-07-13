using AirportLocator.AirportProvider.HttpAirportProviderService;
using System.Threading.Tasks;

namespace AirportLocator.AirportProvider
{
    public interface IAirportProviderService
    {
        Task<ServiceResponseDto> GetAirportInformation(string airportCode);
    }
}
