using System;
using System.Collections.Generic;
using System.Linq;

namespace MissCat
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfCats = int.Parse(Console.ReadLine());

            int[] cats = new int[numberOfCats];

            for (int i = 0; i < numberOfCats; i++)
            {
                cats[i] = int.Parse(Console.ReadLine());
            }

            //Array.Sort(cats);

            int result = GetRepCount(cats);
            Console.WriteLine(result);
        }

        private static int GetRepCount(int[] cats)
        {
            Dictionary<int, int> catDups = new Dictionary<int, int>();

            for (int i = 0; i < cats.Length; i++)
            {
                int currentCat = cats[i];

                if (!catDups.ContainsKey(currentCat))
                {
                    catDups[currentCat] = 1;
                }
                else
                {
                    catDups[currentCat]++;
                }
            }

            return catDups.OrderByDescending(x => x.Value).First().Key;
        }
    }
}