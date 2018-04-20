namespace Google
{
    public class Pokemon
    {
        private string name;
        private string type;

        public Pokemon(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string Type { get => type; }
        public string Name { get => name;  }


        public override string ToString()
        {
            return $"{this.Name} {this.Type}";
        }
    }
}
