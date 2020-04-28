namespace DefiningClasses
{
    using System;
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(
            string model,
            double fuelAmount,
            double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.travelledDistance = 0;
        }

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

        public double FuelConsumptionPerKilometer 
        {
            get 
            {
                return this.fuelConsumptionPerKilometer;
            }
            set 
            {
                this.fuelConsumptionPerKilometer = value;
            }
        
        }

        public double TravelledDistance
        {
            get
            {
                return this.travelledDistance;
            }
            set
            {
                this.travelledDistance = value;
            }
        }

        public void PrintCar()
        {
            Console.WriteLine($"{this.model} {this.fuelAmount:F2} {this.travelledDistance}");
        }
    }
}
