using System;
using System.IO;

namespace DiagonalDifference
{
    public class StartUp
    {
        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("TEST.TXT");

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr);
            Console.WriteLine(result);
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        private static int diagonalDifference(int[][] arr)
        {
            int leftDiagonalSum = GetLeftDiagonalSum(arr);
            int rightDiagonalSum = GetRightDiagonal(arr);

            return Math.Abs(leftDiagonalSum - rightDiagonalSum);
        }

        private static int GetRightDiagonal(int[][] matrix)
        {
            int sum = 0;
            int colCount = matrix.Length - 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (colCount == matrix.Length - 1 - i)
                {
                    sum += matrix[i][colCount];
                    colCount--;
                }
            }

            return sum;
        }

        private static int GetLeftDiagonalSum(int[][] matrix)
        {
            int sum = 0;
            int colCount = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (colCount == i)
                {
                    sum += matrix[i][colCount];
                    colCount++;
                }
            }
            return sum;
        }
    }
}