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
            return numbers;
        }
    }
}
