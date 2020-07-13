using AirportLocator.DistanceCalculator.Impl;
using AirportLocator.DistanceCalculator.Model;
using System;
using Xunit;

namespace AirportLocator.DistanceCalculator.UnitTest
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculateDistance_AMS_to_IST_locations_equals_1373()
        {
            //arrange
            Location origin = new Location()
            {
                Latitude = 52.309069,
                Longitude = 4.763385
            };

            Location destination = new Location()
            {
                Latitude = 40.976667,
                Longitude = 28.815278
            };

            double expectedValue = 1373;

            //act
            Calculator calculator = new Calculator();
            var actualValue = calculator.CalculateDistance(origin, destination);

            //assert
            Assert.Equal(expectedValue, Math.Round(actualValue));
        }

        [Fact]
        public void CalculateDistance_LHR_to_CDG_locations_equals_216()
        {
            //arrange
            Location origin = new Location()
            {
                Latitude = 51.469603,
                Longitude = -0.453566
            };

            Location destination = new Location()
            {
                Latitude = 49.003196,
                Longitude = 2.567023
            };

            double expectedValue = 216;

            //act
            Calculator calculator = new Calculator();
            var actualValue = calculator.CalculateDistance(origin, destination);

            //assert
            Assert.Equal(expectedValue, Math.Round(actualValue));
        }
    }
}
