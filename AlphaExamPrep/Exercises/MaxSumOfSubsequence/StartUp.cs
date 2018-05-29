using System;

namespace MaxSumOfSubsequence
{
    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int bestSum = KadeneAlgorithm(numbers);
           
            Console.WriteLine(bestSum);
           
        }

        private static int KadeneAlgorithm(int[] numbers)
        {
            int maxCurrent, maxGlobal;
            maxCurrent = numbers[0];
            maxGlobal = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                maxCurrent = Math.Max(numbers[i],maxCurrent + numbers[i]);

                if (maxCurrent > maxGlobal)
                {
                    maxGlobal = maxCurrent;
                }
            }

            return maxGlobal;
        }
    }
}