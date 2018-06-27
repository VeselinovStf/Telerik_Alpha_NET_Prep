using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfTwoStacks
{
    public class StartUp
    {
        /// <summary>
        /// TODO
        /// </summary>

        private static int twoStacks(int x, int[] a, int[] b)
        {
            int firstColMaxBlocksIndex = GetMaxColl(a, x);
            int secondColMaxBlocksIndex = GetMaxColl(b, x);

            if (firstColMaxBlocksIndex == 0)
            {
                if (secondColMaxBlocksIndex == 0)
                {
                    return 0;
                }
                else
                {
                    return secondColMaxBlocksIndex;
                }
            }
            if (secondColMaxBlocksIndex == 0)
            {
                if (firstColMaxBlocksIndex == 0)
                {
                    return 0;
                }
                else
                {
                    return firstColMaxBlocksIndex;
                }
            }

            int firstIndex = 0;
            int secondIndex = 0;
            int totalBlocks = 0;
            int currentSum = 0;

            while (firstIndex != firstColMaxBlocksIndex || secondIndex != secondColMaxBlocksIndex)
            {
                var firstSecondSum = a[firstIndex] + b[secondIndex];
                if (firstSecondSum < x)
                {
                    totalBlocks += 2;
                    currentSum = firstSecondSum;
                    firstIndex++;
                    secondIndex++;
                }
                if (firstIndex > firstColMaxBlocksIndex)
                {
                }
            }

            return totalBlocks;
        }

        private static int GetMaxColl(int[] a, int x)
        {
            int max = 0;
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                if (sum < x)
                {
                    max++;
                }
            }

            return max;
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            int g = Convert.ToInt32(Console.ReadLine());

            for (int gItr = 0; gItr < g; gItr++)
            {
                string[] nmx = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nmx[0]);

                int m = Convert.ToInt32(nmx[1]);

                int x = Convert.ToInt32(nmx[2]);

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;

                int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
                ;
                int result = twoStacks(x, a, b);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}