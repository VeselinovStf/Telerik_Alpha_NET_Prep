using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crossword
{
    public class StartUp
    {
        public static List<string> words = new List<string>();

        public static void Main()
        {
            int[] initialSize = SplitInputToIntArray();

            char[,] matrix = new char[initialSize[0], initialSize[1]];

            FillMatrixFromInput(matrix, initialSize[0]);

            //Find the smaller lexicograph word that is >= 2 letters


            //Horizontal word
           FindHorizontaltWords(matrix);
            // Vertical Word
            FindVerticalWords(matrix);

            string finalWord = words.OrderBy(x => x).ThenBy(x => x.Length).First();
            Console.WriteLine(finalWord);

        }

        private static void FindVerticalWords(char[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                StringBuilder currentRowWord = new StringBuilder();


                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, col] != '#')
                    {
                        currentRowWord.Append(matrix[row, col]);
                    }
                    else
                    {
                        if (currentRowWord.Length > 1)
                        {
                            words.Add(currentRowWord.ToString());
                        }
                        currentRowWord = new StringBuilder();
                    }
                }

                if (currentRowWord.Length > 1)
                {
                    words.Add(currentRowWord.ToString());
                }
            }
        }

        private static void FindHorizontaltWords(char[,] matrix)
        {
            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                StringBuilder currentRowWord = new StringBuilder();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] != '#')
                    {
                        currentRowWord.Append(matrix[row, col]);
                    }
                    else
                    {
                        if (currentRowWord.Length > 1)
                        {
                            words.Add(currentRowWord.ToString());
                        }
                        currentRowWord = new StringBuilder(); ;
                    }
                }

                if (currentRowWord.Length > 1)
                {
                    words.Add(currentRowWord.ToString());
                }
            }

           
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