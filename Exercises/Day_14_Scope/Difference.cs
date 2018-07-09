using System.Linq;

namespace Day_14_Scope
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void computeDifference()
        {
            int minElement = this.elements.Min();
            int maxElement = this.elements.Max();

            int result = maxElement - minElement;

            this.maximumDifference = result;
        }
    }
}