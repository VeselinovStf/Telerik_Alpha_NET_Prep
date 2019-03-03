using System;
using static System.Console;

namespace _2DArrayDS
{
    public class StartUp
    {
        public static void Main()
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            WriteLine(result);
        }

        public static int hourglassSum(int[][] arr)
        {
            int maxSum = int.MinValue;
            int rows = 0;

            while (rows <= 3)
            {
                int currentSum = 0;

                for (int i = 0; i < arr[rows].Length - 2; i++)
                {
                    currentSum =
                        arr[rows][i] + arr[rows][i + 1] + arr[rows][i + 2] +
                        arr[rows + 1][i + 1] +
                        arr[rows + 2][i] + arr[rows + 2][i + 1] + arr[rows + 2][i + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }

                rows++;
            }

            return maxSum;
        }
    }
}