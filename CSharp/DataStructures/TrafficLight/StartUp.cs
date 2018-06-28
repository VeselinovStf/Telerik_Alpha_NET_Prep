using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    public class StartUp
    {
        public static void Main()
        {
            int passCount = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int passedCounter = 0;

            while (!command.Equals("end"))
            {
                if (command.Equals("green"))
                {
                    for (int i = 0; i < passCount; i++)
                    {
                        if (cars.Count != 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCounter++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCounter} cars passed the crossroads.");
        }
    }
}