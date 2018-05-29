using System;
using System.Linq;

namespace _3DSlices
{
    public class StartUp
    {
        private static int j;

        public static void Main()
        {
            string parameters = Console.ReadLine();
            int[] sizes = SplitInputToIntArray(parameters,' ');

            int width = sizes[0];
            int height = sizes[1];
            int depth = sizes[2];

            int[,,] cube = new int[width, height, depth];
            int cubeSum = 0;

            for (int h = 0; h < height; h++)
            {
                string input = Console.ReadLine();
                string[] splitInput = SplitInputToStringArray(input,'|');

                for (int d = 0; d < depth; d++)
                {                 
                    int[] row = SplitInputToIntArray(splitInput[d], ' ');

                    for (int w = 0; w < width; w++)
                    {
                        int currentNum = row[w];
                        cube[w, h, d] = currentNum;
                        cubeSum += currentNum;
                    }
                }
            }

            int allSlices = 0;
            allSlices += FindWidthSlices(cube, cubeSum);
            allSlices += FindHeightSlices(cube, cubeSum);
            allSlices += FindDepthSlices(cube, cubeSum);

            Console.WriteLine(allSlices);  

        }

        private static int FindDepthSlices(int[,,] cube, int cubeSum)
        {
            int slicesSum = 0;
            int numberOfSlices = 0;

            for (int d = 0;d < cube.GetLength(2) - 1; d++)
            {
                for (int h = 0;h < cube.GetLength(1); h++)
                {
                    for (int w = 0; w < cube.GetLength(0); w++)
                    {
                        slicesSum += cube[w, h, d];
                    }
                }

                if (slicesSum == cubeSum / 2)
                {
                    numberOfSlices++;
                }
            }

            return numberOfSlices;
        }

        private static int FindHeightSlices(int[,,] cube, int cubeSum)
        {
            int slicesSum = 0;
            int numberOfSlices = 0;

            for (int h = 0;h < cube.GetLength(1) - 1;h++)
            {
                for (int w = 0; w < cube.GetLength(0); w++)
                {
                    for (int d = 0; d < cube.GetLength(2); d++)
                    {
                        slicesSum += cube[w, h, d];
                    }
                }

                if (slicesSum == cubeSum / 2)
                {
                    numberOfSlices++;
                }
            }

            return numberOfSlices;
        }

        private static int FindWidthSlices(int[,,] cube, int cubeSum)
        {
            int slicesSum = 0;
            int numberOfSlices = 0;

            for (int w = 0; w < cube.GetLength(0)-1; w++)
            {
                for (int h = 0; h < cube.GetLength(1); h++)
                {
                    for (int d = 0; d < cube.GetLength(2); d++)
                    {
                        slicesSum += cube[w, h, d];
                    }
                }

                if (slicesSum == cubeSum / 2)
                {
                    numberOfSlices++;
                }
            }

            return numberOfSlices;
        }

        private static string[] SplitInputToStringArray(string input, char separator)
        {
            return input
                .Split(new char[] { separator }
                , StringSplitOptions
                .RemoveEmptyEntries);
        }

        private static int[] SplitInputToIntArray(string parameters, char separator)
        {
            return parameters
                .Split(new char[] { separator }
                ,StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}