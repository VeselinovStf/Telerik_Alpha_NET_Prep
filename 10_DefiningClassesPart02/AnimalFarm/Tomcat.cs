namespace AnimalFarm
{
    public class Tomcat : Animal
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string MakeNoice()
        {
            return "MAY may...";
        }
    }
}
