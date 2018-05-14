/*
 * By a given N number, from which you need to generate a sequence of 1 to N inclusive.
 * For every prime number in that sequence, you need to print out all the other numbers
 * before it (and the number itself), whether they are prime or not
 */

using System;

namespace PrimeTriangle
{
    public class StartUp
    {
        public static void Main()
        {
            int initialNumber = int.Parse(Console.ReadLine());

            int totalRows = GetToTalRows(initialNumber);

            int rowCounter = 1;
            for (int i = 1; i <= totalRows; i++)
            {
                for (int col = 1; col <= rowCounter; col++)
                {
                    if (IsPrime(col))
                    {
                        Console.Write("1");
                        if (rowCounter == col)
                        {
                            rowCounter++;
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("0");
                        if (rowCounter == col)
                        {
                            rowCounter++;
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        private static int GetToTalRows(int initialNumber)
        {
            int total = 0;
            for (int i = 1; i <= initialNumber; i++)
            {
                if (IsPrime(i))
                {
                    total++;
                }
            }
            return total;
        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return true;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}