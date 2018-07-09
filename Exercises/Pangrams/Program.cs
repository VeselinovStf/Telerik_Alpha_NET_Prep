using System;

namespace Pangrams
{
    internal class Program
    {
        private static string pangrams(string s)
        {
            string[] alpha = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            int count = 0;

            for (int i = 0; i < alpha.Length; i++)
            {
                if (s.ToLower().Contains(alpha[i]))
                {
                    count++;
                }
            }

            if (count == alpha.Length)
            {
                return "pangram";
            }
            else
            {
                return "not pangram";
            }
        }

        private static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = pangrams(s);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}