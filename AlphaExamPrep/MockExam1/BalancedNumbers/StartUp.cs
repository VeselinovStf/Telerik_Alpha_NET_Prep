/*
 * A balanced number is a 3-digit number whose second digit is equal to the sum
 * of the first and last digit.
 * Write a program which reads and sums balanced numbers.
 * You should stop when an unbalanced number is given.
 */

using System;

namespace BalancedNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            int sum = 0;
            while (true)
            {
                string inputNumber = Console.ReadLine();

                int firstDigit = (int)char.GetNumericValue(inputNumber[0]);
                int secondDigit = (int)char.GetNumericValue(inputNumber[1]);
                int thirdDigit = (int)char.GetNumericValue(inputNumber[2]);

                int currentSum = firstDigit + thirdDigit;
                if (currentSum == secondDigit)
                {
                    sum += int.Parse(inputNumber);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}