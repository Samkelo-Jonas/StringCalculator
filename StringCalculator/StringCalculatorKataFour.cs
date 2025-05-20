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

            char[] delimiters = { ',', '\n' };
            var numbersArray = numbers.Split(delimiters);

            foreach (var number in numbersArray)
            {
                if (!string.IsNullOrEmpty(number))
                {
                    sum += int.Parse(number);
                }
            }
            return sum.ToString();
        }
    }
}
