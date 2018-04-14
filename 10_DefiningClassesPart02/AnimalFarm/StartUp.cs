using System;

namespace AnimalFarm
{
    public class StartUp
    {
        public static void Main()
        {
            var animals = new Animal[5];
            animals[0] = new Cat("Penka", 2, "Male");
            animals[1] = new Dog("Joro", 3, "Female");
            animals[2] = new Frog("Mik", 4, "Male");
            animals[3] = new Kitten("Dundi", 5, "Who knows");
            animals[4] = new Tomcat("Tom", 6, "Female");


            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} at age {animal.Age} and gender of {animal.Gender} says : {animal.MakeNoice()}");
            }
        }
    }
}
