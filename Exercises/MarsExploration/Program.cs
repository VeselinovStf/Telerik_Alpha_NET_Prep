using System;

namespace MarsExploration
{
    class Program
    {
        static int marsExploration(string s)
        {
            int count = 0;

            string correct = "SOS";

            for (int i = 0; i < s.Length; i+= 3)
            {
                var testMessage = s.Substring(i, 3);
                for (int j = 0; j < correct.Length; j++)
                {
                    if (correct[j] != testMessage[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            int result = marsExploration(s);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
