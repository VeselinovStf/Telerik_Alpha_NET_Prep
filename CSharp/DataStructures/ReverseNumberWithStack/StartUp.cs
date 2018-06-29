using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberWithStack
{
    public class StartUp
    {
        public static void Main()
        {
            Stack<int> numbers =
                new Stack<int>(
                    Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    );

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}