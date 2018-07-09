using System;
using System.Collections.Generic;

namespace Day_8_DictionariesAndMaps
{
    public class StartUp
    {
        public static void Main()
        {
            var totalNumbersCount = int.Parse(Console.ReadLine());
            Dictionary<string, string> numbers = new Dictionary<string, string>();

            for (int i = 0; i < totalNumbersCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');
                string name = parameters[0];
                string number = parameters[1];

                if (!numbers.ContainsKey(name))
                {
                    numbers[name] = number;
                }
            }

            for (int i = 0; i < totalNumbersCount; i++)
            {
                var name = Console.ReadLine();
                if (numbers.ContainsKey(name))
                {
                    var userPhone = numbers[name];
                    Console.WriteLine($"{name}={userPhone}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}