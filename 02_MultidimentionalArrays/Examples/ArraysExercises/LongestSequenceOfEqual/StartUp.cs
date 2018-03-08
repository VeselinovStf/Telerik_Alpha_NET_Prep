/*
 * Longest Sequence of Equal
 * Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
 *
 * http://judge.telerikacademy.com/problem/04maxequalseq
 *
 */

using System;
using System.IO;

namespace LongestSequenceOfEqual
{
    public class StartUp
    {
        private static void FakeInput()
        {
            string input = @"10
                              2
                              1
                              1
                              2
                              3
                              3
                              2
                              2
                              2
                              1";

            Console.SetIn(new StringReader(input));
        }

        private static void Main()
        {
            //FakeInput();

            int sizeOfArrayN = int.Parse(Console.ReadLine());

            int[] arr = new int[sizeOfArrayN];

            for (int i = 0; i < sizeOfArrayN; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int longestSeuence = 1;

            for (int searchStartPointer = 0; searchStartPointer < arr.Length - 1; searchStartPointer++)
            {
                int currentSequence = 1;

                for (int nextPointer = searchStartPointer + 1; nextPointer < arr.Length; nextPointer++)
                {
                    if (arr[searchStartPointer] == arr[nextPointer])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentSequence > longestSeuence)
                {
                    longestSeuence = currentSequence;
                }
            }

            Console.WriteLine(longestSeuence);
        }
    }
}