using System;

namespace MaxSum3x3
{
    public class StartUp
    {
        public static void Main()
        {
            int[] inputSizes = SplitToArray(2);
            int initialRows = inputSizes[0];
            int initialCols = inputSizes[1];

            int[,] matrix = new int[initialRows, initialCols];

            FillMatrix(matrix, initialRows, initialCols);

            int maxSum = GetSumOfElements(matrix);

            Console.WriteLine(maxSum);
        }

        private static int GetSumOfElements(int[,] matrix)
        {
            int maxSum = -1024000;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum >= maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            return maxSum;
        }

        private static void FillMatrix(int[,] matrix, int initialRows, int initialCols)
        {
            for (int i = 0; i < initialRows; i++)
            {
                int[] splitNumbersInput = SplitToArray(initialCols);

                for (int j = 0; j < splitNumbersInput.Length; j++)
                {
                    matrix[i, j] = splitNumbersInput[j];
                }
            }
        }

        private static int[] SplitToArray(int i)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] result = new int[i];

            int y;
            int index = 0;
            for (int x = 0; x < s.Length; x++)
            {
                string singleStringNum = s[x];
                y = 0;
                bool isNegative = false;
                for (int j = 0; j < singleStringNum.Length; j++)
                {
                    if (singleStringNum[j] == '-')
                    {
                        isNegative = true;
                        continue;
                    }
                    y = y * 10 + (singleStringNum[j] - '0');
                }

                if (isNegative)
                {
                    y = y * -1;
                }
                result[index] = y;
                index++;
            }

            return result;
        }
    }
}