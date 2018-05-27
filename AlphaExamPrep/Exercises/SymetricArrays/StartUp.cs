using System;
using System.Linq;

namespace SymetricArrays
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int[] arr = input
                .Split(new char[] { ' ', '-', ',' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                bool isSymetric = true;
                for (int j = 0; j < arr.Length / 2; j++)
                {
                    if (arr[j] != arr[arr.Length-1 - j])
                    {
                        isSymetric = false;
                        break;
                    }
                }

                if (isSymetric)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}