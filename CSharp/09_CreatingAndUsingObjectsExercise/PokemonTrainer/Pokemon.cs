namespace PokemonTrainer
{
    public class Pokemon
    {
        private string name;
        private Elements element;
        private int health;

        public Pokemon(string name, Elements element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public int Health { get => health;  }
        public Elements Element { get => element;  }
        public string Name { get => name;  }

       public void TakeDamage()
        {
            this.health -= 10;
        }
    }
}
