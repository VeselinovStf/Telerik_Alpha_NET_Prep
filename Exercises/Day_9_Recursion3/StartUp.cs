using System;
using System.IO;

namespace Day_9_Recursion3
{
    public class StartUp
    {
        static int factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }


            return n * factorial(n - 1);
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}