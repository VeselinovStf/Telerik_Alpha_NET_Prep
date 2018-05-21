using System;
using System.Numerics;

namespace NFactorial
{
    public class StartUp
    {
        public static void Main()
        {
            int f = int.Parse(Console.ReadLine());

            BigInteger factorial = CalculateFactorial(f);

            Console.WriteLine(factorial);
        }

        private static BigInteger CalculateFactorial(BigInteger f)
        {
            BigInteger result;
            if (f == 0 || f == 1)
            {
                return 1;
            }

            result = CalculateFactorial(f - 1) * f;
            return result;
        }
    }
}