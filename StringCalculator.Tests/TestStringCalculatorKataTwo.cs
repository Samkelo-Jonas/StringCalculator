using StringCalculator;

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
    }
}
