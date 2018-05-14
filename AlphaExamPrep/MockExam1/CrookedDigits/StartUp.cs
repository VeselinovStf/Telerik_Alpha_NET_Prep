/*
 * The crooked digit of a given number N is calculated using the number's digits in a very weird and bendy algorithm. The algorithm takes the following steps:
 * Sums the digits of the number N and stores the result back in N.
 * If the obtained result is bigger than 9, step 1. is repeated, otherwise the algorithm finishes.
 * The last obtained value of N is the result, calculated by the algorithm.
 */

using System;

namespace CrookedDigits
{
    public class StartUp
    {
        //public static void FakeInput()
        //{
        //    string input = @"1020340567.89";

        //    Console.SetIn(new StringReader(input));
        //}

        public static void Main()
        {
            //FakeInput();

            string inputNumber = Console.ReadLine();

            int sum = 0;
            while (true)
            {
                for (int i = 0; i < inputNumber.Length; i++)
                {
                    var currentChar = inputNumber[i];
                    if (currentChar != '.' && currentChar != '-')
                    {
                        sum += (int)char.GetNumericValue(inputNumber[i]);
                    }
                }
                if (sum <= 9)
                {
                    break;
                }
                else
                {
                    inputNumber = sum.ToString();
                    sum = 0;
                }
            }
            Console.WriteLine(sum);
        }
    }
}