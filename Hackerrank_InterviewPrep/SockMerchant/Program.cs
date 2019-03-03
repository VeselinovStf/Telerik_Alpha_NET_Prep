using System;
using System.Collections.Generic;

namespace SockMerchant
{
    public class Program
    {
        // Complete the sockMerchant function below.

        public static int sockMerchant(int n, int[] ar)
        {
            var totalPairs = 0;
            var colors = new HashSet<int>();

            for (int i = 0; i < ar.Length; i++)
            {
                if (!colors.Contains(ar[i]))
                {
                    colors.Add(ar[i]);
                }
                else
                {
                    totalPairs++;
                    colors.Remove(ar[i]);
                }
            }

            return totalPairs;
        }

        public static int sockMerchantDictionarySolution(int n, int[] ar)
        {
            var numbers = new Dictionary<int, int>();
            var totalPairs = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                var value = ar[i];

                if (!numbers.ContainsKey(value))
                {
                    numbers[value] = 1;
                }
                else
                {
                    numbers[value]++;
                }
            }

            foreach (var num in numbers)
            {
                totalPairs += num.Value / 2;
            }

            return totalPairs;
        }

        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array
                .ConvertAll(Console.ReadLine()
                    .Split(' ')
                        , arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
        }
    }
}