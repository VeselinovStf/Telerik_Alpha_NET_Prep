using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Day_28_RegExPatternsIntroDatabases
{
    public class StartUp
    {
        public static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            List<string> names = new List<string>();

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                Regex r = new Regex("@gmail.com");

                if (r.IsMatch(emailID))
                {
                    names.Add(firstName);
                }
            }

            string[] result = new string[names.Count];
            for (int i = 0; i < names.Count; i++)
            {
                result[i] = names[i];
            }
            Array.Sort(result);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}