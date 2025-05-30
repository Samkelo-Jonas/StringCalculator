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
            var delimiters = new[] { ',', '\n', '/', ';' };
            var values = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            var negatives = values.Where(i => i < 0).ToList();

            if (negatives.Any())
            {
                throw new ArgumentException($"Negatives not allowed: {string.Join(", ",negatives)}");
            }
            return values.Where(i => i <= 1000).Sum().ToString();
        }
    }
}
