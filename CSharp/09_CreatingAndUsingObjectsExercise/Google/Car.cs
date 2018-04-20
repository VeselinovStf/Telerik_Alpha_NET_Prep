namespace Google
{
    public class Car
    {
        private string model;
        private int speed;

        public Car()
        {
            this.model = string.Empty;
            this.speed = 0;
        }

        public string Model { get => model; set => model = value; }
        public int Speed { get => speed; set => speed = value; }
    }
}
