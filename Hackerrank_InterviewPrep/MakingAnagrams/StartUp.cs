using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MakingAnagrams
{
    public class StartUp
    {
        public static void Main()
        {
            string a = ReadLine();

            string b = ReadLine();

            int res = makeAnagram(a, b);

            WriteLine(res);
         
        }

        public static int makeAnagram(string a, string b)
        {
            int totalDeleted = 0;
            StringBuilder bStr = new StringBuilder(b);

            for (int i = 0; i < a.Length; i++)
            {
                var currentLetter = a[i];
                
                if (bStr.ToString().Contains(currentLetter))
                {
                    bStr.Remove(bStr.ToString().IndexOf(currentLetter), 1);
                }
                else
                {
                    totalDeleted++;
                }
            }

            totalDeleted += bStr.Length;

            return totalDeleted;
        }
    }
}
