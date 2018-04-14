namespace PersonSalary
{
    public class Human
    {
        private string sureName;
        private string fammilyName;

        public Human(string sureName, string fammilyName)
        {
            this.sureName = sureName;
            this.fammilyName = fammilyName;
        }

        public string SureName { get => sureName;  }
        public string FammilyName { get => fammilyName;  }
    }
}
