using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePersons
{
    public class StartUp
    {
        public static List<Person> persons = new List<Person>();
        public static Family family = new Family();

        public static void Main()
        {
            // Uncoment to see results

            // Task One:           
            // Console.WriteLine("----Create Person class, crete some persons and display there info");
            // PersonDisplayer();

            // Task Two:
            // Oldest family Member
            // Console.WriteLine("----Use person class, create class Family, print oldest familly member");
            // OldestFamilyMember();

            // Task Three:
            // Console.WriteLine("----Read From Console N lines and prind Person with age more then 30, sorted alphabetical");
            // OptionalPool();
           
        }

        private static void OptionalPool()
        {
            AddSomePersons();

            foreach (var person in persons
                .OrderByDescending(x => x.Age)
                .ThenBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
        

        private static void OldestFamilyMember()
        {
            AddSomePersons();

            foreach (var person in persons)
            {
                family.AddMember(person);
            }

            PrintOldestMember();

        }

        private static void PrintOldestMember()
        {
            var oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }

        private static void PersonDisplayer()
        {           
            AddSomePersons();

            PrintList();
        }

        private static void PrintList()
        {
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }

        private static void AddSomePersons()
        {
            Person pesho = new Person("Pesho", 18);
            Person gosho = new Person("Gosho", 30);
            Person stamat = new Person("Stamat", 17);

            persons.Add(pesho);
            persons.Add(gosho);
            persons.Add(stamat);
        }
    }
}
