/* 
 * Lecture exercises and tests
 * The code is little messy!
 * This code is for testing and learning
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Engine.CLI
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dbContex = new HomeCalculatorDbContex();

            //Print all data in db
            PrintAllData(dbContex);
            
            //EditALl(dbContex);

            dbContex.Expencesses.Add(new Expencess
            {
                
                BlockTax = 10,
                FlatTax = 20,
                Water = 30,
                Electricity = 40,
                User = new User
                {
                    
                    Name = "NEW"
                }
            });
            dbContex.SaveChanges();
            PrintAllData(dbContex);
            
          
        }

        private static void EditALl(HomeCalculatorDbContex dbContex)
        {
            Console.WriteLine("-------EDIT DATA----");
            var users = dbContex.Users;
            foreach (var user in users)
            {
                user.Name = "xxxxx";
            }

            var expencess = dbContex.Expencesses;
            foreach (var expence in expencess)
            {
                expence.BlockTax = 0;
                expence.FlatTax = 0;
                expence.Water = 0;
                expence.Electricity = 0;
            }

            dbContex.SaveChanges();
        }

        private static void PrintAllData(HomeCalculatorDbContex dbContex)
        {
            //Print users table
            ListAllUsers(dbContex);

            //Print Expencess table with user
            ListAllExpencess(dbContex);
        }

        private static void ListAllUsers(HomeCalculatorDbContex dbContex)
        {
            Console.WriteLine("USER NAMES");
            var users = dbContex.Users;

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name}");
            }
        }

        private static void ListAllExpencess(HomeCalculatorDbContex dbContex)
        {
            Console.WriteLine("EXPENCESS");
            var expencess = dbContex.Expencesses;

            foreach (var expence in expencess)
            {
                Console.WriteLine($"{expence.User.Name} - {expence.FlatTax } {expence.Electricity } {expence.Water } {expence.BlockTax } ");
            }
                
        }
    }
}
