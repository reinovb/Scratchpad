using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public static class Question2
    {
        public const string Title = "String manipulation (25 min)";
        public const byte index = 3;

        public static string SwopCharacters(string inputValue)
        {
            char placeHolder;
            char[] charArr = inputValue.ToCharArray();

            for (int i = index; i <= charArr.Length; i++)
            {
                if (i % index == 0)
                {
                    placeHolder = charArr[i-1];
                    charArr[i-1] = charArr[i - index];
                    charArr[i - index] = placeHolder;
                }   
            }

            return String.Concat(charArr);
        }
    }
}
