using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculatorKataFourteen
    {
        public string Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

            return numbers;
        }
    }
}
