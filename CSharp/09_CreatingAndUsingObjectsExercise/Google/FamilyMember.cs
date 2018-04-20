namespace Google
{
    public class FamilyMember
    {
        private string name;
        private string dateOfBirth;

        public FamilyMember(string name, string dateOfBirth)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }

        public string DateOfBirth { get => dateOfBirth; }
        public string Name { get => name;  }

        public override string ToString()
        {
            return $"{this.Name} {this.DateOfBirth}";
        }
    }
}
