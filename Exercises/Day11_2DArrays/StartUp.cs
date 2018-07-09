using System;

namespace Day11_2DArrays
{
    public class StartUp
    {
        public static void Main()
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array
                    .ConvertAll(Console.ReadLine()
                    .Split(' '),
                    arrTemp => Convert.ToInt32(arrTemp));
            }

            int maxSum = int.MinValue;

            for (int row = 0; row < arr.GetLength(0) - 2; row++)
            {
                int currentSum = 0;

                for (int col = 0; col < arr[row].Length - 2; col++)
                {
                    currentSum = arr[row][col] + arr[row][col + 1] + arr[row][col + 2] +
                        arr[row + 1][col + 1] +
                        arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }

                    currentSum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}