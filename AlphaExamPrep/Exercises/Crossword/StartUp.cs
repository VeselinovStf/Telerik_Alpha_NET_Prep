using System;
using System.Linq;
using System.Text;

namespace Crossword
{
    public class StartUp
    {
        public static void Main()
        {
            int[] initialSize = SplitInputToIntArray();

            char[,] matrix = new char[initialSize[0], initialSize[1]];

            FillMatrixFromInput(matrix, initialSize[0]);

            //Find the smaller lexicograph word that is >= 2 letters

            string finalWord = string.Empty;

            //Horizontal word
            string horizontalBestWord = FindHorizontalBestWord(matrix);


            // Vertical Word
        }

        private static string FindHorizontalBestWord(char[,] matrix)
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                StringBuilder currentRowWord = new StringBuilder();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    //TODO
                }
            }

            return result.ToString();
        }

        private static void FillMatrixFromInput(char[,] matrix, int initialSize)
        {
            for (int i = 0; i < initialSize; i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
        }

        private static int[] SplitInputToIntArray() => Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    }
}