using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string GetResult(int number)
        {
            if (number.IsDivisibleByFive() && number.IsDivisibleByThree())
            {
                return "FizzBuzz";
            }

            if (number.IsDivisibleByFive())
            {
                return "Buzz";
            }
            
            if (number.IsDivisibleByThree())
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }

    public static class DivisionExtensions
    {
        public static bool IsDivisibleByFive(this int number)
        {
            return number % 5 == 0;
        }

        public static bool IsDivisibleByThree(this int number)
        {
            return number % 3 == 0;
        }
    }
}