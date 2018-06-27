using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EqualStacks
{
    public class StartUp
    {
        /// <summary>
        /// TODO !! FINISH THIS
        /// </summary>

        private static int equalStacks(int[] h1, int[] h2, int[] h3)
        {
            var sum1 = h1.Sum();
            var sum2 = h2.Sum();
            var sum3 = h3.Sum();

            int top1 = 0, top2 = 0, top3 = 0;
            while (true)
            {
                if (h1.Length == top1 || h2.Length == top2 || h3.Length == top3)
                {
                    return 0;
                }

                if (sum1 == sum2 && sum2 == sum3)
                {
                    return sum1;
                }

                if (sum1 >= sum2 && sum1 >= sum3)
                {
                    sum1 -= h1[top1++];
                }
                else if (sum2 >= sum3 && sum2 >= sum3)
                {
                    sum2 -= h2[top2++];
                }
                else if (sum3 >= sum2 && sum3 >= sum1)
                {
                    sum3 -= h3[top3++];
                }
            }
        }

        private static void FillStack(Stack<int> stack, int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                stack.Push(arr[i]);
            }
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            string[] n1N2N3 = Console.ReadLine().Split(' ');

            int n1 = Convert.ToInt32(n1N2N3[0]);

            int n2 = Convert.ToInt32(n1N2N3[1]);

            int n3 = Convert.ToInt32(n1N2N3[2]);

            int[] h1 = Array.ConvertAll(Console.ReadLine().Split(' '), h1Temp => Convert.ToInt32(h1Temp))
            ;

            int[] h2 = Array.ConvertAll(Console.ReadLine().Split(' '), h2Temp => Convert.ToInt32(h2Temp))
            ;

            int[] h3 = Array.ConvertAll(Console.ReadLine().Split(' '), h3Temp => Convert.ToInt32(h3Temp))
            ;
            int result = equalStacks(h1, h2, h3);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}