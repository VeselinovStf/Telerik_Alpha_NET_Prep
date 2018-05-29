using System;
using System.Numerics;

namespace AboveTheMainDiagonalV2
{
    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = new BigInteger[size, size];

            FillMatrix(size, matrix);
            BigInteger sum = CalculateDiagonalSum(matrix, size);
            Console.WriteLine(sum);
            //PrintMatrix(matrix);
        }

        private static BigInteger CalculateDiagonalSum(BigInteger[,] matrix, int size)
        {
            BigInteger sum = 0;

            
            for (int row = 0; row < size; row++)
            {
                for (int col = 0 + row; col < size; col++)
                {
                    sum += matrix[row, col];
                }
            }

            return sum;
        }

        private static void FillMatrix(int size, BigInteger[,] matrix)
        {
            BigInteger initialValue = (BigInteger)(Math.Pow(2, size - 1) * Math.Pow(2, size - 1));

            for (int row = size - 1; row >= 0; row--)
            {
                BigInteger insideValue = initialValue;

                for (int col = size - 1; col >= 0; col--)
                {
                    matrix[row, col] = insideValue;
                    insideValue /= 2;
                }

                initialValue /= 2;
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r,c] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}