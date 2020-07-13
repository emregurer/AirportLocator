using AirportLocator.DistanceCalculator.Model;

namespace AirportLocator.DistanceCalculator
{
    public interface ICalculator
    {
        double CalculateDistance(Location origin, Location destination);
    }
}
