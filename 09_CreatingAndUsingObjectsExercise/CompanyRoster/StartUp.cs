using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompanyRoster
{
    public class StartUp
    {
        private static List<Employee> employee = new List<Employee>();

        public static void FakeInput()
        {
            StringBuilder result = new StringBuilder();
            StreamReader reader = new StreamReader("../../../testInput.txt");
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    result.AppendLine(line);
                    line = reader.ReadLine();
                }

            }

            Console.SetIn(new StringReader(result.ToString()));
        }

        public static void Main()
        {
            FakeInput();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');

                string name = parameters[0];
                decimal salary = decimal.Parse(parameters[1]);
                string position = parameters[2];
                string department = parameters[3];

                

                if (parameters.Length > 5)
                {
                    string email = parameters[4];
                    int age = int.Parse(parameters[5]);

                    employee.Add(new Employee(name, salary, position, department, email, age));
                }
                else if (parameters.Length > 4)
                {
                    int age;
                    bool tryAge = int.TryParse(parameters[4], out age);

                    if (tryAge)
                    {
                        employee.Add(new Employee(name, salary, position, department, age));
                    }
                    else
                    {
                        string email = parameters[4];
                        employee.Add(new Employee(name, salary, position, department, email));
                    }
                }
                else
                {
                    employee.Add(new Employee(name, salary, position, department));
                }
                
            }

            //TODO FINISH SOLUTION
            //NOTE : USE DICTIONARY!

          
           
        }
    }
}
