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

    [Fact]
    public void Add_GivenSingleNumber_ShouldReturnSameNumber()
    {
        // Arrange
        var numbers = "5";
        var expected = "5";
        var stringCalculator = new StringCalculatorKataOne();
       
        // Act
        var result = stringCalculator.Add(numbers);
        
        // Assert
        Assert.Equal(expected, result);
    }
}