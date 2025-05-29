using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculatorKataTwelve
    {
        public string Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }
            
            var delimiters = new[] { ',', '\n', '/', ';', '[',']', '|', '*' };
            var values = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();

            var negativeNumbers = values.Where(value => value < 0).ToList();
            
            if (negativeNumbers.Any())
            {
                throw new ArgumentException($"Negatives not allowed: {string.Join(", ", negativeNumbers)}");
            }

            return values.Where(value => value < 1000).Sum().ToString();
        }
    }
}
