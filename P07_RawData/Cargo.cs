namespace DefiningClasses
{
    public class Cargo
    {
        private int cargoWeight;
        private string cargoType;

        public int CargoWight 
        {
            get 
            {
                return this.cargoWeight;
            }
            set 
            {
                this.cargoWeight = value;
            }
        }
        public Cargo(int cargoWight, string cargoType)
        {
            this.CargoWight = cargoWeight;
            this.CargoType = cargoType;
        }
        public string CargoType
        {
            get
            {
                return this.cargoType;
            }
            set
            {
                this.cargoType = value;
            }
        }
    }
}
