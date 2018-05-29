﻿using System;
using System.Numerics;

namespace CalculateAgain
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            while (n - k >= 1)
            {
                result *= n;
                n--;
            }

            Console.WriteLine(result);
        }
    }
}