using System;
using System.Collections.Generic;
using StringCalculator;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataFour
    {
        [Fact]
        public void Add_GivenEmptyString_ShouldReturnsZero()
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
        public void Add_GivenSingleNumber_ShouldReturnSameNumber()
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
        public void Add_GivenTwoNumbers_ShouldReturnSum()
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
        public void Add_GivenMultipleNumbers_ShouldReturnSum()
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
        public void Add_GivenNewLineDelimiter_ShouldReturnSum()
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

        [Fact]
        public void Add_GivenCustomDelimiter_ShouldReturnSum()
        {
            // Arrange
            var numbers = "//;\n1;2";
            var expected = "3";
            var stringCalculator = new StringCalculatorKataFour();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNegativeNumbers_ShouldThrowException()
        {
            // Arrange
            var numbers = "1,-2,3";
            var stringCalculator = new StringCalculatorKataFour();
            
            // Act
            var exception = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));

            // Assert
            Assert.Equal("Negatives not allowed: -2", exception.Message);
        }

        [Fact]
        public void Add_GivenMultipleNegativeNumbers_ShouldThrowException()
        {
            // Arrange
            var numbers = "1,-2,-3";
            var stringCalculator = new StringCalculatorKataFour();

            // Act
            var exception = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));
            // Assert
            Assert.Equal("Negatives not allowed: -2, -3", exception.Message);
        }

        [Fact]
        public void Add_GivenNumbersGreaterThan1000_ShouldIgnoreThem()
        {
            // Arrange
            var numbers = "1001,2";
            var expected = "2";
            var stringCalculator = new StringCalculatorKataFour();
            
            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNumbersWithCustomDelimiter_ShouldReturnSum()
        {
            // Arrange
            var numbers = "//[***]\n1***2***3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataFour();
            
            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNumbersWithMultipleCustomDelimiters_ShouldReturnSum()
        {
            // Arrange
            var numbers = "//[***][%%%]\n1***2%%%3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataFour();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
