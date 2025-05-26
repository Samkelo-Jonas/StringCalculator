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

        [Fact]
        public void Add_GivenMultipleNumbers_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "1, 2, 3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataTen();

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
            var stringCalculator = new StringCalculatorKataTen();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenOneCustomDelimiter_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "//;\n1; 2";
            var expected = "3";
            var stringCalculator = new StringCalculatorKataTen();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNegativeNumber_ThrowException()
        {
            // Arrange
            var numbers = "-1, 2";
            var stringCalculator = new StringCalculatorKataTen();

            // Act
            var exception = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));

            //Assert
            Assert.Equal("Negatives not allowed: -1", exception.Message);
        }

        [Fact]
        public void Add_GivenMultipleNegativeNumbers_ThrowException()
        {
            // Arrange
            var numbers = "-1, -2, 3";
            var stringCalculator = new StringCalculatorKataTen();

            // Act
            var exception = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));

            //Assert
            Assert.Equal("Negatives not allowed: -1, -2", exception.Message);
        }

        [Fact]
        public void Add_GivenNumbersGreaterThan1000_ShouldBeIgnored()
        {
            // Arrange
            var numbers = "1001, 2";
            var expected = "2";
            var stringCalculator = new StringCalculatorKataTen();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenLongCustomDelimiter_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "//[|||]\n1|||2|||3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataTen();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
