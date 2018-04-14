using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Human
    {
        private string name;

        public Human(string name)
        {
            this.name = name;
        }

        public string Name { get => name;  }
    }
}
