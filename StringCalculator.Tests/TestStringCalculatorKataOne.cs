namespace StringCalculator.Tests;

public class TestStringCalculatorKataOne
{
    [Fact]
    public void Add_GivenEmptyString_ShouldReturnZero()
    {
        // Arrange
        var numbers = "";
        var expected = "0";
        var stringCalculator = new StringCalculatorKataOne();

        // Act
        var result = stringCalculator.Add(numbers);

        // Assert
        Assert.Equal(expected, result);
    }
}