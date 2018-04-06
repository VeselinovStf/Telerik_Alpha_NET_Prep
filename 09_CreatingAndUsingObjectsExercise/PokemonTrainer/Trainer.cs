using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name, Pokemon pokemon)
        {
            this.name = name;
            this.badges = 0;

            this.pokemons = new List<Pokemon>();
            AddPokemon(pokemon);
        }

        public List<Pokemon> Pokemons { get => pokemons;  }
        public int Badges { get => badges;  }
        public string Name { get => name; }

        public void AddBadge()
        {
            this.badges++;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public void DamagePokemons()
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i].Health < 0)
                {
                    pokemons.RemoveAt(i);
                    i--;
                }
                else
                {
                    pokemons[i].TakeDamage();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"{this.Name} {this.Badges} {this.Pokemons.Count}");

            return result.ToString();
        }
    }
}
