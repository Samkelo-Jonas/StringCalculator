using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculatorKataNine
    {
        public string Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

            var sum = 0;
            char[] delimiters = { ',', '\n', ';', '/', '[', ']', '|', '*' };
            var numbersArray = numbers.Split(delimiters);
            var negativeNumbers = new List<int>();

            foreach ( var number in numbersArray)
            {
                if (!string.IsNullOrEmpty(number))
                {
                    var value = int.Parse(number);

                    if (value < 0)
                    {
                        negativeNumbers.Add(value);
                    }
                    else if (value > 1000)
                    {
                        continue;
                    }
                        sum += value;
                }
            }
            if (negativeNumbers.Any())
            {
                throw new ArgumentException($"Negatives not allowed: {string.Join(", ", negativeNumbers)}");
            }
            return sum.ToString();
        }
    }
}
