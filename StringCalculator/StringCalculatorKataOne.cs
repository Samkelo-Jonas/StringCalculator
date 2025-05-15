namespace StringCalculator;

public class StringCalculatorKataOne
{
    public string Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return "0";
        }

        if (numbers.Length == 1)
        {
            return numbers;
        }


        throw new NotImplementedException("This method is not implemented yet.");
    }
}
