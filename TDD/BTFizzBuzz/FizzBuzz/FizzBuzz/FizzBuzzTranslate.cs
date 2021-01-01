using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzTranslate
    {
        public string TranslateN(int n)
        {
            if (n % 3 == 0 && n > 0)
            {
                if (n % 5 == 0)
                {
                    return "FizzBuzz";
                }
                else
                {
                    return "Fizz";
                }
            }
            else if (n % 5 == 0 && n > 0)
            {
                if (n % 3 == 0)
                {
                    return "FizzBuzz";
                }
                else
                {
                    return "Buzz";
                }
            }

            else
            {
                return $"{n}";
            }

        }

    }
}
