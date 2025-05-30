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

        public void Dispose()
        {

        }
    }
}
