using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculatorKataEleven
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
                    sum += int.Parse(number);
                }
            }
            return sum.ToString();
        }
    }
}
