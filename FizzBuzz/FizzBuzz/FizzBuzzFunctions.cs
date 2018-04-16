using System.Collections.Generic;

namespace FizzBuzz
{
    class FizzBuzzFunctions
    {
        public const string Fizz = "Fizz";
        public const string Buzz = "Buzz";
        public const string FizzBuzz = "FizzBuzz";

        public string IsNumberFizzBuzz(int numberToCalculate)
        {            
            if (numberToCalculate % 3 == 0 && numberToCalculate % 5 == 0)
            {
                return FizzBuzz;  
            }
            else if (numberToCalculate % 5 == 0)
            {
                return Buzz;
            }
            else if (numberToCalculate % 3 == 0)
            {
                return Fizz;
            }

            return numberToCalculate.ToString();          
        }
        
        public IEnumerable<string> CalculateFizzBuzzUpTo(int upTo)
        {
            for(int num = 1; num <= upTo; num++)
            {
                yield return IsNumberFizzBuzz(num);
            }
        }
    }
}
