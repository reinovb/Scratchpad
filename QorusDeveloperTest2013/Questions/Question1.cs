using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class Question1
    {
        public const string Title = "Calculate the sum of odd numbers (20 min)";
        public static Int64 SumOddNumbers(string inputValue)
        {
            Int64 wholeNumber, total = 0;
            //just in case someone forgets the client side validation...
            if (!Int64.TryParse(inputValue, out wholeNumber))
                throw new Exception(string.Format("The value {0} is invalid. Please supply a whole number", inputValue));
            return SumOddNumbers(wholeNumber, total);
        }

        /// <summary>
        /// Overloaded method used to track the total
        /// </summary>
        /// <param name="input">Maximum value</param>
        /// <param name="total">Totals counter</param>
        /// <returns>The total of all summed numbers up to the maximum value</returns>
        private static Int64 SumOddNumbers(Int64 input, Int64 total)
        {
            if (input % 2 != 0)
                total += input;
            input--;
            return (input <= 0) ? total : SumOddNumbers(input, total);
        }
    }
}
