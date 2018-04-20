/*
 * Reversing an array
 *
 * In the next example we will access elements and change them using their indices.
 * The task is to print the elements in reversed order.
 *
 * Introduction to programming with C# book
 * Chapter 7 Arrays
 * http://www.introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/
 */

using System;
using System.IO;
using System.Linq;

namespace ReversingAnArray
{
    public class StartUp
    {
        /// <summary>
        /// Fake iser input -> set to the console
        /// </summary>
        private static void FakeInput()
        {
            var input = @"1 2 3 4 5 6 7 8 9 10";

            Console.SetIn(new StringReader(input));
        }

        private static void Main()
        {
            FakeInput();

            // Read and split fake input
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int arrLength = arr.Length;

            int[] reversed = new int[arrLength];

            GetElementsInReversedOrder(arr, reversed);

            WriteLineArray(reversed);

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", reversed));
        }

        /// <summary>
        /// Print array elements on separated rows
        /// </summary>
        /// <param name="reversed">Array to print</param>
        private static void WriteLineArray(int[] reversed)
        {
            for (int i = 0; i < reversed.Length; i++)
            {
                Console.WriteLine(reversed[i]);
            }
        }

        /// <summary>
        /// Gets from end elements from one array and ads them at the start of a new
        /// </summary>
        /// <param name="arr">Original array</param>
        /// <param name="reversed">Empty array to add elements from arr in reverse order</param>
        public static void GetElementsInReversedOrder(int[] arr, int[] reversed)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reversed[arr.Length - 1 - i] = arr[i];
            }
        }
    }
}