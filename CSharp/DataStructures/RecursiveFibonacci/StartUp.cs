using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonacci
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long fib = 0;
            for (int i = 0; i < n; i++)
            {
                fib = GetFibunacciNumber(n);
            }

            Console.WriteLine(fib);
        }

        private static long GetFibunacciNumber(long n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n <= 2)
            {
                return 1;
            }

            var fib = GetFibunacciNumber(n - 1) + GetFibunacciNumber(n - 2);

            return fib;
        }
    }
}