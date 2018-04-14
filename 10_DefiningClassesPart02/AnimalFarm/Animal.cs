namespace AnimalFarm
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string Name { get => name;  }
        public int Age { get => age; }
        public string Gender { get => gender;  }

        public virtual string MakeNoice()
        {
            return "SAYING SOMETHING";
        }
    }
}
