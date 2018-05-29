using System;
using System.Collections.Generic;
using System.Linq;

namespace SortThreeNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x)));
        }
    }
}