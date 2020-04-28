namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        public int Count => this.cars.Count();


        public string AddCar(Car car)
        {
            if (!this.cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                if (this.capacity > this.cars.Count)
                {
                    this.cars.Add(car);
                    return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
                }
                else
                {
                    return "Parking is full!";
                }
            }
            else
            {
                return"Car with that registration number, already exists!";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                this.cars = cars.Where(x => x.RegistrationNumber != registrationNumber).ToList();

                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            Car someCar = this.cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
            return someCar;
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                if (this.cars.Any(x => x.RegistrationNumber == number))
                {
                    this.cars = cars.Where(x => x.RegistrationNumber != number).ToList(); ;
                }
            }
        }
    }
}
