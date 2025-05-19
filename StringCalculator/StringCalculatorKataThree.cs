namespace StringCalculator;

public class StringCalculatorKataThree
{
    public string Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return "0";
        }

        var sum = 0;
        char[] delimiters = { ',', '\n' };
        var numberArray = numbers.Split(delimiters);

        if (!string.IsNullOrEmpty(numbers))
        {
            return numbers;
        }
        return "numbers";
    }
}

