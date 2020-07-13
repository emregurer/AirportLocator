using AirportLocator.ApplicationService.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace AirportLocator.ApplicationService.DistanceCalculatorManagement
{
    public class DistanceCalculatorRequestDto : IRequest<DistanceCalculatorResponseDto>
    {
        [Required]
        [MaxLength(3, ErrorMessage = "Invalid airport code")]
        [MinLength(3, ErrorMessage = "Invalid airport code")]
        public string OriginAirportCode { get; set; }

        [Required]
        [MaxLength(3, ErrorMessage = "Invalid airport code")]
        [MinLength(3, ErrorMessage = "Invalid airport code")]
        public string DestinationAirportCode { get; set; }

    }
}
