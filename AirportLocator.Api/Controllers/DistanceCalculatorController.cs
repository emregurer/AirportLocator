using System.Threading.Tasks;
using AirportLocator.ApplicationService.DistanceCalculatorManagement;
using AirportLocator.ApplicationService.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace AirportLocator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistanceCalculatorController : ControllerBase
    {

        private readonly IRequestHandler<DistanceCalculatorRequestDto, DistanceCalculatorResponseDto>  requestHandler;

        public DistanceCalculatorController(IRequestHandler<DistanceCalculatorRequestDto, DistanceCalculatorResponseDto> requestHandler)
        {
            this.requestHandler = requestHandler;
        }

        [HttpPost]
        public async Task<DistanceCalculatorResponseDto> Post([FromBody]DistanceCalculatorRequestDto requestDto)
        {
            return await requestHandler.Handle(requestDto, new System.Threading.CancellationToken());
        }
    }
}