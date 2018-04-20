using System.Collections.Generic;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(
            string model, 
            int engineSpeed, 
            int enginePower, 
            int cargoWeight, 
            string cargoType,
            double tire1presure, int tire1Age,
            double tire2presure, int tire2Age,
            double tire3presure, int tire3Age,
            double tire4presure, int tire4Age)
        {
            this.model = model;

            this.engine = new Engine(engineSpeed,enginePower);
            this.cargo = new Cargo(cargoWeight,cargoType);

            this.tires = new List<Tire>();
            this.tires.Add(new Tire(tire1presure, tire1Age));
            this.tires.Add(new Tire(tire2presure, tire2Age));
            this.tires.Add(new Tire(tire3presure, tire3Age));
            this.tires.Add(new Tire(tire4presure, tire4Age));
        }

        public string Model { get => model;  }
        public Engine Engine { get => engine; }
        public Cargo Cargo { get => cargo;}
        public List<Tire> Tires { get => tires;  }
    }
}
