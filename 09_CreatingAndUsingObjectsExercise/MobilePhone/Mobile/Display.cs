using System.Text;

namespace MobilePhone.Mobile
{
    public class Display
    {
        private double size;
        private int colours;

        public Display()
        {
            this.size = 0;
            this.colours = 0;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
        }

        public int Colours
        {
            get
            {
                return this.colours;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"--Display specifications--");
            result.AppendLine($"--Size : {this.Size}");
            result.AppendLine($"--Colours : {this.Colours}");

            return result.ToString();
        }
    }
}