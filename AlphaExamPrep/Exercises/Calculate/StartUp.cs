using System;

namespace Calculate
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());

            decimal result = 1;
            decimal factorial = 1;
            decimal pow = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

                pow = CalculatePower(x, i);
                result += factorial / pow;
            }

            Console.WriteLine("{0:F5}", result);
        }

        private static decimal CalculatePower(decimal x, int power)
        {
            decimal result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= x;
            }

            return result;
        }
    }
}