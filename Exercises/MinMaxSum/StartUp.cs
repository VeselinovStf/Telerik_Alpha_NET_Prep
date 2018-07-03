using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    public class StartUp
    {
        //NOTE: THIS IS BUGGY
        static void miniMaxSum(int[] arr)
        {
           
            int minValue = arr.Min();
            int maxValue = arr.Max();

            long max = GetValue(arr,minValue);
            long min = GetValue(arr, maxValue);
           

            Console.WriteLine($"{min} {max}");

        }

        private static long GetValue(int[] arr, int v)
        {
            var result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != v)
                {
                    result += arr[i];
                }
            }
            return result;
        }

        public  static void Main()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine()
                .Split(' '), 
                arrTemp => Convert.ToInt32(arrTemp))
        ;
            miniMaxSum(arr);
        }
    }
}
