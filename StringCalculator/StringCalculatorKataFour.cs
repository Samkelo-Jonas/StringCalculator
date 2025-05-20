using System;
using System.Collections.Generic;

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

            return sum.ToString();
        }
    }
}
