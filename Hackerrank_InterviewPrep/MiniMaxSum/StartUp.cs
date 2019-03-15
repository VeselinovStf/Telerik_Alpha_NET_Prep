using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMaxSum
{
    public class StartUp
    {
        public static void Main()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            miniMaxSum(arr);
        }

        public static void miniMaxSum(int[] numbers)
        {
            var sum = 0L;

            var min = long.MaxValue;
            var max = 0L;

            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                   
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine(string.Format("{0} {1}", sum - max, sum - min));
        }
    }
}
