using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculatorKataThirteen
    {
        public string Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return "0";
            }

            var delimiters = new[] { ',' };
            var values = numbers.Split(delimiters, StringSplitOptions.None)
                                .Select(int.Parse)
                                .ToList();

            return values.Sum().ToString();
        }
    }

}
