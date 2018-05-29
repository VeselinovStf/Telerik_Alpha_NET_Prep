using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreeGroups
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', '-', ',' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> zeroGroup = new List<int>();
            List<int> oneGroup = new List<int>();
            List<int> twoGroup = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];

                if (num % 3 == 0)
                {
                    zeroGroup.Add(num);
                }
                if (num % 3 == 1)
                {
                    oneGroup.Add(num);
                }
                if (num % 3 == 2)
                {
                    twoGroup.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ",zeroGroup));
            Console.WriteLine(string.Join(" ",oneGroup));
            Console.WriteLine(string.Join(" ",twoGroup));
        }
    }
}