using System;
using System.Collections.Generic;
using StringCalculator;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataSeven
    {
        [Fact]
        public void Add_GivenEmptyString_ShouldReturn0()
        {
            // Arrange
            var numbers = "";
            var expected = "0";
            var stringCalculator = new StringCalculatorKataSeven();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);

        }
    }
}
