﻿using StringCalculator;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataTwo
    {
        [Fact]
        public void Add_GivenEmptyString_ShouldReturnsZero()
        {
            // Arrange
            var numbers = "";
            var expected = "0";
            var stringCalculator = new StringCalculatorKataTwo();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenSingleNumber_ShouldReturnsSameNumber()
        {
            // Arrange
            var numbers = "2";
            var expected = "2";
            var stringCalculator = new StringCalculatorKataTwo();
            
            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenTwoNumbers_ShouldReturnTheSum()
        {
            //Arrange
            var numbers = "2,3";
            var expected = "5";
            var stringCalculator = new StringCalculatorKataTwo();

            //Act
            var result = stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenMultipleNumbers_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "1,3,5";
            var expected = "9";
            var stringCalculator = new StringCalculatorKataTwo();
            
            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNewLineDelimiter_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "1\n2,3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataTwo();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenCustomDelimiter_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "//;\n1;2;3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataTwo();
           
            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenNegativeNumbers_ShouldThrowException()
        {
            // Arrange
            var numbers = "1,-2";
            var stringCalculator = new StringCalculatorKataTwo();
            
            // Act
            var exception = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));

            //Assert
            Assert.Equal("Negatives not allowed: -2", exception.Message);
        }

        [Fact]
        public void Add_GivenNumbersGreaterThan1000_ShouldIgnoreThem()
        {
            // Arrange
            var numbers = "1001,2";
            var expected = "2";
            var stringCalculator = new StringCalculatorKataTwo();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenCustomDelimiterWithMultipleCharacters_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "//[***]\n1***2***3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataTwo();
            
            // Act
            var result = stringCalculator.Add(numbers);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_GivenMultipleCustomDelimiters_ShouldReturnTheSum()
        {
            // Arrange
            var numbers = "//[***][%%%]\n1***2%%%3";
            var expected = "6";
            var stringCalculator = new StringCalculatorKataTwo();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
