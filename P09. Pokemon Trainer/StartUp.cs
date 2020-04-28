namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainerList = new List<Trainer>();

            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int pokemonHealth = int.Parse(info[3]);

                if (!trainerList.Any(x => x.Name == trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainerList.Add(trainer);
                }
   
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                trainerList.Where(x => x.Name == trainerName).FirstOrDefault().PokemonList.Add(pokemon);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                for (int i = 0; i < trainerList.Count; i++)
                {
                    var currTrainer = trainerList[i];
                    if (currTrainer.PokemonList.Any(x => x.Element == command))
                    {
                        trainerList[i].AddBadget();
                    }
                    else if (currTrainer.PokemonList.Any())
                    {
                        trainerList[i].ReduceHealth();
                        trainerList[i].RemoveDeath();
                    }
                }
            }
            foreach (var trainer in trainerList.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonList.Count}");
            }
        }
    }
}
