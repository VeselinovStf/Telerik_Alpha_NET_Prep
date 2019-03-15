using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockAndTheValidString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
           
            string s = Console.ReadLine();

            string result = isValid(s);

            Console.WriteLine(result);
        }

        public static string isValid(string s)
        {
            var yesResult = "YES";
            var noResult = "NO";

            if (s.Length < 0)
            {
                return noResult;
            }

            if (s.Length <= 3)
            {
                return yesResult;
            }
           

            var occurredLetters = new Dictionary<char, int>();
            var maxAccurence = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var current = s[i];

                if (!occurredLetters.ContainsKey(current))
                {
                    occurredLetters[current] = 1;
                }
                else
                {
                    occurredLetters[current]++;
                    if (occurredLetters[current] >= maxAccurence)
                    {
                        maxAccurence = occurredLetters[current];
                    }
                }
            }

            var biggestNumber = occurredLetters.Max(v => v.Value);

            var biggestOccurenceNumberCount = occurredLetters
                .Where(n => n.Value == biggestNumber).ToList().First().Value;

            var smallestNumber = occurredLetters.Min(v => v.Value);

            var smallestOccurenceNumberCount = occurredLetters
                 .Where(n => n.Value == smallestNumber).ToList().First().Value;



        }
    }
}
