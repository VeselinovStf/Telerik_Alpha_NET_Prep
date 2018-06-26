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
            if (h1.Length == 0 || h2.Length == 0 || h3.Length == 0)
            {
                return 0;
            }

            if (h1.Sum() == h2.Sum() && h1.Sum() == h3.Sum())
            {
                return h1.Sum();
            }

            Stack<int> firstStack = new Stack<int>();
            Stack<int> secondStack = new Stack<int>();
            Stack<int> thirdStack = new Stack<int>();

            FillStack(firstStack, h1);
            FillStack(secondStack, h2);
            FillStack(thirdStack, h3);

            var firstSum = firstStack.Sum();
            var secondSum = secondStack.Sum();
            var thirdSum = thirdStack.Sum();
            while (true)
            {
                var firstValue = firstStack.Peek();
                var secondValue = secondStack.Peek();
                var thirdValue = thirdStack.Peek();

                if (firstValue < secondValue && firstValue < thirdValue)
                {
                    //first value is lesser
                    firstStack.Pop();

                    firstSum = firstStack.Sum();
                    secondSum = secondStack.Sum();
                    thirdSum = thirdStack.Sum();

                    if (firstSum == secondSum && firstSum == thirdSum)
                    {
                        return firstSum;
                    }
                    else
                    {
                        secondStack.Pop();
                        thirdStack.Pop();
                    }
                }
                else if (secondValue < thirdValue && secondValue < firstValue)
                {
                    //second is lesser
                    secondStack.Pop();

                    firstSum = firstStack.Sum();
                    secondSum = secondStack.Sum();
                    thirdSum = thirdStack.Sum();

                    if (firstSum == secondSum && firstSum == thirdSum)
                    {
                        return firstSum;
                    }
                    else
                    {
                        firstStack.Pop();
                        thirdStack.Pop();
                    }
                }
                else if (thirdValue < secondValue && thirdValue < firstValue)
                {
                    //third value is lesser
                    thirdStack.Pop();

                    firstSum = firstStack.Sum();
                    secondSum = secondStack.Sum();
                    thirdSum = thirdStack.Sum();

                    if (firstSum == secondSum && firstSum == thirdSum)
                    {
                        return firstSum;
                    }
                    else
                    {
                        secondStack.Pop();
                        firstStack.Pop();
                    }
                }
                else
                {
                    firstStack.Pop();
                    secondStack.Pop();
                    thirdStack.Pop();

                    if (firstSum == secondSum && firstSum == thirdSum)
                    {
                        return firstSum;
                    }
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