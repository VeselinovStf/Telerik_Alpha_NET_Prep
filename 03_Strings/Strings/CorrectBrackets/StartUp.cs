/*
 * Correct brackets
 *
 * Write a program to check if in a given expression the ( and ) brackets are put correctly.
 *
 * http://bgcoder.com/Contests/Practice/Index/320#1
 *
 */

using System;

namespace CorrectBrackets
{
    public class StartUp
    {
        private static void Main()
        {
            string expresion = Console.ReadLine();

            int bracketsCounter = 0;

            for (int i = 0; i < expresion.Length; i++)
            {
                char currentElement = expresion[i];

                if (currentElement == '(')
                {
                    bracketsCounter++;
                }
                if (currentElement == ')')
                {
                    bracketsCounter--;
                }
            }

            if (bracketsCounter == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}