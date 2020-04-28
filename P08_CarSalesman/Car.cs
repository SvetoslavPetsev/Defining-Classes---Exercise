using System;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine carEngine;
        private string weight;
        private string color;
        public Car()
        {
            this.weight = "n/a";
            this.color = "n/a";
        }
        public Car(string model, Engine carEngine):this()
        {
            this.Model = model;
            this.CarEngine = carEngine;
        }
        public Car(
            string model,
            Engine carEngine,
            string weight)
            :this(model, carEngine)
        {
            this.Weight = weight;
        }
        public Car(
            string model,
            Engine carEngine,
            string weight,
            string color)
            : this(model, carEngine, weight)
        {
            this.Color = color;
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

        public Engine CarEngine
        {
            get
            {
                return this.carEngine;
            }
            set
            {
                this.carEngine = value;
            }
        }

        public string Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public void Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.model}:");
            result.AppendLine($"  {this.carEngine.Model}:");
            result.AppendLine($"    Power: {this.carEngine.Power}");
            result.AppendLine($"    Displacement: {this.carEngine.Displacement}");
            result.AppendLine($"    Efficiency: {this.carEngine.Efficiency}");
            result.AppendLine($"  Weight: {this.weight}");
            result.Append($"  Color: {this.color}");

            Console.WriteLine(result.ToString());
        }
    }
}
