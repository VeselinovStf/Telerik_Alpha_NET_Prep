using System;

namespace ShapesOfGray
{
    public class StartUp
    {
        public static void Main()
        {
            var shapes = new Shape[3];

            shapes[0] = new Triangle(2, 2);
            shapes[1] = new Rectangle(5, 5);
            shapes[2] = new Circle(10, 0);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}