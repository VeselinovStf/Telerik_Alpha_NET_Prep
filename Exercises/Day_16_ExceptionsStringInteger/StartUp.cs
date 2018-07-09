using System;

namespace Day_16_ExceptionsStringInteger
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine(value);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}