using System;

namespace DigitAsWord
{
    public class StartUp
    {
        public static void Main()
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            try
            {
                char num = char.Parse(Console.ReadLine());
                if (char.IsDigit(num))
                {
                    Console.WriteLine(numbers[(int)char.GetNumericValue(num)]);
                }
            }
            catch 
            {
                Console.WriteLine("not a digit");
            }
        }
    }
}