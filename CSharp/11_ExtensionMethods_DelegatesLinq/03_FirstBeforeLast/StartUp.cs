using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_FirstBeforeLast
{
    public class StartUp
    {
        public static void Main()
        {
            var students = new Student[]
            {
                new Student("Pesho","Asenov", 18),
                new Student("Asen", "Vasilev", 24),
                new Student("Gosho", "Zaimov", 17),
                new Student( "Maria", "Atanasova", 25)
            };

            Console.WriteLine("Sorted By second name:");
            var sortedBySeccondName = SortBySecondNameAlphabet(students);
            Print(sortedBySeccondName);

            Console.WriteLine("Sorted By Age:");
            var sortedByAge = SortByAge(students);
            Print(sortedByAge);

            Console.WriteLine("Sorted By Firs name then by second name (Extension Methods)");
            foreach (var student in students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName))
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Sorted By Firs name then by second name (Linq query)");
            var sortedByNames = SortedByNames(students);
            Print(sortedByNames);
        }

        private static IEnumerable<Student> SortedByNames(IEnumerable<Student> students)
        {
            var result = from s in students
                         orderby s.FirstName descending, s.LastName descending
                         select s;

            return result;
        }

        private static IEnumerable<Student> SortByAge(IEnumerable<Student> students)
        {
            var result = from s in students
                         where s.Age >= 18 && s.Age <= 24
                         orderby s.FirstName, s.LastName
                         select s;

            return result;
        }

        private static IEnumerable<Student> SortBySecondNameAlphabet(IEnumerable<Student> students, bool useParalel = true)
        {
            if (useParalel)
            {
                students = students.AsParallel();
            }

            var result = from s in students
                         where s.FirstName.CompareTo(s.LastName) < 0
                         orderby s.FirstName
                         select s;

            return result;
        }

        public static void Print(IEnumerable<Student> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}