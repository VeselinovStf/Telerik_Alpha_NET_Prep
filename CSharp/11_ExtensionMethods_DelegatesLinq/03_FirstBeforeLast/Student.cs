using System.Text;

namespace _03_FirstBeforeLast
{
    public class Student
    {
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{this.FirstName} {this.LastName} {this.Age}");
            return result.ToString();
        }
    }
}