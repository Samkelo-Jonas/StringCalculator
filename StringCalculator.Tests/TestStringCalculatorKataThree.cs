using StringCalculator;

namespace StringCalculator.Tests;

public class TestStringCalculatorKataThree
{
    [Fact]
    public void Add_GivenEmptyString_ShouldReturn0()
    {
        // Arrange
        var numbers = "";
        var expected = "0";
        var stringCalculator = new StringCalculatorKataThree();

        // Act
        var result = stringCalculator.Add(numbers);

        // Assert
        Assert.Equal(expected, result);
    }
}