using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataSixteen
    {
        private StringCalculatorKataSixteen stringCalculator;
        public TestStringCalculatorKataSixteen()
        {
            stringCalculator = new StringCalculatorKataSixteen();
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
            var numbers = "1";
            var expected = "1";

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

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenMultipleNumbers_ShouldReturnsSum()
        {
            // Arrange
            var numbers = "1, 2, 4, 5";
            var expected = "12";

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNewLineDelimiter_ShouldReturnTheSum()
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
        public void Add_GivenSingleCustomDelimiter_ShouldReturnsSum()
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
            var exception = Assert.Throws <ArgumentException> (() => stringCalculator.Add(numbers));

            // Assert
            Assert.Equal("Negatives not allowed: -1", exception.Message);
        }

        [Fact]
        public void Add_GivenMultipleNegativeNumbers_ShouldThrowException()
        {
            // Arrange
            var numbers = "-1, -2, 3";

            // Act
            var exception = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));

            // Assert
            Assert.Equal("Negatives not allowed: -1, -2", exception.Message);
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
        public void Add_GivenSingleLongCustomDelimiter_ShouldReturnsSum()
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
        public void Add_GivenMultipleLongCustomDelimiters_ShouldReturnsSum()
        {
            // Arrange
            var numbers = "//[|||][***]\n1|||2***3";
            var expected = "6";

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
