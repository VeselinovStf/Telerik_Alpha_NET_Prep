using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    public class StartUp
    {
        public static void Main()
        {
            int[] values = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> elements = new Queue<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));

            int popElementsCounter = values[1];
            int searchNumber = values[2];

            for (int i = 0; i < popElementsCounter; i++)
            {
                elements.Dequeue();
            }

            if (elements.Contains(searchNumber))
            {
                Console.WriteLine("true");
                return;
            }

            if (elements.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(elements.Min());
            }
        }
    }
}