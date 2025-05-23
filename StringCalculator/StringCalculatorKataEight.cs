using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculatorKataEight
    {
        public string Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

            var sum = 0;

            if (!string.IsNullOrEmpty(numbers))
            {
                sum += int.Parse(numbers);
            }
            return sum.ToString();
        }
    }
}
