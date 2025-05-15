namespace StringCalculator;

public class StringCalculatorKataOne
{
    public string Add(string numbers)
    {
        var sum = 0;
        if (string.IsNullOrEmpty(numbers))
        {
            return "0";
        }

        char[] delimiters = { ',', '\n', ';', '/' };
        var numbersArray = numbers.Split(delimiters);
       
        foreach (var number in numbersArray)
        {
            if (!string.IsNullOrEmpty(number))
            {
                sum += int.Parse(number);
            }
        }
        return sum.ToString();

        throw new NotImplementedException("This method is not implemented yet.");
    }
}
