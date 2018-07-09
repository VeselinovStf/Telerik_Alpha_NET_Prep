using System;
using System.IO;

namespace CamelCase
{
    public class StartUp
    {
        public static void FakeInput()
        {
            string input = @"saveChangesInTheEditor";

            Console.SetIn(new StringReader(input));
        }

        private static int camelcase(string s)
        {
            int wordsCount = 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (char.IsUpper(s[i]) && char.IsLower(s[i + 1]))
                {
                    wordsCount++;
                }
            }

            return wordsCount;
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("result.txt");

            FakeInput();
            string s = Console.ReadLine();

            int result = camelcase(s);

            textWriter.WriteLine(result);
            Console.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}