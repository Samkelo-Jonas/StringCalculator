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

            if (!string.IsNullOrEmpty(numbers))
            {
                sum += int.Parse(numbers);
            }

            return sum.ToString();
        }
    }
}
