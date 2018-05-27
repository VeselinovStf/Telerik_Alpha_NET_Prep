using System;
using System.Collections.Generic;

namespace NotDivisableNumber
{
    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            List<int> notDivisible = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                if (i %  7 != 0 && i % 3 != 0)
                {
                    notDivisible.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ",notDivisible));
        }
    }
}