using System;
using System.Linq;

namespace JoroTheRabbit
{
    public class StartUp
    {
        public static void Main()
        {
            int[] terrain = Console.ReadLine()
                .Split(new char[] { ',', ' ' },
                StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

         int maximumVisitedPosition = 0;

            for (int startPoint = 0; startPoint < terrain.Length; startPoint++)
            {
                for (int step = 1; step < terrain.Length; step++)
                {
                    int currentPath = 1;
                    int index = startPoint;
                    int next = (index + step) % terrain.Length;

                    while (terrain[index] < terrain[next] && next != startPoint)
                    {
                        currentPath++;
                        index = next;
                        next = (index + step) % terrain.Length;
                    }

                    if (currentPath > maximumVisitedPosition)
                    {
                        maximumVisitedPosition = currentPath;
                    }
                }
            }

            Console.WriteLine(maximumVisitedPosition);
        }
    }
}
