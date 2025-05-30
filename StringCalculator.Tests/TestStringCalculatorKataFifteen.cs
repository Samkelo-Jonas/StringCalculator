using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataFifteen: IDisposable
    {
        private StringCalculatorKataFifteen stringCalculator;
        public TestStringCalculatorKataFifteen()
        {
            stringCalculator = new StringCalculatorKataFifteen();
        }

        [Fact]
        public void Add_GivenEmptyString_ShouldReturn0()
        {
            // Arrange
            var numbers = "";
            var expected = "0";

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenOneNumber_ShouldReturnThatNumber()
        {
            // Arrange
            var numbers = "12";
            var expected = "12";

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenTwoNumbers_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "2, 3";
            var expected = "5";

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenMultipleNumbers_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "2, 3, 4, 5";
            var expected = "14";

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

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenOneCustomDelimiter_ShouldReturnSum()
        {
            // Arrange
            var numbers = "//;\n1;2";
            var expected = "3";

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

            // Act
            var exception = Assert.Throws <ArgumentException>(() => stringCalculator.Add(numbers));

            // Assert
            Assert.Equal("Negatives not allowed: -1", exception.Message);
        }

        [Fact]
        public void Add_GivenMultipleNegativeNumber_ShouldThrowException()
        {
            // Arrange
            var numbers = "2, -4, 3, -5";

            // Act
            var exception = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));

            // Assert
            Assert.Equal("Negatives not allowed: -4, -5", exception.Message);
        }

        [Fact]
        public void Add_GivenNumbersGreaterThan1000_ShouldIgnoreThem()
        {
            // Arrange
            var numbers = "1001, 2";
            var expected = "2";

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenOneLongCustomDelimiter_ShouldReturnSum()
        {
            // Arrange
            var numbers = "//[|||]\n1|||2|||3";
            var expected = "6";

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenMultipleLongCustomDelimiters_ShouldReturnSum()
        {
            // Arrange
            var numbers = "//[|||][***]\n1|||2***3";
            var expected = "6";

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
        public void Dispose()
        {

        }
    }
}
