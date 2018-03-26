using System.Text;

namespace PhoneINfo
{
    public class Display
    {
        private double size;
        private int numberOfColors;

        public double Size { get => size;  }
        public int NumberOfColors { get => numberOfColors; }

        public Display()
        {
            this.size = 0;
            this.numberOfColors = 0;
        }

        public Display(double size): this()
        {
            this.size = size;
        }

        public Display(double size, int numberOfColors)
            : this(size)
        {
            this.numberOfColors = numberOfColors;
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("-----------------");
            result.AppendLine($"\tDisplay Info");
            result.AppendLine($"Size : {this.Size}");
            result.AppendLine($"Colours {this.NumberOfColors}");
            result.AppendLine("-----------------");

            return result.ToString();
        }
    }
}