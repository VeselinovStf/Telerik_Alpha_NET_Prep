/* Since he wants to be more than a regular horse, he iterates the matrices using the moves of the knights in chess as follows:
* At each turn, he can jump to one of the 8 horse moves. He tries to jump to the topmost, leftmost cell of of these cells.
* If all the 8 positions are taken (he already jumped there), he restarts him jumping from the leftmost, topmost free cell
* At each turn he leaves a number, to indicate he has been there.
* By given the size of the matrix, print the cells of Koci.
* 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsePath
{
    public class StartUp
    {
        public static void Main()
        {
            // int initialSize = int.Parse(Console.ReadLine());
            int initialSize = 5;

            int[,] matrix = new int[initialSize, initialSize];

            int[] rowsMoves = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] colsMoves = { -1, 1, -2, 2, -2, 2, -1, 1 };

            int counter = 1;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    int row = r;
                    int col = c;

                    while (matrix[row,col] == 0)
                    {
                        matrix[row, col] = counter;
                        counter++;
                        for (int dirrection = 0; dirrection < rowsMoves.Length; dirrection++)
                        {
                            int nextRow = row + rowsMoves[dirrection];
                            int nextCol = col + colsMoves[dirrection];

                            if (nextRow < 0 || nextRow >= matrix.GetLength(0) ||
                                nextCol < 0 || nextCol >= matrix.GetLength(1) 
                                )
                            {
                                continue;
                            }

                            if (matrix[nextRow, nextCol] != 0)
                            {
                                continue;
                            }
                         
                            row = nextRow;
                            col = nextCol;
                            break;
                        }
                    }
                }

            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write((matrix[row, col] + " "));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
