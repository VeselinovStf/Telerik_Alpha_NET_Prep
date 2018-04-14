using System;

namespace PersonSalary
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Students Score");
            var students = new Student[10];

            students[0] = new Student("Ivan", "Ivanov", 100);
            for (int i = 1; i < students.Length; i++)
            {
                students[i] = new Student("Pesho" + i, "Testov", 6 + i);
            }

            Array.Sort(students);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.SureName} {student.FammilyName} - {student.Score}");
            }

            Console.WriteLine("Workers Salary");
            var workers = new Worker[10];

            workers[0] = new Worker("Ivan", "Ivanov", 1M, 10);
            for (int i = 1; i < workers.Length; i++)
            {
                workers[i] = new Worker("Pesho" + i, "Testov", 6 + i, 6 + i + i);
            }

            Array.Sort(workers);

            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.SureName} {worker.FammilyName} - {worker.Salary}");
            }
        }
    }
}