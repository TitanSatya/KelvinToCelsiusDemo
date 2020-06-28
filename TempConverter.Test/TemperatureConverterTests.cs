using System;
using TempConverter.ConsoleApp;
using Xunit;

namespace TempConverter.Test
{
    public class TemperatureConverterTests
    {
        TemperatureConverter temperatureConverter;
        public TemperatureConverterTests()
        {
            //Main Arrange
            temperatureConverter = new TemperatureConverter();
        }
        [Fact]
        public void Should_Return_Kelvin_Value()
        {

            //Act
            var result = temperatureConverter.ConvertCelsiusToKelvin("10");
            //Assert
            Assert.Equal(283.15, result);
        }
        [Theory]
        [InlineData("10", 283.15)]
        [InlineData("11", 284.15)]
        [InlineData("12", 285.15)]
        [InlineData("15", 288.15)]
        [InlineData("16", 289.15)]
        public void Should_Return_Kelvin_Value_Theory(string inputValue, double outputValue)
        {
            //Act
            var result = temperatureConverter.ConvertCelsiusToKelvin(inputValue);

            //Assert
            Assert.Equal(outputValue, result);
        }
        [Fact]
        public void Should_Return_Celsius()
        {
            //Arrange
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            //Act
            var result = temperatureConverter.ConvertKelvinToCelsius("10");

            //Assert
            Assert.Equal(-263.15, result);

        }
        [Theory]
        [InlineData("10", -263.15)]
        [InlineData("20", -253.15)]
        [InlineData("30", -243.15)]
        [InlineData("40", -233.15)]
        [InlineData("50", -223.15)]
        public void Should_Return_Celcius_MultipleValues(string inputValue, double outputValue)
        {

            //Act
            var result = temperatureConverter.ConvertKelvinToCelsius(inputValue);

            //Assert
            Assert.Equal(outputValue, result);
        }




        [Fact]
        public void Should_Throw_ArgumentException_ForKelvinToCelsius()
        {


            //Act And Assert
            Assert.Throws<ArgumentException>(() => temperatureConverter.ConvertKelvinToCelsius("satya"));
        }
        [Fact]
        public void Should_Throw_ArgumentException_ForCelsiusToKelvin()
        {
            //Act And Assert
            Assert.Throws<ArgumentException>(() => temperatureConverter.ConvertCelsiusToKelvin(""));
        }

    }
}
