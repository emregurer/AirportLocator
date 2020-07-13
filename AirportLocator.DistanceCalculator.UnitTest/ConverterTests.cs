using AirportLocator.DistanceCalculator.Impl;
using System;
using Xunit;

namespace AirportLocator.DistanceCalculator.UnitTest
{
    public class ConverterTests
    {
        [Fact]
        public void ConvertToMilesFromKm_1Km_equalsTo0_6214Miles()
        {
            //arrange
            double input = 1;
            double expectedOutput = 0.6214;

            //act
            double actualValue = Converter.ConvertToMilesFromKm(input);

            //assert
            Assert.Equal(expectedOutput, Math.Round(actualValue, 4));
        }

        [Fact]
        public void ConvertToMilesFromKm_10Km_equalsTo6_214Miles()
        {
            //arrange
            double input = 10;
            double expectedOutput = 6.214;

            //act
            double actualValue = Converter.ConvertToMilesFromKm(input);

            //assert
            Assert.Equal(expectedOutput, Math.Round(actualValue, 4));
        }

        [Fact]
        public void ConvertToKmFromMiles_1Mile_equalsTo1_6093Km()
        {
            //arrange
            double input = 1;
            double expectedOutput = 1.6093;

            //act
            double actualValue = Converter.ConvertToKmFromMiles(input);

            //assert
            Assert.Equal(expectedOutput, Math.Round(actualValue, 4));
        }

        [Fact]
        public void ConvertToKmFromMiles_10Miles_equalsTo16_0934Km()
        {
            //arrange
            double input = 10;
            double expectedOutput = 16.0934;

            //act
            double actualValue = Converter.ConvertToKmFromMiles(input);

            //assert
            Assert.Equal(expectedOutput, Math.Round(actualValue, 4));
        }

        [Fact]
        public void DegreeToRadian_1Degree_equals_0_0175()
        {
            //arrange
            double input = 1;
            double expectedOutput = 0.0175;

            //act
            double actualValue = Converter.DegreeToRadian(input);

            //assert
            Assert.Equal(expectedOutput, Math.Round(actualValue, 4));
        }

        [Fact]
        public void DegreeToRadian_360Degree_equals_6_283()
        {
            //arrange
            double input = 360;
            double expectedOutput = 6.283;

            //act
            double actualValue = Converter.DegreeToRadian(input);

            //assert
            Assert.Equal(expectedOutput, Math.Round(actualValue,3));
        }
    }
}
