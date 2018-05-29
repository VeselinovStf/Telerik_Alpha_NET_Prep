using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Counting
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            BigInteger number = BigInteger.Parse(Regex.Match(input, @"\d+").Value);

            for (BigInteger i = number + 1; i <= number + 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}