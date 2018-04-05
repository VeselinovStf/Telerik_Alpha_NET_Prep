using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;

            //this.engine = new Engine();
            this.engine = engine;
            this.color = "n\\a";
        }

        public Car(string model, Engine engine, int weight)
            :this(model, engine)
        {                     
            this.weight = weight;         
        }

        public Car(string model, Engine engine, string color)
          : this(model, engine)
        {
            this.color = color;
        }

        public Car(string model,Engine engine, int weight, string color)
            : this(model,engine,weight)
        {          
            this.color = color;
        }

        public string Model { get => model;}
        public Engine Engine { get => engine;  }
        public int Weight { get => weight; }
        public string Color { get => color; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.Model}:");
            result.AppendLine($"{this.engine}");
            if (this.Weight > 0)
            {
                result.AppendLine($" Weight: {this.Weight}");
            }
            else
            {
                result.AppendLine($" Weight: n\\a");
            }
           
            result.Append($" Color: {this.Color}");

            return result.ToString();
        }
    }
}
