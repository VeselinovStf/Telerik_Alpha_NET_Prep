/*
 * Character Multiplier
 *
 * Create a method that takes two strings as arguments and returns the
 * sum of their character codes multiplied (multiply str1.charAt (0) with str2.charAt (0)
 * and add to the total sum). Then continue with the next two characters.
 * If one of the strings is longer than the other, add the remaining character
 * codes to the total sum without multiplication.
 *
 */

using System;

namespace CharacterMultiplier
{
    public class StartUp
    {
        private static void Main()
        {
            string[] inputText = Console.ReadLine()
                .Split(' ');

            string firstWord = inputText[0];
            string secondWord = inputText[1];

            int smallestLength = Math.Min(firstWord.Length, secondWord.Length);

            int sum = 0;

            string leftLetters = string.Empty;

            if (firstWord.Length > secondWord.Length)
            {
                leftLetters = firstWord.Substring(secondWord.Length, firstWord.Length - secondWord.Length);
            }

            if (firstWord.Length < secondWord.Length)
            {
                leftLetters = secondWord.Substring(firstWord.Length, secondWord.Length - firstWord.Length);
            }

            for (int i = 0; i < smallestLength; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            for (int i = 0; i < leftLetters.Length; i++)
            {
                sum += leftLetters[i];
            }

            Console.WriteLine(sum);
        }
    }
}