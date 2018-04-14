using System;

namespace ShapesOfGray
{
    public class Circle : Shape
    {
        public Circle(double radius, double height) : base(radius, height)
        {
        }

        public override double CalculateSurface()
        {
            return Math.PI * (this.Width * this.Width);
        }
    }
}
