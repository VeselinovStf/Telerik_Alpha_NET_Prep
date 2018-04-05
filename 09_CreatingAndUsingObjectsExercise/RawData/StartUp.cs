using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void FakeInput()
        {
            string input = @"4
ChevroletExpress 215 255 1200 flamable 2.5 1 2.4 2 2.7 1 2.8 1
ChevroletAstro 210 230 1000 flamable 2 1 1.9 2 1.7 3 2.1 1
DaciaDokker 230 275 1400 flamable 2.2 1 2.3 1 2.4 1 2 1
Citroen2CV 190 165 1200 fragile 0.8 3 0.85 2 0.7 5 0.95 2
flamable";

            Console.SetIn(new StringReader(input));
        }

        public static void Main()
        {
            FakeInput();

            List<Car> cars = new List<Car>();

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');

                string model = parameters[0];
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];

                double tire1Presure = double.Parse(parameters[5]);
                int tire1Age = int.Parse(parameters[6]);
                double tire2Presure = double.Parse(parameters[7]);
                int tire2Age = int.Parse(parameters[8]);
                double tire3Presure = double.Parse(parameters[9]);
                int tire3Age = int.Parse(parameters[10]);
                double tire4Presure = double.Parse(parameters[11]);
                int tire4Age = int.Parse(parameters[12]);

                Car newCar = new Car(
                    model,
                    engineSpeed,
                    enginePower,
                    cargoWeight,
                    cargoType,
                    tire1Presure, tire1Age,
                    tire2Presure, tire2Age,
                    tire3Presure, tire3Age,
                    tire4Presure, tire4Age
                    );

                cars.Add(newCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(C => C.Cargo.Type == "fragile")
                    .Where(c => c.Tires.Average(a => a.Presure) < 1))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(C => C.Cargo.Type == "flamable")
                   .Where(e => e.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }

        }
    }
}
