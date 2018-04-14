using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Student : Human
    {
        private int id;

        public Student(string name, int id) : base(name)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.id}";
        }
    }
}
