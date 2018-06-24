using System;

namespace ShootingContest
{
    public class StartUp
    {
        public static void Main()
        {
            long numberOfTargets = long.Parse(Console.ReadLine());
            long georgeSpeed = long.Parse(Console.ReadLine());
            long georgeLetency = long.Parse(Console.ReadLine());
            long peterSpeed = long.Parse(Console.ReadLine());
            long peterLetency = long.Parse(Console.ReadLine());

            long georgeTotal = georgeLetency + (numberOfTargets * georgeSpeed) + georgeLetency;
            long peterTotal = peterLetency + (numberOfTargets * peterSpeed) + peterLetency;

            if (georgeTotal < peterTotal)
            {
                Console.WriteLine("George");
            }
            else if (peterTotal < georgeTotal)
            {
                Console.WriteLine("Peter");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}