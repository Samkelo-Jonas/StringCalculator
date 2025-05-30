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

    [Fact]
    public void Add_GivenTwoNumbers_ShouldReturnSum()
    {
        // Arrange
        var numbers = "1,2";
        var expected = "3";
        var stringCalculator = new StringCalculatorKataOne();
        
        // Act
        var result = stringCalculator.Add(numbers);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_GivenMultipleNumbers_ShouldReturnSum()
    {
        // Arrange
        var numbers = "1,2,3,4";
        var expected = "10";
        var stringCalculator = new StringCalculatorKataOne();

        // Act
        var result = stringCalculator.Add(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_GivenNewLineDelimiter_ShouldReturnSum()
    {
        // Arrange
        var numbers = "1\n2,3";
        var expected = "6";
        var stringCalculator = new StringCalculatorKataOne();
        
        // Act
        var result = stringCalculator.Add(numbers);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_GivenCustomDelimiter_ShouldReturnSum()
    {
        // Arrange
        var numbers = "//;\n1;2";
        var expected = "3";
        var stringCalculator = new StringCalculatorKataOne();

        // Act
        var result = stringCalculator.Add(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_GivenNegativeNumbers_ShouldThrowException()
    {
        // Arrange
        var numbers = "1,-2,3";
        var stringCalculator = new StringCalculatorKataOne();
        
        // Act
        var exception = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));

        //Assert
        Assert.Equal("Negatives not allowed: -2", exception.Message);
    }

    [Fact]
    public void Add_GivenNumberGreaterThan1000_ShouldIgnoreIt()
    {
        // Arrange
        var numbers = "2,1001";
        var expected = "2";
        var stringCalculator = new StringCalculatorKataOne();
        
        // Act
        var result = stringCalculator.Add(numbers);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_GivenMultipleDelimiters_ShouldReturnSum()
    {
        // Arrange
        var numbers = "//[|||]\n1|||2|||3";
        var expected = "6";
        var stringCalculator = new StringCalculatorKataOne();

        // Act
        var result = stringCalculator.Add(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_GivenMultipleCustomDelimiters_ShouldReturnSum()
    {
        // Arrange
        var numbers = "//[***][%%%]\n1***2%%%3";
        var expected = "6";
        var stringCalculator = new StringCalculatorKataOne();
        
        // Act
        var result = stringCalculator.Add(numbers);
        
        // Assert
        Assert.Equal(expected, result);
    }
}