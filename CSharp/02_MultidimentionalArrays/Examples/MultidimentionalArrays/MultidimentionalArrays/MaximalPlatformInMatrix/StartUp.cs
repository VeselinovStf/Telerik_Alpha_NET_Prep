/*
 * Maximal Platform in a Matrix
 *
 * In the next example we will solve another interesting problem:
 * we are given a two-dimensional rectangular array (matrix) of integers and our
 * task is to find the sub-matrix of size of 2 by 2 with maximum sum of its
 * elements and to print it to the console.
 *
 * Introduction to programming with C#
 * http://www.introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296434
 *
 */

using System;
using System.IO;

namespace MaximalPlatformInMatrix
{
    public class StartUp
    {
        private static void Main()
        {
            int[,] matrix = {
                   { 0, 2, 4, 0, 9, 5 },
                   { 7, 1, 3, 3, 2, 1 },
                   { 1, 3, 9, 8, 5, 6 },
                   { 4, 6, 7, 9, 1, 0 }
            };

            int maximalPlatform = FindMaximalPlatformSum(matrix);

            Console.WriteLine(maximalPlatform);
        }

        public static int FindMaximalPlatformSum(int[,] matrix)
        {
            int maximal = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum =
                        matrix[row, col] +
                        matrix[row + 1, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col + 1];

                    if (currentSum > maximal)
                    {
                        maximal = currentSum;
                    }
                }
            }

            return maximal;
        }
    }
}