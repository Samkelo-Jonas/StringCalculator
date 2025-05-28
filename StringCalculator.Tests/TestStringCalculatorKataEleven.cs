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

        [Fact]
        public void Add_GivenOneNumber_ShouldReturnThatNumber()
        {
            // Arrange
            var numbers = "1";
            var expected = "1";
            var stringCalculator = new StringCalculatorKataEleven();

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
            var stringCalculator = new StringCalculatorKataEleven();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenMultipleNumbers_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "2, 4, 6, 8";
            var expected = "20";
            var stringCalculator = new StringCalculatorKataEleven();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNewLine_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "1\n2, 3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataEleven();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenOneCustomDelimiter_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "//;\n1; 2; 3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataEleven();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenOneNegativeNumber_ShouldThrowException()
        {
            // Arrange
            var numbers = "-1, 2";
            var stringCalculator = new StringCalculatorKataEleven();

            // Act
            var exception = Assert.Throws <ArgumentException>(() => stringCalculator.Add(numbers));

            // Assert
            Assert.Equal("Negatives not allowed: -1", exception.Message);
        }

        [Fact]
        public void Add_GivenOMultipleNegativeNumbers_ShouldThrowException()
        {
            // Arrange
            var numbers = "-1, -2, 3";
            var stringCalculator = new StringCalculatorKataEleven();

            // Act
            var exception = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));

            // Assert
            Assert.Equal("Negatives not allowed: -1, -2", exception.Message);
        }
    }
}
