using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculatorKataSeven
    {
        public string Add(string numbers)
        {
            var sum = 0;
            char[] delimiters = { ',', '\n', ';', '/' };
            var numbersArray = numbers.Split(delimiters);

            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

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
