namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            HashSet<Car> carSet = new HashSet<Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = info[0];
                double amount = double.Parse(info[1]);
                double fuelConsumtion = double.Parse(info[2]);

                Car car = new Car(model, amount, fuelConsumtion);
                carSet.Add(car);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = info[1];
                double distance = double.Parse(info[2]);

                if (carSet.Any(x => x.Model == model))
                {                    
                    Car selectedCar = carSet.Where(x => x.Model == model).FirstOrDefault();
                    double neededFuel = distance * selectedCar.FuelConsumptionPerKilometer;
                    if (selectedCar.FuelAmount >= neededFuel)
                    {
                        selectedCar.FuelAmount -= neededFuel;
                        selectedCar.TravelledDistance += distance;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }
            foreach (var car in carSet)
            {
                car.PrintCar();
            }
        }
    }
}
