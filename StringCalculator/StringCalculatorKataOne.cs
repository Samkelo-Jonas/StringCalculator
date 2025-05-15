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

        if (numbers.Length == 1)
        {
            return numbers;

        }else if (numbers.Contains(","))
        {
            var splitNumbers = numbers.Split(',');
            
            foreach (var number in splitNumbers)
            {
                sum += int.Parse(number);
            }
            return sum.ToString();
        }

        throw new NotImplementedException("This method is not implemented yet.");
    }
}
