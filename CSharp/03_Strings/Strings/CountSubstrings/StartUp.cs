/*
 * Count substring occurrences
 *
 * Write a program to find how many times a given string appears in a given text as substring.
 * The text is given at the first input line. The search string is given at the second input line.
 * The output is an integer number. Please ignore the character casing.
 * Overlapping between occurrences is allowed
 *
 */

using System;
using System.IO;

namespace CountSubstrings
{
    public class StartUp
    {
        public static void FakeInput()
        {
            string input = @"Welcome to the Software University (SoftUni)! Welcome to programming. Programming is wellness for developers, said Maxwell.
wel";

            Console.SetIn(new StringReader(input));
        }

        private static void Main()
        {
            // FakeInput();

            string inputText = Console.ReadLine();
            string searchWord = Console.ReadLine();

            int count = 0;
            int startIndex = 0;

            while (inputText.IndexOf(searchWord, startIndex, StringComparison.OrdinalIgnoreCase) != -1)
            {
                count++;
                startIndex = inputText.IndexOf(searchWord, startIndex, StringComparison.OrdinalIgnoreCase) + 1;
            }

            Console.WriteLine(count);
        }
    }
}