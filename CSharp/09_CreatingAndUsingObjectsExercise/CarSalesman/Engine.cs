using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;
        

        public Engine(string engineModel, int enginePower)
        {
            this.model = engineModel;
            this.power = enginePower;
            this.efficiency = "n\\a";
        }

        public Engine(string engineModel, int enginePower, int displacement)
            :this(engineModel, enginePower)
        {
            this.displacement = displacement;
        }

        public Engine(string engineModel, int enginePower, string efficiency)
           : this(engineModel, enginePower)
        {
            this.efficiency = efficiency;
        }

        public Engine(string engineModel, int enginePower, int displacement ,string efficiency)
             : this(engineModel, enginePower, displacement)
        {
            this.efficiency = efficiency;
        }

        public string Efficiency { get => efficiency;}
        public int Displacement { get => displacement;  }
        public int Power { get => power; }
        public string Model { get => model;  }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($" {this.Model}:");
            result.AppendLine($"    Power: {this.Power}");
            result.AppendLine($"    Displacement: {this.Displacement}");
            result.Append($"    Efficiency: {this.Efficiency}");

            return result.ToString();
        }
    }
}
