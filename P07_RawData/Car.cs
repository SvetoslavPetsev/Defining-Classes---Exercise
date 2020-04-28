using System;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo carCargo;
        private Tire[] tires;


        public Car(
            string model,
            Engine engine,
            Cargo carCargo,
            Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.CarCargo = carCargo;
            this.Tires = tires; 
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

        public Engine Engine
        {
            get 
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }

        public Cargo CarCargo
        {
            get
            {
                return this.carCargo;
            }
            set
            {
                this.carCargo = value;
            }
        }

        public Tire[] Tires
        {
            get 
            {
                return this.tires;
            }
            set 
            {
                this.tires = value;
            }
        }

        public void PrintModel()
        {
            Console.WriteLine(this.model);
        }

        public override string ToString()
        {
            return $"{this.model}"; 
        }
    }
}
