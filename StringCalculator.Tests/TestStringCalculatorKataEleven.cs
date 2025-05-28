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
    }
}
