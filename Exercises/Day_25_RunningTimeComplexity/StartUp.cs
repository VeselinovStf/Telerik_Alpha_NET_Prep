using System;

namespace Day_25_RunningTimeComplexity
{
    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                bool isPrime = PrimeNumber(number);

                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
        }

        private static bool PrimeNumber(int number)
        {
            if (number <= 1) return false;
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