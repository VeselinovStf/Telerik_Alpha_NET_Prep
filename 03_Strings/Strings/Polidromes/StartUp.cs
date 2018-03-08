/*
 * Palindromes
 *
 * Write a program that extracts from a given text all palindromes,
 * e.g. ABBA, lamal, exe and prints them on the console on a single line,
 * separated by comma and space. Use spaces, commas, dots, question marks
 * and exclamation marks as word delimiters. Print only unique palindromes,
 * sorted lexicographically.
 *
 */

using System;
using System.Collections.Generic;

namespace Polidromes
{
    public class StartUp
    {
        private static void Main()
        {
            List<string> polidromes = new List<string>();

            string[] splitText = Console.ReadLine()
                .Split(
                    new char[] { ' ', '!', '?', ',', ';', ':', '.' }
                , StringSplitOptions
                .RemoveEmptyEntries);

            for (int i = 0; i < splitText.Length; i++)
            {
                string currentWord = splitText[i];

                bool isPolidrome = PolidromeCompare(currentWord);

                if (isPolidrome)
                {
                    if (!polidromes.Contains(currentWord))
                    {
                        polidromes.Add(currentWord);
                    }
                }
            }

            polidromes.Sort();
            Console.WriteLine(string.Join(", ", polidromes));
        }

        private static bool PolidromeCompare(string currentWord)
        {
            for (int i = 0; i < currentWord.Length / 2; i++)
            {
                if (currentWord[i] != currentWord[currentWord.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}