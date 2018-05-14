using System;

namespace BiggestPrimeNumber
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int biggestPrime = 1;

            for (int i = 1; i <= n; i++)
            {
                if (isPrime(i))
                {
                    biggestPrime = i;
                }
            }

            Console.WriteLine(biggestPrime);
        }

        private static bool isPrime(int n)
        {
            int maxN = (int)Math.Sqrt(n);

            for (int i = 2; i <= maxN; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}