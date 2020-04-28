namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> carSet = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string[] carInfo = info.SkipLast(8).ToArray();
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                Engine carEngine = new Engine(engineSpeed, enginePower);

                int cargoWight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Cargo carCargo = new Cargo(cargoWight, cargoType);

                string[] tireInfo = info.Skip(5).ToArray();
                Tire[] tires = new Tire[4];
                for (int j = 0; j < tires.Length; j++)
                {
                    double pressure = double.Parse(tireInfo[j * 2]);
                    int year = int.Parse(tireInfo[j * 2 + 1]);
                    Tire tire = new Tire(pressure, year);
                    tires[j] = tire;
                }

                Car newCar = new Car(model, carEngine, carCargo, tires);
                carSet.Add(newCar);
            }

            string filter = Console.ReadLine();

            foreach (var car in carSet.Where(x => x.CarCargo.CargoType == filter))
            {
                Predicate<Car> fragilePredicate = car => car.Tires.Any(x => x.Pressure < 1.0);
                Predicate<Car> flamablePredicate = car => car.Engine.EnginePower > 250;

                if (filter == "fragile" && fragilePredicate(car))
                {
                    car.PrintModel();
                }

                else if (filter == "flamable" && flamablePredicate(car))
                {
                    car.PrintModel();
                }
            }
        }
    }
}
