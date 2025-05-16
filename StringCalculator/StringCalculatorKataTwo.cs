using System;
using System.Collections.Generic;

namespace StringCalculator;

public class StringCalculatorKataTwo
{
    public string Add(string numbers)
    {

        int sum = 0;
        char[] delimiters = { ',', '\n', '/', '[', ']' };
        
        if (string.IsNullOrEmpty(numbers))
        {
            return "0";
        }

        if (numbers.StartsWith("//"))
        {
            var customDelimiter = numbers[2];
            delimiters = new[] { customDelimiter, '\n' };
            numbers = numbers.Substring(4);
        }

        if (!string.IsNullOrEmpty(numbers))
        {
            var numberList = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (var number in numberList)
            {
                if (int.TryParse(number, out int num))
                {
                    sum += num;
                }
                
            }
        }




        return sum.ToString();

    }
}