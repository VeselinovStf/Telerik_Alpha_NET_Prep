namespace ShapesOfGray
{
    public class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get => width; }
        public double Height { get => height; }

        public virtual double CalculateSurface()
        {
            return width * height;
        }
    }
}