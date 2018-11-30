using System;
using System.Collections.Generic;

namespace DynamicArray
{
    class Program
    {
        static int[] dynamicArray(int n, int[][] queries)
        {
            List<List<int>> seq = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                seq.Add(new List<int>());
            }
            var lastAnswere = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < queries.Length; i++)
            {
                var row = queries[i];

                var parameter = row[0];
                var x = row[1];
                var number = row[2];
                var sequence = GetNewValue(x, lastAnswere, n);

                if (parameter == 1)
                {

                    seq[sequence].Add(number);

                }
                else
                {

                    var inIndex = number % seq[sequence].Count;
                    lastAnswere = seq[sequence][inIndex];

                    result.Add(lastAnswere);



                }


            }

            return result.ToArray();

        }

        private static int GetNewValue(int x, int lastAnswere, int n)
        {
            return ((x ^ lastAnswere) % n);
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nq[0]);

            int q = Convert.ToInt32(nq[1]);

            int[][] queries = new int[q][];

            for (int queriesRowItr = 0; queriesRowItr < q; queriesRowItr++)
            {
                queries[queriesRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            int[] result = dynamicArray(n, queries);
            Console.WriteLine(string.Join("\n", result));
            //textWriter.WriteLine(string.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
