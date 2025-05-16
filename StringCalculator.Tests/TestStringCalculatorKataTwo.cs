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
    }
}
