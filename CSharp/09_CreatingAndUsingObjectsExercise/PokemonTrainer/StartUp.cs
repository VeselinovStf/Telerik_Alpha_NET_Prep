using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        private const string TOURNAMENT = "Tournament";
        private const string END = "End";

        private static Dictionary<string, Trainer> trainers = 
            new Dictionary<string, Trainer>();

        /// <summary>
        /// On Input line 3 - The element in original test was Psychic, i replace it with Water.
        /// If this is typeo it's ok like this byt if isn't code must be re-exam
        /// </summary>
        public static void FakeInput()
        {
            string input = @"Stamat Blastoise Water 18
Nasko Pikachu Electricity 22
Jicata Kadabra Water 90
Tournament
Fire
Electricity
Fire
End";

            Console.SetIn(new StringReader(input));
        }

        public static void Main()
        {
            FakeInput();

            string line = Console.ReadLine();

            while (!line.Equals(TOURNAMENT))
            {
                string[] parameters = line.Split(' ');

                string trainerName = parameters[0];
                string pokemonName = parameters[1];

                Elements pokemonElement = (Elements)Enum.Parse(typeof(Elements), parameters[2]);
                int pokemonHealth = int.Parse(parameters[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer newTrainer = new Trainer(trainerName, pokemon);
                    trainers[trainerName] = newTrainer;
                }
                else
                {
                    trainers[trainerName].AddPokemon(pokemon);
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            while (!line.Equals(END))
            {
                switch ((Elements)Enum.Parse(typeof(Elements),line))
                {
                    case Elements.Fire:
                        BattleAction(Elements.Fire);
                        break;
                    case Elements.Water:
                        BattleAction(Elements.Water);
                        break;
                    case Elements.Electricity:
                        BattleAction(Elements.Electricity);
                        break;
                    default:
                        break;
                }


                line = Console.ReadLine();
            }


            foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine(trainer.Value);
            }
        }

        private static void BattleAction(Elements element)
        {
            bool gotElemet = trainers.Any(t => t.Value.Pokemons.Any(e => e.Element == element));

            foreach (var trainer in trainers)
            {
                if (trainer.Value.Pokemons.Any(e => e.Element == element))
                {
                    trainer.Value.AddBadge();
                }
                else
                {
                    trainer.Value.DamagePokemons();
                }
            }
        }
    }
}
