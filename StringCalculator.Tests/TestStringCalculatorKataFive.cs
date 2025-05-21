using System;
using System.Collections.Generic;
using StringCalculator;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataFive
    {
        [Fact]
        public void Add_GivenEmptyString_ShouldReturn0()
        {
            // Arrange
            var numbers = "";
            var expected = "0";
            var stringCalculator = new StringCalculatorKataFive();

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
            var stringCalculator = new StringCalculatorKataFive();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenTwoNumbers_ShouldReturnSum()
        {
            // Arrange
            var numbers = "1, 2";
            var expected = "3";
            var stringCalculator = new StringCalculatorKataFive();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenMultipleNumbers_ShouldReturnSum()
        {
            // Arrange
            var numbers = "1, 2, 3, 3";
            var expected = "9";
            var stringCalculator = new StringCalculatorKataFive();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNewLineDelimiter_ShouldReturnSum()
        {
            // Arrange
            var numbers = "1\n2, 3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataFive();

            // Act
            var result = stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenCustomDelimiter_ShouldReturnSum()
        {
            // Arrange
            var numbers = "//; 1; 2";
            var expected = "3";
            var stringCalculator = new StringCalculatorKataFive();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
