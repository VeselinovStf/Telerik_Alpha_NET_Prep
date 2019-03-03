﻿using System;
using System.Text;
using static System.Console;

namespace AlternatingCharacters
{
    public class StartUp
    {
        public static void Main()
        {
           
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);

                WriteLine(result);
            }

        }

        static int alternatingCharacters(string s)
        {         
            var deletedCharacters = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    deletedCharacters++;
                }
            }

            return deletedCharacters;
        }

    }
}
