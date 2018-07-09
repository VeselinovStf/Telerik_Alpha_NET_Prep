using System;
using System.IO;

namespace WeightedUniformStrings
{
    internal class Program
    {
        private static string[] weightedUniformStrings(string s, int[] queries)
        {
            string[] result = new string[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                var queryValue = queries[i];
            }

            return result;
        }

        private static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("result.txt");

            string s = Console.ReadLine();

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            int[] queries = new int[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            string[] result = weightedUniformStrings(s, queries);

            textWriter.WriteLine(string.Join("\n", result));
            Console.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}