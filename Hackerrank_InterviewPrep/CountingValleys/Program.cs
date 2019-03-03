using System;

namespace CountingValleys
{
    public class Program
    {
        // Complete the countingValleys function below.
        private static int countingValleys(int n, string s)
        {
            var totalValleys = 0;
            var lang = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var dirrection = s[i];

                if (dirrection == 'U')
                {
                    lang++;
                }
                else
                {
                    lang--;
                }

                if (lang == 0 && dirrection == 'U')
                {
                    totalValleys++;
                }
            }

            return totalValleys;
        }

        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);
        }
    }
}