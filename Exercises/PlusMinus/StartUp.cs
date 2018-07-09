using System;

namespace PlusMinus
{
    public class StartUp
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(
                Console.ReadLine()
                .Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            plusMinus(arr);
        }

        private static void plusMinus(int[] arr)
        {
            int arrsize = arr.Length;

            int negativeCount = 0;
            int positiveCount = 0;
            int zeroCount = 0;

            decimal positiveFraction = 0m;
            decimal negativeFraction = 0m;
            decimal zeroesFraction = 0m;

            for (int i = 0; i < arr.Length; i++)
            {
                var current = arr[i];
                if (current < 0)
                {
                    negativeCount++;
                }
                else if (current > 0)
                {
                    positiveCount++;
                }
                else
                {
                    zeroCount++;
                }
            }

            positiveFraction = positiveCount / (decimal)arrsize;
            negativeFraction = negativeCount / (decimal)arrsize;
            zeroesFraction = zeroCount / (decimal)arrsize;

            Console.WriteLine($"{positiveFraction:F6}");
            Console.WriteLine($"{negativeFraction:F6}");
            Console.WriteLine($"{zeroesFraction:F6}");
        }
    }
}