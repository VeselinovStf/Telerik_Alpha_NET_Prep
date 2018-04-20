namespace AnimalFarm
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string MakeNoice()
        {
            return "Cribit Cribit";
        }
    }
}