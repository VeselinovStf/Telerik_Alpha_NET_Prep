using System;
using System.Linq;

namespace Ranks
{
    public class StartUp
    {
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] ranks = new int[arraySize];

            
            int rankValue = arraySize;
            for (int i = 0; i < numbers.Length; i++)
            {
                int small = Array.IndexOf(numbers, numbers.Min());
                ranks[small] = rankValue;
                rankValue--;
                numbers[small] = int.MaxValue;
            }

            Console.WriteLine(string.Join(" ", ranks));
        }
    }
}