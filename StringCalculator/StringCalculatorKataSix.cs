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
            char[] delimiters = { ',', '\n', '[', ']', '/', ';' };
            var numbersArray = numbers.Split(delimiters);

            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

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
