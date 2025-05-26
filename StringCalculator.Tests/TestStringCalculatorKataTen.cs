using System;
using System.Collections.Generic;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataTen
    {
        [Fact]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            // Arrange
            var numbers = "";
            var expected = "0";
            var stringCalculator = new StringCalculatorKataTen();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
