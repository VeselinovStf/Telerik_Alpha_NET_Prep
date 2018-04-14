using System;

namespace PersonSalary
{
    public class Worker : Human, System.IComparable
    {
        private decimal salary;
        private int workedHours;

        public Worker(string sureName, string fammilyName, decimal salary, int workedHours) : base(sureName, fammilyName)
        {
            this.salary = salary;
            this.workedHours = workedHours;
        }

        public decimal CalculateSalaryForOneHour()
        {
            decimal oneHourSalary = 0;

            oneHourSalary = this.Salary / this.WorkedHours;

            return oneHourSalary;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Worker otherWorker = obj as Worker;
            if (otherWorker != null)
            {
                return otherWorker.Salary.CompareTo(this.Salary);
            }
            else
            {
                throw new ArgumentException("Ups");
            }
        }

        public int WorkedHours { get => workedHours;  }
        public decimal Salary { get => salary;  }
    }
}
