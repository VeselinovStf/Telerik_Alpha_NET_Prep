using System;
using System.Collections.Generic;
using System.IO;

namespace CarSalesman
{
    public class StartUp
    {
        public static void FakeInput()
        {
            string input = @"4
DSL-10 280 B
V7-55 200 35
DSL-13 305 55 A+
V7-54 190 30 D
4
FordMondeo DSL-13 Purple
VolkswagenPolo V7-54 1200 Yellow
VolkswagenPassat DSL-10 1375 Blue
FordFusion DSL-13";

            Console.SetIn(new StringReader(input));
        }

        public static void Main()
        {
            FakeInput();

            int enginesCount = int.Parse(Console.ReadLine());

            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < enginesCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');
                string model = parameters[0];
                int enginePower = int.Parse(parameters[1]);

                switch (parameters.Length)
                {
                    case 2:
                        engines.Add(model, new Engine(model, enginePower));
                        break;
                    case 3:
                        int displacement;
                        bool isNum = int.TryParse(parameters[2], out displacement);
                        if (isNum)
                        {
                            engines.Add(model, new Engine(model, enginePower, displacement));
                        }
                        else
                        {
                            engines.Add(model, new Engine(model, enginePower, parameters[2]));
                        }
                        break;
                    case 4:
                        engines.Add(model, new Engine(model, enginePower, int.Parse(parameters[2]), parameters[3]));
                        break;
                    default:
                        break;
                }
            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');
                string model = parameters[0];
                string engine = parameters[1];

                switch (parameters.Length)
                {
                    case 2:
                        cars.Add(new Car(model, engines[engine]));
                        break;
                    case 3:
                        int weight;
                        bool isNum = int.TryParse(parameters[2], out weight);
                        if (isNum)
                        {
                            cars.Add(new Car(model, engines[engine],weight));
                        }
                        else
                        {
                            cars.Add(new Car(model, engines[engine], parameters[2]));
                        }
                        break;
                    case 4:
                        cars.Add(new Car(model, engines[engine], int.Parse(parameters[2]),parameters[3]));
                        break;
                    default:
                        break;
                }

               
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }


        }

     
    }
}
