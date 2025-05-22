using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculatorKataSix
    {
        public string Add(string numbers)
        {
            var sum = 0;

            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

            return sum.ToString();

        }
    }
}
