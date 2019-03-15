using System;

namespace ArrayManipulation
{
    public class StartUp
    {
        //TODO: OPTIMISATION
        public static void Main()
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);

            Console.WriteLine(result);

            
        }

        private static long arrayManipulation(int n, int[][] queries)
        {
            long[] results = new long[n];
            long max = long.MinValue;

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                var query = queries[i];

                var value = query[query.Length - 1];
                var startIndex = query[0] -1;
                var endIndex = query[1]-1;

                for (int j = startIndex; j <= endIndex; j++)
                {
                    results[j] += value;                  
                    var resultValue = results[j];
                    if (resultValue > max)
                    {
                        max = resultValue;
                    }
                }
            }

            return max;
        }
    }
}
