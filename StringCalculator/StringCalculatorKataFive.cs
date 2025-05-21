using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculatorKataFive
    {
        public string Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }
            
            var sum = 0;
            char[] delimiters = { ',', '\n', '/', ';' };
            var numbersArray = numbers.Split(delimiters);

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
