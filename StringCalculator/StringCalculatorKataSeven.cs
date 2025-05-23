using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculatorKataSeven
    {
        public string Add(string numbers)
        {
            var sum = 0;

            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

            if (!string.IsNullOrEmpty(numbers))
            {
                return numbers;
            }
            return sum.ToString();
        }
    }
}
