/*
 * Text filter
 *
 * Write a program that takes a text and a string of banned words.
 * All words included in the ban list should be replaced with asterisks "*",
 * equal to the word's length. The entries in the ban list will be separated
 * by a comma and space ", ".
 *
 */

using System;

namespace TextFilter
{
    public class StartUp
    {
        private static void Main()
        {
            string[] banListEntry = Console.ReadLine()
                .Split(new char[] { ',', ' ' }
                , StringSplitOptions
                .RemoveEmptyEntries);

            string text = Console.ReadLine();

            for (int i = 0; i < banListEntry.Length; i++)
            {
                string banWord = banListEntry[i];

                while (text.IndexOf(banWord) != -1)
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}