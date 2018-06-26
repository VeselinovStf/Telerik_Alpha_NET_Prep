using ArrayList;
using System;

namespace UseOfAList
{
    internal class StartUp
    {
        private static void Main()
        {
            AList<string> shoppingList = new AList<string>();

            shoppingList.Add("Milk");

            shoppingList.Add("Honey");

            shoppingList.Add("Olives");

            shoppingList.Add("Beer");

            shoppingList.RemoveElement("Olives");

            Console.WriteLine("We need to buy:");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            Console.WriteLine("Do we have to buy Bread? " +
                  shoppingList.Contains("Bread"));
        }
    }
}