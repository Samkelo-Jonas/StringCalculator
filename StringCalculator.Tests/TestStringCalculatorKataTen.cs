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

        [Fact]
        public void Add_GivenOneNumber_ShouldReturnThatNumber()
        {
            // Arrange
            var numbers = "1";
            var expected = "1";
            var stringCalculator = new StringCalculatorKataTen();
            
            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenTwoNumbers_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "1, 2";
            var expected = "3";
            var stringCalculator = new StringCalculatorKataTen();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
