/*
 * Max Sum of K elements
 *
 * Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.
 *
 * http://judge.telerikacademy.com/problem/06maxksum
 */

using System;
using System.IO;
using System.Linq;

namespace MaxSumOfKElements
{
    public class StartUp
    {
        private static void FakeInput()
        {
            string input = @"8
                3
                3
                2
                3
                -2
                5
                4
                2
                7";

            Console.SetIn(new StringReader(input));
        }

        private static void Main()
        {
            //FakeInput();

            int sizeOfArrayN = int.Parse(Console.ReadLine());
            int maximalKSumElements = int.Parse(Console.ReadLine());

            int[] arr = new int[sizeOfArrayN];

            for (int i = 0; i < sizeOfArrayN; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arr.OrderByDescending(x => x).Take(maximalKSumElements).Sum());
        }
    }
}