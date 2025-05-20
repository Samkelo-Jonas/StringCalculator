using System;
using System.Collections.Generic;
using System.Globalization;

namespace StringCalculator
{
    public class StringCalculatorKataFour
    {
        int sum = 0;
        
        public string Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

            char[] delimiters = { ',', '\n', '/', ';' };
            var numbersArray = numbers.Split(delimiters);
            var negativeNumbers = new List<int>();

            foreach (var number in numbersArray)
            {
                if (!string.IsNullOrEmpty(number))
                {
                    if (int.Parse(number) < 0)
                    {
                        negativeNumbers.Add(int.Parse(number));
                    }
                    else if (int.Parse(number) > 1000)
                    {
                        continue;
                    }
                   
                    sum += int.Parse(number);
                }
            }
            if (negativeNumbers.Any())
            {
                throw new ArgumentException($"Negatives not allowed: {string.Join(", ", negativeNumbers)}");
            }
            return sum.ToString();
        }
    }
}
