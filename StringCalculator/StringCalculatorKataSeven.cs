using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculatorKataSeven
    {
        public string Add(string numbers)
        {
            var sum = 0;
            char[] delimiters = { ',', '\n', ';', '/' };
            var numbersArray = numbers.Split(delimiters);
            var negativeNumbers = new List<int>();

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
                        negativeNumbers.Add(int.Parse(number));
                    }
                    sum += int.Parse(number);
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
