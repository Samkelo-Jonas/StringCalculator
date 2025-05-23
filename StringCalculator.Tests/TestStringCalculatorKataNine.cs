using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class TestStringCalculatorKataNine
    {
        [Fact]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            // Arrange
            var numbers = "";
            var expected = "0";
            var stringCalculator = new TestStringCalculatorKataNine();

            // Act
            var result = stringCalculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
