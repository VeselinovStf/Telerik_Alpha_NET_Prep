using System;

namespace _02_PrimeTriangle
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    for (int r = 1; r <= i; r++)
                    {
                        if (IsPrime(r))
                        {
                            Console.Write(1);
                        }
                        else
                        {
                            Console.Write(0);
                        }
                    }
                    Console.WriteLine();
                }
            }

        }

        private static bool IsPrime(int n)
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