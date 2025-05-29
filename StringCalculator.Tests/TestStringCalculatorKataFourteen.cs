using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Dispose()
        {
        }
    }
}
