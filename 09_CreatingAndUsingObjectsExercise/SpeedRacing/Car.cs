using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsulption;
        private double distanceTravelled;

        public Car(string model, double fuelAmount, double fuelConsulption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsulption = fuelConsulption;
            this.distanceTravelled = 0;
        }

        public double DistanceTravelled { get => distanceTravelled;  }
        public double FuelConsulption { get => fuelConsulption; }
        public double FuelAmount { get => fuelAmount;  }
        public string Model { get => model; }


        public void Drive(int distence)
        {
            bool isMoving = DistenceMove(distence);
            if (isMoving)
            {
                this.fuelAmount -= distence * this.FuelConsulption;
                this.distanceTravelled += distence;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive.");
            }
        }

        private bool DistenceMove(int distence)
        {
            double neadedFuel = distence * this.FuelConsulption;

            if (this.FuelAmount - neadedFuel < 0)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"{this.Model} {this.FuelAmount:F2} {this.DistanceTravelled}");

            return result.ToString();
        }

      
    }
}
