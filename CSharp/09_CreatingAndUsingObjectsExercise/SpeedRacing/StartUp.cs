using System;
using System.Collections.Generic;
using System.IO;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void FakeInput()
        {
            string input = @"3
AudiA4 18 0.34
BMW-M2 33 0.41
Ferrari-488Spider 50 0.47
Drive Ferrari-488Spider 97
Drive Ferrari-488Spider 35
Drive AudiA4 85
Drive AudiA4 50
End";

            Console.SetIn(new StringReader(input));
        }

        public static void Main()
        {
            FakeInput();

            int carTrackCount = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < carTrackCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ');
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);

                if (!cars.ContainsKey(model))
                {
                    cars[model] = new Car(model, fuelAmount, fuelConsumption);
                }
                else
                {
                    Console.WriteLine("Can't have cars with same model!");
                }
            }

            string line = Console.ReadLine();

            while (!line.Equals("End"))
            {
                string[] parameters = line.Split(' ');

                string command = parameters[0];
                string model = parameters[1];
                int distence = int.Parse(parameters[2]);

                if (command.Equals("Drive"))
                {
                    if (!cars.ContainsKey(model))
                    {
                        Console.WriteLine("This model is not in the race!");
                    }
                    else
                    {
                        cars[model].Drive(distence);
                    }
                }
                else
                {
                    Console.WriteLine("You enter whrong command");
                }

                line = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value);
            }
        }
    }
}
