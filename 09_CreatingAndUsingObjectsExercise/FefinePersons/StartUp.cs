using System;

namespace FefinePersons
{
    public class StartUp
    {
        private static void Main()
        {
            // TestPersonClass();
            Family family = new Family();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');

                Person member = new Person(parameters[0], int.Parse(parameters[1]));

                family.AddMember(member);
            }

            Console.WriteLine(family.GetOldestMember());
        }

        //private static void TestPersonClass()
        //{
        //    var persons = new Person[3];

        //    Person p1 = new Person()
        //    {
        //        Name = "Pesho",
        //        Age = 20
        //    };
        //    persons[0] = p1;

        //    Person p2 = new Person()
        //    {
        //        Name = "Ivan",
        //        Age = 33
        //    };
        //    persons[1] = p2;

        //    Person p3 = new Person()
        //    {
        //        Name = "Mitio",
        //        Age = 49
        //    };
        //    persons[2] = p3;

        //    foreach (var person in persons)
        //    {
        //        Console.WriteLine(person);
        //    }
        //}
    }
}