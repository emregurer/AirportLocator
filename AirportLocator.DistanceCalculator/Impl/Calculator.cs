using AirportLocator.DistanceCalculator.Model;
using System;

namespace AirportLocator.DistanceCalculator.Impl
{
    public class Calculator : ICalculator
    {
        private const double RadiusOfEarth = 6371;

        public double CalculateDistance(Location origin, Location destination)
        {
            double dLongitude = Converter.DegreeToRadian(origin.Longitude - destination.Longitude);
            double dLatitude = Converter.DegreeToRadian(origin.Latitude - destination.Latitude);

            double a = (Math.Sin(dLatitude / 2) * Math.Sin(dLatitude / 2)) 
                + Math.Cos(Converter.DegreeToRadian(origin.Latitude)) * Math.Cos(Converter.DegreeToRadian(destination.Latitude)) * (Math.Sin(dLongitude / 2) * Math.Sin(dLongitude / 2));
            double angle = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            
            double distanceInKm = angle * RadiusOfEarth;

            double distanceInMiles = Converter.ConvertToMilesFromKm(distanceInKm);
            return distanceInMiles;
        }
    }
}
