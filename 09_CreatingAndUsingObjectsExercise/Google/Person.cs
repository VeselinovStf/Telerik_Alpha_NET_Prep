using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<FamilyMember> parents;
        private List<FamilyMember> children;
        private List<Pokemon> pokemons;

        public Person(string name)
        {
            this.name = name;

            this.car = new Car();
            this.company = new Company();
            this.parents = new List<FamilyMember>();
            this.children = new List<FamilyMember>();
            this.pokemons = new List<Pokemon>();
        }

        public string Name { get => name;  }
        public Company Company { get => company;  }
        public Car Car { get => car;  }
        public List<FamilyMember> Parents { get => parents;  }
        public List<FamilyMember> Children { get => children;  }
        public List<Pokemon> Pokemons { get => pokemons; }

        public void AddParent(FamilyMember member)
        {
            this.parents.Add(member);
        }

        public void AddChildren(FamilyMember member)
        {
            this.children.Add(member);
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.Name}");
            result.AppendLine($"Company:");           
            if (this.Company.Name != string.Empty)
            {
                result.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary}");
            }
            result.AppendLine($"Car:");
            if (this.Car.Model != string.Empty)
            {
                result.AppendLine($"{this.Car.Model} {this.Car.Speed}");
            }
            result.AppendLine($"Pokemon:");
            if (pokemons.Count > 0)
            {
                foreach (var pokemon in pokemons)
                {
                    result.AppendLine(pokemon.ToString());
                }
            }
            result.AppendLine($"Parents:");
            if (parents.Count > 0)
            {
                foreach (var parent in parents)
                {
                    result.AppendLine(parent.ToString());
                }
            }
            result.AppendLine($"Children:");
            if (children.Count > 0)
            {
                foreach (var kid in children)
                {
                    result.AppendLine(kid.ToString());
                }
            }
            return result.ToString();
        }
    }
}
