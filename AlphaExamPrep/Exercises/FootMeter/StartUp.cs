using System;

namespace FootMeter
{
    public class StartUp
    {
        public static void Main()
        {
            int miles = int.Parse(Console.ReadLine());
            int meters = miles * 1609;

            Console.WriteLine(meters);
        }
    }
}