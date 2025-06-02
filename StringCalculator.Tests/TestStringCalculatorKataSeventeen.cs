using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataSeventeen
    {
        private StringCalculatorKataSeventeen stringCalculator;
        public TestStringCalculatorKataSeventeen()
        {
            stringCalculator = new StringCalculatorKataSeventeen();
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
        public void Add_GivenOneNumber_ShouldThatNumber()
        {
            // Arrange
            var numbers = "2";
            var expected = "2";

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

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
