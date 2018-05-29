/*
 * Exercise from lecture
 * 
 * Build Simple Library
 */

using EFCodeFirst.CLI.Engine.StoreProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.CLI.Engine
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dbContext = new StoreDbContext();
            var makers = dbContext.Makers.FirstOrDefault();

            Console.WriteLine(makers);
        }
    }
}
