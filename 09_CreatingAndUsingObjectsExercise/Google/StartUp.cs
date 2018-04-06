using System;
using System.Collections.Generic;

namespace Google
{
    public class StartUp
    {
        private static Dictionary<string, Person> persons = new Dictionary<string, Person>();

        public static void Main()
        {
            CLI_Input.FakeInput();
            string line = Console.ReadLine();

            while (!line.Equals(Const.END_COMMAND))
            {
                string[] parameters = line.Split(' ');

                string personName = parameters[0];
                string command = parameters[1];

                if (!persons.ContainsKey(personName))
                {
                    persons[personName] = new Person(personName);
                }
               
                switch (command)
                {
                    case Const.CAR_COMMAND:
                        string carModel = parameters[2];
                        int carSpeed = int.Parse(parameters[3]);
                        AddCar(persons[personName],carModel,carSpeed);
                        break;
                    case Const.CHILDREN_COMMAND:
                        string childrenName = parameters[2];
                        string childrenBirthDate = parameters[3];
                        AddChildren(persons[personName],childrenName,childrenBirthDate);
                        break;
                    case Const.COMPANY_COMMAND:
                        string companyName = parameters[2];
                        string companyDepartment = parameters[3];
                        decimal companySalary = decimal.Parse(parameters[4]);
                        AddCompany(persons[personName],companyName, companyDepartment, companySalary);
                        break;
                    case Const.PARENTS_COMMAND:
                        string parentName = parameters[2];
                        string parentBirthDate = parameters[3];
                        AddParent(persons[personName],parentName,parentBirthDate);
                        break;
                    case Const.POKEMON_COMMAND:
                        string pokemonName = parameters[2];
                        string pokemonElement = parameters[3];
                        AddPokemon(persons[personName],pokemonName,pokemonElement);
                        break;
                    default:
                        break;
                }


                line = Console.ReadLine();
            }

            string person = Console.ReadLine();

            Console.WriteLine(persons[person]);
        }

        private static void AddPokemon(Person person, string pokemonName, string pokemonElement)
        {
            person.AddPokemon(new Pokemon(pokemonName, pokemonElement));
        }

        private static void AddParent(Person person, string parentName, string parentBirthDate)
        {
            person.AddParent(new FamilyMember(parentName, parentBirthDate));
        }

        private static void AddChildren(Person person, string name, string dateOfBirth)
        {
            person.AddChildren(new FamilyMember(name, dateOfBirth));
        }

        private static void AddCar(Person person, string carModel, int carSpeed)
        {
            person.Car.Model = carModel;
            person.Car.Speed = carSpeed;
        }

        private static void AddCompany(Person person, string companyName, string companyDepartment, decimal companySalary)
        {
            person.Company.Name = companyName;
            person.Company.Department = companyDepartment; 
            person.Company.Salary = companySalary;
        }
    }
}
