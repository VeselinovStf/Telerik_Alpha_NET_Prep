using System;

namespace Day_19_Interfaces
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}