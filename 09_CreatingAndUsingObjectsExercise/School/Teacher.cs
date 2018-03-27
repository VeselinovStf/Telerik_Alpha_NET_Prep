using System;
using System.Collections.Generic;

namespace School
{
    public class Teacher
    {
        private string name;
        private List<Subject> subject;

        public List<Subject> Disciplines { get => subject;  }
        public string Name { get => name; }

        public Teacher(string name)
        {
            this.name = name;
            this.subject = new List<Subject>();
        }

        public void AddSubject(Subject subject)
        {
            if (this.subject.Contains(subject))
            {
                Console.WriteLine("This Teacher on this subject allready!");
            }
            else
            {
                this.subject.Add(subject);
            }
           
        }
    }
}
