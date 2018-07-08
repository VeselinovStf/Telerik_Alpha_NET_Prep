using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortPart1
{
    class StartUp
    {
        static void insertionSort1(int n, int[] arr)
        {
            int last = arr[arr.Length - 1];
            int i = arr.Length - 2;
            while (i + 1 > 0 && last <= arr[i])
            {
                arr[i + 1] = arr[i--];
                Console.WriteLine(string.Join(" ", arr));
            }
            arr[i + 1] = last;
            Console.WriteLine(string.Join(" ", arr));


        }



        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine()
                .Split(' '), 
                arrTemp => Convert.ToInt32(arrTemp));

            insertionSort1(n, arr);
        }
    }
}
