/*
 * Longest Increasing Sequence
*
* Write a program that finds the length of the maximal increasing sequence in an array of N integers.
*
* http://judge.telerikacademy.com/problem/05maxincreasingseq
*
*/

using System;
using System.IO;

namespace LongestIncreasingSequence
{
    public class StartUp
    {
        private static void FakeInput()
        {
            string input = @"8
7
3
2
3
5
2
2
4";

            Console.SetIn(new StringReader(input));
        }

        private static void Main()
        {
            //FakeInput();

            int arrSize = int.Parse(Console.ReadLine());

            int[] arr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int result = 1;
            int currentResult = 1;

            for (int smallestPointer = 0; smallestPointer < arr.Length - 1; smallestPointer++)
            {
                if (arr[smallestPointer] < arr[smallestPointer + 1])
                {
                    currentResult++;
                }
                else
                {
                    currentResult = 1;
                }

                if (currentResult > result)
                {
                    result = currentResult;
                }
            }

            Console.WriteLine(result);
        }
    }
}