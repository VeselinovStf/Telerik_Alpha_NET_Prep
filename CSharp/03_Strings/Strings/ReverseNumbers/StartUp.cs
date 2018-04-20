/*
 * Reverse Number
*
* Write a method that reverses the digits of a given decimal number.
*
* http://judge.telerikacademy.com/problem/07reversenumber
*
*/

using System;
using System.Text;

namespace ReverseNumbers
{
    public class StartUp
    {
        private static void Main()
        {
            string numberAsString = Console.ReadLine();

            string reversedNumber = ReversString(numberAsString);

            Console.WriteLine(reversedNumber);
        }

        private static string ReversString(string numberAsString)
        {
            StringBuilder reversed = new StringBuilder();

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                reversed.Append(numberAsString[i]);
            }

            return reversed.ToString();
        }
    }
}