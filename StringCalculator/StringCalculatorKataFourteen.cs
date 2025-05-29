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

            var delimiters = new[] { ',', '\n', '/', ';' };
            var values = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            
            return values.Sum().ToString();
        }
    }
}
