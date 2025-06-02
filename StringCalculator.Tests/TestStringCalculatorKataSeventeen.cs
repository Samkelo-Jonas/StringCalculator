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
    }
}
