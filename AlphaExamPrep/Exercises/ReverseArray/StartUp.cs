using System;
using System.Linq;

namespace ReverseArray
{
    public class StartUp
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ', '-', ',' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join(", ",arr.Reverse()));
        }
    }
}