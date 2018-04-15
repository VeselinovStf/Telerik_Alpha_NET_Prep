using System;

namespace PointsEx
{
    public class StartUp
    {
        public static void Main()
        {
            var pointA = new { X = 15, Y = 20 };
            var pointB = new { X = 20, Y = 30 };

            Console.WriteLine(pointA.X - pointB.X);
            Console.WriteLine(pointA.Y - pointB.Y);
        }
    }
}