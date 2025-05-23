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

        [Fact]
        public void Add_GivenSingleNumber_ShouldReturnNumber()
        {
            // Arrange
            var numbers = "6";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataSeven();

            // Act
            var result = stringCalculator.Add(numbers);
            
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenTwoNumbers_ShouldReturnSum()
        {
            // Arrange
            var numbers = "1, 2";
            var expected = "3";
            var stringCalculator = new StringCalculatorKataSeven();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenMultipleNumbers_ShouldReturnSum()
        {
            // Arrange
            var numbers = "1, 2, 3, 4";
            var expected = "10";
            var stringCalculator = new StringCalculatorKataSeven();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNewLine_ShouldReturnSum()
        {
            // Arrange
            var numbers = "1\n2, 3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataSeven();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenDifferentDelimiter_ShouldReturnSum()
        {
            // Arrange
            var numbers = "//;\n1; 3";
            var expected = "4";
            var stringCalculator = new StringCalculatorKataSeven();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
