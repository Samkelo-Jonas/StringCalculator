using System;
using System.Collections.Generic;

namespace StringCalculator;

public class StringCalculatorKataTwo
{
    public string Add(string numbers)
    {

        int sum = 0;

        if (string.IsNullOrEmpty(numbers))
        {
            return "0";
        }
        char[] delimiters = { ',', '\n', '/', '[', ']', '*' };
        if (numbers.StartsWith("//"))
        {
            var customDelimiter = numbers[2];
            delimiters = new[] { customDelimiter, '\n', ',', '/', '[', ']', '*' };
            numbers = numbers.Substring(4);
        }

        var numberArray = numbers.Split(delimiters);

        foreach (var number in numberArray)
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