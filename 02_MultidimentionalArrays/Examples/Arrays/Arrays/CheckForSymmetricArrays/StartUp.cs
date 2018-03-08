/*
 * Check for Symmetric Array
 *
 * An array is symmetric if the first and the last elements are equal and at the same time the
 * second element and the last but one are equal as well and so on.
 *
 * Introduction to programming with C# book
 * Chapter 7 Arrays
 * http://www.introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/
 */

using System;
using System.IO;
using System.Linq;

namespace CheckForSymmetricArrays
{
    public class StartUp
    {
        /// Fake iser input -> set to the console
        /// </summary>
        private static void FakeInput()
        {
            var input = @"1 2 3 2 1";

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

            bool areSymmetric = CheckForSymmetryIntArray(arr);

            if (areSymmetric)
            {
                Console.WriteLine("The array is symmetric");
            }
            else
            {
                Console.WriteLine("Not symmetric array!");
            }
        }

        /// <summary>
        /// Checks for symmetric int array
        /// </summary>
        /// <param name="arr">Int array</param>
        /// <returns></returns>
        public static bool CheckForSymmetryIntArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}