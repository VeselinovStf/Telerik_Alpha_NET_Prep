namespace RawData
{
    public class Tire
    {
        private double presure;
        private int age;

        public Tire(double presure, int age)
        {
            this.presure = presure;
            this.age = age;
        }

        public double Presure { get => presure; }
        public int Age { get => age;  }
    }
}
