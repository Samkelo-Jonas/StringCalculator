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
    }
}
