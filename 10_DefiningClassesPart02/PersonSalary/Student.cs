using System;

namespace PersonSalary
{
    public class Student : Human, System.IComparable
    {
        private int score;

        public Student(string sureName, string fammilyName, int score) : base(sureName, fammilyName)
        {
            this.score = score;
        }

        public int Score { get => score;  }

        public int CompareTo(object s1)
        {
            if (s1 == null)
            {
                return 1;
            }

            Student otherStudent = s1 as Student;
            if (otherStudent != null)
            {
                return this.score.CompareTo(otherStudent.Score);
            }
            else
            {
                throw new ArgumentException("UPS");
            }
        }
    }
}
