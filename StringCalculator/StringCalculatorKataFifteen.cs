using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculatorKataFifteen
    {
        public string Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }
            var delimiters = new[] { ',', '\n' };
            var values = numbers.Split(delimiters, StringSplitOptions.None)
                                .Select(int.Parse)
                                .ToList();
            return values.Sum().ToString();
        }
    }
}
