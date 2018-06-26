using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    //    You have an empty sequence, and you will be given queries.Each query is one of these three types:
    //1 x  -Push the element x into the stack.
    //2    -Delete the element present at the top of the stack.
    //3    -Print the maximum element in the stack.
    public class StartUp
    {
        public static Stack<long> elements = new Stack<long>();
        public static Stack<long> maximum = new Stack<long>();

        public static void Main()
        {
            var inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                var input = Console.ReadLine();
                var parameters = input.Split(' ').Select(long.Parse).ToArray();
                var comand = (int)parameters[0];

                switch (comand)
                {
                    case 1:
                        long value = parameters[1];
                        Insert(value);
                        break;

                    case 2:
                        Remove();

                        break;

                    case 3:
                        var max = maximum.Peek();
                        Console.WriteLine(max);
                        break;

                    default:
                        break;
                }
            }
        }

        private static void Remove()
        {
            if (elements.Count != 0)
            {
                maximum.Pop();
                elements.Pop();
            }
        }

        private static void Insert(long value)
        {
            if (elements.Count == 0)
            {
                elements.Push(value);
                maximum.Push(value);
            }
            else
            {
                var a = maximum.Peek();
                maximum.Push(Math.Max(a, value));
                elements.Push(value);
            }
        }
    }
}