namespace Google
{
    public class Company
    {
        private string name;
        private string department;
        private decimal salary;

        public Company()
        {
            this.name = string.Empty;
            this.salary = 0M;
        }

       

        public decimal Salary { get => salary; set => this.salary = value; }
        public string Name { get => name; set => this.name = value; }
        public string Department { get => department; set => department = value; }

        
    }
}
