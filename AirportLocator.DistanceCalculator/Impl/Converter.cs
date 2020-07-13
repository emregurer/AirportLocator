namespace AirportLocator.DistanceCalculator.Impl
{
    public static class Converter
    {
        private const double MileToKmCoefficient = 1.609344;
        private const double KmToMileCoefficient = 0.6214;

        public static double ConvertToMilesFromKm(double km)
        {
            return KmToMileCoefficient * km;
        }

        public static double ConvertToKmFromMiles(double miles)
        {
            return MileToKmCoefficient * miles;
        }

        public static double DegreeToRadian(double degree)
        {
            return System.Math.PI * degree / 180;
        }
    }
}
