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

    [Fact]
    public void Add_GivenOneNumber_ShouldReturnSameNumber()
    {
        // Arrange
        var numbers = "1";
        var expected = "1";
        var stringCalculator = new StringCalculatorKataThree();
        
        // Act
        var result = stringCalculator.Add(numbers);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_GivenTwoNumbers_ShouldReturnSum()
    {
        // Arrange
        var numbers = "1,2";
        var expected = "3";
        var stringCalculator = new StringCalculatorKataThree();

        // Act
        var result = stringCalculator.Add(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_GivenMultipleNumbers_ShouldReturnSum()
    {
        // Arrange
        var numbers = "3,4,5";
        var expected = "12";
        var stringCalculator = new StringCalculatorKataThree();
        
        // Act
        var result = stringCalculator.Add(numbers);
        
        // Assert
        Assert.Equal(expected, result);
    }
}