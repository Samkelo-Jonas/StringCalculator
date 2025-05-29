using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataFourteen : IDisposable
    {
        private StringCalculatorKataFourteen stringCalculator;
        public TestStringCalculatorKataFourteen()
        {
            stringCalculator = new StringCalculatorKataFourteen();
        }

        [Fact]
        public void Add_GivenAnEmptyString_ShouldReturn0()
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
        public void Add_GivenTwoNumbers_ShouldReturnTheirSum()
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
        public void Add_GivenMultipleNumbers_ShouldReturnTheirSum()
        {
            // Arrange
            var numbers = "1, 2, 1, 4";
            var expected = "8";

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNewLine_ShouldReturnTheirSum()
        {
            // Arrange
            var numbers = "1\n2, 3";
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
