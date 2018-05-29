using System;
using System.Numerics;

namespace AboveTheMainDiagonal
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = new BigInteger[n, n];


            FillMatrix(matrix);
            // PrintMatrix(matrix);
            BigInteger sum = SumAboveDiagonal(matrix);
            Console.WriteLine(sum);
        }

        private static BigInteger SumAboveDiagonal(BigInteger[,] matrix)
        {
            BigInteger sum = 0;
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < col; row++)
                {
                    sum += matrix[row, col];

                }

            }
            return sum;
        }

        private static void PrintMatrix(BigInteger[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(BigInteger[,] matrix)
        {
            BigInteger initialValue = 2;
            BigInteger sum = 0;
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row <= col; row++)
                {
                    matrix[row, col - row] = initialValue;

                }
                initialValue = initialValue * 2;
            }

            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                int tempRow = row;
                for (int col = matrix.GetLength(1) -1; col > 0; col--)
                {
                    matrix[tempRow , col ] = initialValue;
                    tempRow++;
                    if (tempRow >=matrix.GetLength(0))
                    {
                        break;
                    }
                }
                initialValue = initialValue * 2;
            }

         
        }
    }
}