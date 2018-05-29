using System;
using System.IO;
using System.Linq;

namespace _03_Hops
{
    public class StartUp
    {
        public static void FakeInput()
        {
            string input = @"2, -4, -6, 10, 2, 1, 5
3 
3, 2, -1
2, 2, -4 
2, -3";

            Console.SetIn(new StringReader(input));
        }

        public static void Main()
        {
           FakeInput();


            string input = Console.ReadLine();

            int[] carrotsField = GetInputToIntArray(input);

            int[] tempCarotField = new int[carrotsField.Length];

            Array.Copy(carrotsField, tempCarotField, tempCarotField.Length);
            int directionsToTry = int.Parse(Console.ReadLine());

            int maxSum = int.MinValue;

            for (int i = 0; i < directionsToTry; i++)
            {

                input = Console.ReadLine();

                int[] directions = GetInputToIntArray(input);

                int currentSum = CalculateEatenCarrots(directions, carrotsField, tempCarotField);

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            Console.WriteLine(maxSum);
        }

        private static int CalculateEatenCarrots(int[] directions, int[] carrotsField, int[] tempCarotField)
        {
            int sum = 0;

            int passedElement = int.MinValue;

            Array.Copy(carrotsField, tempCarotField, tempCarotField.Length);

            sum += tempCarotField[0];
            tempCarotField[0] = passedElement;

            int jumpIndex = 0;

            for (int i = 0; i < directions.Length; i++)
            {
                int currentDirection = directions[i];

                jumpIndex += currentDirection;

                if (jumpIndex > tempCarotField.Length - 1 ||
                        jumpIndex < 0 || tempCarotField[jumpIndex] == passedElement)
                {
                    break;
                }
                else
                {
                    sum += tempCarotField[jumpIndex];
                    tempCarotField[jumpIndex] = passedElement;
                    if (i == directions.Length - 1) i = -1;
                }
            }

            return sum;
        }

        private static int[] GetInputToIntArray(string input)
        {
            int[] output = input
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return output;
        }
    }
}
