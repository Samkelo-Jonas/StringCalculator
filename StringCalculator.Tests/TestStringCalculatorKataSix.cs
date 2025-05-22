using System;
using System.Collections.Generic;
using StringCalculator;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataSix
    {
        [Fact]
        public void Add_GivenEmptyString_ShouldReturn0()
        {
            // Arrange
            var numbers = "";
            var expected = "0";
            var stringCalculator = new StringCalculatorKataSix();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
