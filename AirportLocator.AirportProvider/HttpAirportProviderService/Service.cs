using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace AirportLocator.AirportProvider.HttpAirportProviderService
{
    public class Service : IAirportProviderService
    {
        private readonly HttpClient httpClient;

        public Service(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ServiceResponseDto> GetAirportInformation(string airportCode)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"airports/{airportCode}");
            var actualResponse = await httpClient.SendAsync(httpRequest);


            JsonMediaTypeFormatter formatter = new JsonMediaTypeFormatter();

            formatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("application/problem+json"));

            var actualValue = actualResponse.Content.ReadAsAsync<ServiceResponseDto>(new[] { formatter }).Result;

            return actualValue;
        }
    }
}
