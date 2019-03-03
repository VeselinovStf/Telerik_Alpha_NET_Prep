using System;
using static System.Console;

namespace LeftRotation
{
    public class StartUp
    {
        public static int[] rotLeft(int[] a, int d)
        {
            int arrLength = a.Length;

            int[] result = new int[arrLength];
            int rotIndex = d % arrLength;

            int insertIndex = 0;
            for (int i = rotIndex; i < arrLength; i++)
            {
                result[insertIndex] = a[i];
                insertIndex++;
            }

            for (int i = 0; i < rotIndex; i++)
            {
                result[insertIndex] = a[i];
                insertIndex++;
            }

            return result;
        }

        public static void Main()
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

            WriteLine(string.Join(" ", result));
        }
    }
}