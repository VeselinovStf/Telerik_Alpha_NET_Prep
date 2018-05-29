using System;
using System.Collections.Generic;

namespace PrimesToN
{
    public class StartUp
    {
        public static List<int> primes = new List<int>();

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 2; j <= n; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;

                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }

                isPrime = true;
            }

            Console.WriteLine(string.Join(" ", primes));
        }
    }
}