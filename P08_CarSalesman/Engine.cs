namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private int power;
        private string displacement;
        private string efficiency;
        public Engine()
        {
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }
        public Engine(string model, int power):this()
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(
            string model,
            int power,
            string displacement) 
            :this (model, power)
        {
            this.Displacement = displacement;
        }
        public Engine(
            string model,
            int power,
            string displacement,
            string efficiency) 
            :this (model, power, displacement)
        {
            this.Efficiency = efficiency;
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
        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }
        public string Displacement
        {
            get
            {
                return this.displacement;
            }
            set
            {
                this.displacement = value;
            }
        }
        public string Efficiency
        {
            get
            {
                return this.efficiency;
            }
            set
            {
                this.efficiency = value;
            }
        }

        public override string ToString()
        {
            return $"{this.model} - {this.power} - {this.displacement} - {this.efficiency}"; 
        }
    }
}
