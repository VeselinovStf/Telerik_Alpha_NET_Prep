using System;
using System.Linq;

namespace SequenceInMatrix
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

            int horizontalSequence = GetHorizontalSequence(matrix);
            int verticalSequence = GetVerticalSequence(matrix);
            int leftDiagonalSequence = GetLeftDiagonalSequence(matrix);
            int rightDiagonalSequence = GetRightDiagonalSequence(matrix);

            int[] results = { horizontalSequence, verticalSequence, leftDiagonalSequence, rightDiagonalSequence };
            Console.WriteLine(results.Max());
        }

        private static int GetRightDiagonalSequence(int[,] matrix)
        {
            int maxSequence = 1;

            for (int col = matrix.GetLength(1) - 2; col >= 0; col--)
            {
                int currentSequence = 1;
                int currentNum = matrix[0, col];

                int diagonal = col;

                for (int row = 1; row < matrix.GetLength(0); row++)
                {
                    diagonal++;

                    if (matrix[row, diagonal] == currentNum)
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentNum = matrix[row, diagonal];
                    }

                    if (diagonal == matrix.GetLength(1) - 1)
                    {
                        break;
                    }
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
            }

            return maxSequence;
        }

        private static int GetLeftDiagonalSequence(int[,] matrix)
        {
            int maxSequence = 1;

            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                int currentNum = matrix[row, 0];
                int currentSequence = 1;

                int diagonalRow = row;
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    diagonalRow--;
                    if (matrix[diagonalRow, col] == currentNum)
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentNum = matrix[diagonalRow, col];
                    }

                    if (col == row)
                    {
                        break;
                    }
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
            }

            return maxSequence;
        }

        private static int GetVerticalSequence(int[,] matrix)
        {
            int maxSequence = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentNum = matrix[0, col];
                int currentSequence = 1;

                for (int row = 1; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, col] == currentNum)
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentNum = matrix[row, col];
                    }
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
            }

            return maxSequence;
        }

        private static int GetHorizontalSequence(int[,] matrix)
        {
            int maxSequence = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int currentNum = matrix[row, 0];
                int currentSequence = 1;

                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == currentNum)
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentNum = matrix[row, col];
                    }
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
            }

            return maxSequence;
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