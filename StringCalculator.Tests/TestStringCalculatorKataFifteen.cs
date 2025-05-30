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

        public void Dispose()
        {

        }
    }
}
