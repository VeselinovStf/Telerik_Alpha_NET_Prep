using System;
using System.Collections.Generic;

namespace BankAccountSystem
{
    public class StartUp
    {
        private static void Main()
        {
            Dictionary<int, BankAccount> accounts =
                 new Dictionary<int, BankAccount>();

            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                string[] parameters = input.Split(' ');
                string command = parameters[0];
                int id = int.Parse(parameters[1]);
                decimal amount = 0;

                switch (command)
                {
                    case "Create":
                        CreateAccount(id, accounts);
                        break;

                    case "Deposit":
                        amount = decimal.Parse(parameters[2]);
                        DepositToAccount(id, accounts, amount);
                        break;

                    case "Withdraw":
                        amount = decimal.Parse(parameters[2]);
                        WithdrawFromAccount(id, accounts, amount);
                        break;

                    case "Print":
                        PrintAccount(id, accounts);
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintAccount(int id, Dictionary<int, BankAccount> accounts)
        {
            if (ValidateId(id, accounts))
            {
                Console.WriteLine(accounts[id]);
            }
        }

        private static void WithdrawFromAccount(int id, Dictionary<int, BankAccount> accounts, decimal amount)
        {
            if (ValidateId(id, accounts))
            {
                if (accounts[id].Balance - amount < 0)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Withdraw(amount);
                }
            }
        }

        private static void DepositToAccount(int id, Dictionary<int, BankAccount> accounts, decimal amount)
        {
            if (ValidateId(id, accounts))
            {
                accounts[id].Deposit(amount);
            }
        }

        private static bool ValidateId(int id, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return false;
            }

            return true;
        }

        private static void CreateAccount(int id, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                accounts[id] = new BankAccount();
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }
    }
}