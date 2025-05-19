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
        char[] delimiters = { ',', '\n', '/', ';' };
        var numbersArray = numbers.Split(delimiters);
    
        foreach (var number in numbersArray)
        {
            if (!string.IsNullOrEmpty(number))
            {
                if (int.Parse(number) < 0)
                {
                    throw new ArgumentException($"Negatives not allowed: {number}");
                }
                else if (int.Parse(number) > 1000)
                {
                    continue;
                }
                sum += int.Parse(number);
            }
        }
        
        return sum.ToString();
    }
}

