using System;
using System.Linq;

namespace ZigZag
{
    public class StartUp
    {
        public static void Main()
        {
            string parameters = Console.ReadLine();
            int[] sizes = SplitInputToIntArray(parameters, ' ');

            int[,] matrix = new int[sizes[0], sizes[1]];
            int sum = 0;

            int rowValue = 1;

            for (int row = 0; row <matrix.GetLength(0); row++)
            {
                int cellValue = rowValue;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cellValue;
                    cellValue += 3;
                }
                rowValue += 3;
            }

            sum = CalculateZigZagSum(matrix);
            Console.WriteLine(sum);
            PrintMatrix(matrix);
        }

        private static int CalculateZigZagSum(int[,] matrix)
        {
            int sum = 0;

            //TODO

            return sum;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
               
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                 
                }
                Console.WriteLine();
            }
        }

        private static int[] SplitInputToIntArray(string parameters, char separator)
        {
            return parameters
                .Split(new char[] { separator }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}