namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            HashSet<Engine> engineSet = new HashSet<Engine>();

            //engine info
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] infoEngine = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = infoEngine[0];
                int power = int.Parse(infoEngine[1]);
                Engine carEngine;

                if (infoEngine.Length == 2)
                {
                    carEngine = new Engine(model, power);
                }

                else if (infoEngine.Length == 3)
                {
                    string info = infoEngine[2];
                    int displacement;
                    if (Int32.TryParse(info, out displacement))
                    {
                        carEngine = new Engine(model, power, info);
                    }
                    else
                    {
                        carEngine = new Engine(model, power, "n/a", info);
                    }
                }

                else
                {
                    string displacement = infoEngine[2];
                    string efficiency = infoEngine[3];
                    carEngine = new Engine(model, power, displacement, efficiency);
                }

                engineSet.Add(carEngine);
            }

            List<Car> carList = new List<Car>();

            //car info
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] infoCar = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = infoCar[0];
                string engineModel = infoCar[1];
                if (!engineSet.Any(x => x.Model == engineModel))
                {
                    continue;
                }
                Engine currEngine = engineSet.Where(x => x.Model == engineModel).FirstOrDefault();
                Car newCar;
                if (infoCar.Length == 2)
                {
                    newCar = new Car(model, currEngine);
                }
                else if (infoCar.Length == 3)
                {
                    string info = infoCar[2];
                    int weight;
                    if (Int32.TryParse(info, out weight))
                    {
                        newCar = new Car(model, currEngine, info);
                    }
                    else
                    {
                        newCar = new Car(model, currEngine, "n/a", info);
                    }
                }
                else
                {
                    string weight = infoCar[2];
                    string color = infoCar[3];
                    newCar = new Car(model, currEngine, weight, color);
                }
                carList.Add(newCar);
            }
            foreach (var car in carList)
            {
                car.Print();
            }
        }
    }
}
