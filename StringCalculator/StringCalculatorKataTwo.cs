using System;
using System.Collections.Generic;

namespace StringCalculator;

public class StringCalculatorKataTwo
{
    int sum = 0;
    char[] delimiters = { ',', '\n' };
    public string Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return "0";
        }

        if (!string.IsNullOrEmpty(numbers))
        {
            var numberArray = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (var number in numberArray)
            {
                if (int.TryParse(number, out int result))
                {
                    sum += result;
                }
            }
        }

        return sum.ToString();

    }
}