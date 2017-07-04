using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumPerKm;
        private double distanceTraveled;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {                
                this.model = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }

        public double FuelConsumPerKm
        {
            get
            {
                return this.fuelConsumPerKm;
            }
            set
            {
                this.fuelConsumPerKm = value;
            }
        }

        public Car(string model, double fuelAmount, double fuelConsumPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.fuelConsumPerKm = fuelConsumPerKm;
            this.distanceTraveled = 0;
        }

        public void Drive(double km)
        {
            double reqFuel = km * FuelConsumPerKm;
            if (reqFuel <= FuelAmount)
            {
                this.FuelAmount -= reqFuel;
                this.distanceTraveled += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.distanceTraveled:f0}";
        }

    }
}
