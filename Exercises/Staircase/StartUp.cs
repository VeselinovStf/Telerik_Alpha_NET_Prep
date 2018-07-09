using System;

namespace Staircase
{
    public class StartUp
    {
        private static void staircase(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine(new string(' ', n - row) + new string('#', row));
            }
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}