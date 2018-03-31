namespace CompanyRoster
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(
            string name, 
            decimal salary, 
            string position, 
            string department
            )
        {
            this.name = name;
            this.salary = salary;         
            this.position = position;
            this.department = department;
            this.email = "n//a";
            this.age = -1;
        }

        public Employee(
            string name,
            decimal salary,
            string position,
            string department,
            int age
            )
            :this(name,salary,position,department)
        {
            this.age = age;
        }

        public Employee(
           string name,
           decimal salary,
           string position,
           string department,
           string email
           )
           : this(name, salary, position, department)
        {
            this.email = email;
        }

        public Employee(
            string name, 
            decimal salary, 
            string position, 
            string department,
            string email,
            int age)
            : this(name,salary, position,department)
        {
            this.email = email;
            this.age = age;
        }

        public string Name { get => name; }
        public decimal Salary { get => salary;  }
        public string Position { get => position;  }
        public string Department { get => department;  }
        public string Email { get => email;  }
        public int Age { get => age;  }

        public override string ToString()
        {
            return $"{this.Name} {this.Salary:F2} {this.Email} {this.age}";
        }
    }
}
