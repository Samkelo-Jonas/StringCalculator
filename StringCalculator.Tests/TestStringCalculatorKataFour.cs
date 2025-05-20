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

        [Fact]
        public void Add_GivenSingleNumber_ReturnsSameNumber()
        {
            // Arrange
            var numbers = "2";
            var expected = "2";
            var stringCalculator = new StringCalculatorKataFour();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenTwoNumbers_ReturnsSum()
        {
            // Arrange
            var numbers = "1, 2";
            var expected = "3";
            var stringCalculator = new StringCalculatorKataFour();
            
            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenMultipleNumbers_ReturnsSum()
        {
            // Arrange
            var numbers = "1, 2, 3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataFour();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNewLineDelimiter_ReturnsSum()
        {
            // Arrange
            var numbers = "1\n2,3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataFour();
            
            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
