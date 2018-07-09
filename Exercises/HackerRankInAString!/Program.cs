using System;
using System.IO;

namespace HackerRankInAString_
{
    internal class Program
    {
        public static void FakeInput()
        {
            string input = @"2
hereiamstackerrank
hackerworld";

            Console.SetIn(new StringReader(input));
        }

        private static string hackerrankInString(string s)
        {
            string yesResult = "YES";
            string noResult = "NO";
            string hackerrank = "hackerrank";

            if (s.Length < hackerrank.Length)
            {
                return noResult;
            }

            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char searchLetter = hackerrank[index];
                var currentLetter = s[i];

                if (index < hackerrank.Length && currentLetter == hackerrank[index])
                {
                    index++;
                }
            }

            if (index == hackerrank.Length)
            {
                return yesResult;
            }
            else
            {
                return noResult;
            }
        }

        private static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            FakeInput();
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = hackerrankInString(s);

                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}