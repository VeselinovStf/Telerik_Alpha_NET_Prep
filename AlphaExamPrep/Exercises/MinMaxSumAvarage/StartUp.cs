using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMaxSumAvarage
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<double> numbers = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double inputNumber = double.Parse(Console.ReadLine());
                numbers.Add(inputNumber);
            }

            Console.WriteLine("min={0:F2}", numbers.Min());
            Console.WriteLine("max={0:F2}", numbers.Max());
            Console.WriteLine("sum={0:F2}", numbers.Sum());
            Console.WriteLine("avg={0:F2}", numbers.Average());
        }
    }
}