using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEx
{
    public class StartUp
    {
        public static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 19 };

            var odd = nums.Where(x => x % 2 == 1).ToList();

            Print(odd);
     
            var eaven = nums.Where(x => x % 2 == 0).ToList();

            Print(eaven);
            
        }

        private static void Print(List<int> odd)
        {
            odd.ForEach(x => Console.WriteLine(x));
        }
    }
}
