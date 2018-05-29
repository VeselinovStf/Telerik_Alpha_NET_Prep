using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequent
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> nums = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!nums.ContainsKey(number))
                {
                    nums[number] = 0;
                }
                nums[number]++;
            }

            var mostFrequent = nums.OrderByDescending(x => x.Value).First();
            Console.WriteLine("{0} ({1} times)",mostFrequent.Key, mostFrequent.Value);
        }
    }
}