using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotato
{
    public class StartUp
    {
        public static void Main()
        {
            Queue<string> players =
                new Queue<string>(
                    Console.ReadLine()
                    .Split(' ')
                    );

            int count = int.Parse(Console.ReadLine());

            while (players.Count != 1)
            {
                for (int i = 1; i < count; i++)
                {
                    players.Enqueue(players.Dequeue());
                }

                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}