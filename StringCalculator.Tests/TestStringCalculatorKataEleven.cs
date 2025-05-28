using System;
using System.Collections.Generic;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataEleven
    {
        [Fact]
        public void Add_GivenAnEmptyString_ShouldReturn0()
        {
            // Arrange
            var numbers = "";
            var expected = "0";
            var stringCalculator = new StringCalculatorKataEleven();

            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
