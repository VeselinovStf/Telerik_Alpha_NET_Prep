using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{
    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            var pumps = new Queue<int[]>();
            var finalIndex = 0;

            for (int i = 0; i < count; i++)
            {
                int[] parameters = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(parameters);
            }

            for (int startPoint = 0; startPoint < count - 1; startPoint++)
            {
                var fuel = 0;
                bool isSolution = true;
                for (int j = 0; j < count; j++)
                {
                    var current = pumps.Dequeue();
                    var currentFuel = current[0];
                    var currentDistence = current[1];
                    pumps.Enqueue(current);
                    fuel += currentFuel - currentDistence;

                    if (fuel < 0)
                    {
                        startPoint = startPoint + j;
                        isSolution = false;
                        break;
                    }
                }

                if (isSolution)
                {
                    Console.WriteLine(startPoint);
                    return;
                }
            }

            Console.WriteLine(finalIndex);
        }
    }
}