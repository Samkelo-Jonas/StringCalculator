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
            var sum = 0;
            var delimiters = new[] { ',' };

            if (!string.IsNullOrEmpty(numbers))
            {
                sum += int.Parse(numbers);
            }
            
            return sum.ToString();
        }
    }
}
