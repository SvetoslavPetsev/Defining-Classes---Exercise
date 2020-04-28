using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemonList;
        public Trainer()
        {
            this.PokemonList = new List<Pokemon>();
            this.NumberOfBadges = 0;
        }
        public Trainer(string name):this()
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> PokemonList { get; set; }

        public void AddBadget()
        {
            this.NumberOfBadges++;
        }

        public void ReduceHealth()
        {
            PokemonList = PokemonList.Select(x => { x.Health -= 10; return x; }).ToList();
        }

        public void RemoveDeath()
        {
            PokemonList = PokemonList.Where(x => x.Health > 0).ToList();
        }
    }
}
