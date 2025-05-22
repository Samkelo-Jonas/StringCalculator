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
            char[] delimiters = { ',', '\n', '[', ']', '/', ';', '!' };
            var numbersArray = numbers.Split(delimiters);
            var negativeNumbers = new List<string>();

            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

            foreach (var number in numbersArray)
            {
                if (!string.IsNullOrEmpty(number))
                {
                    if (int.Parse(number) < 0)
                    {
                        negativeNumbers.Add(number);
                    }
                    sum += int.Parse(number);
                }
            }
            if (negativeNumbers.Any())
            {
                throw new ArgumentException($"Negatives not allowed: {string.Join("," , negativeNumbers)}");
            }
            return sum.ToString();

        }
    }
}
