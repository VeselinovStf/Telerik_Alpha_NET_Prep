using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20_Sorting
{
    public class StartUp
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int totalSwaps = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(j, j + 1, a);
                        totalSwaps++;
                    }
                }

                if (totalSwaps == 0)
                {
                    break;
                }
            }

            Console.WriteLine($"Array is sorted in {totalSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Length - 1]}");
        }

        private static void Swap(int v1, int v2, int[] arr)
        {
            var temp = arr[v1];
            arr[v1] = arr[v2];
            arr[v2] = temp;
        }
    }
}