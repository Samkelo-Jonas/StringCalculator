using System;
using System.Collections.Generic;
using StringCalculator;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataFour
    {
        [Fact]
        public void Add_GivenEmptyString_ReturnsZero()
        {
            // Arrange
            var numbers = "";
            var expected = "0";
            var stringCalculator = new StringCalculatorKataFour();
            
            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }

    }
}
