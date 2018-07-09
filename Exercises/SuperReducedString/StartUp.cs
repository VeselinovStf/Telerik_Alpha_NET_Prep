using System;
using System.IO;
using System.Text;

namespace SuperReducedString
{
    public class StartUp
    {
        public static string super_reduced_string(string s)
        {
            var currentIndex = 0;
            var currentNextIndex = 1;

            var sb = new StringBuilder();
            sb.Append(s);

            while (true)
            {
                if (currentNextIndex >= sb.Length)
                {
                    break;
                }

                var current = sb[currentIndex];
                var next = sb[currentNextIndex];

                if (current == next)
                {
                    sb.Remove(currentIndex, 2);
                    currentIndex = 0;
                    currentNextIndex = 1;
                }
                else
                {
                    currentIndex++;
                    currentNextIndex++;
                }

                if (sb.Length == 0)
                {
                    return "Empty String";
                }
            }

            return sb.ToString();
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("result.txt");

            string s = Console.ReadLine();

            string result = super_reduced_string(s);

            textWriter.WriteLine(result);
            Console.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}