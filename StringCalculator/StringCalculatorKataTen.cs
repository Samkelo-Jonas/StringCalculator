using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculatorKataTen
    {
        public string Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

            var sum = 0;
            char[] delimiters = {  ',', '\n' };
            var numbersArray = numbers.Split(delimiters);

            foreach (var number in numbersArray)
            {
                return number;
            }
            return sum.ToString();
        }
    }
}
