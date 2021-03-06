﻿using System;

namespace BankSystem.MySolution
{
    internal class MortgageAccount : Account
    {
        public MortgageAccount(Customer clientType, decimal balance, decimal monthlyInterest)
            : base(clientType, balance, monthlyInterest)
        {
        }

        public override decimal CalculateIntereset(int months)
        {
            if (this.Customer.ClientType.Equals(CustomerType.Company))
            {
                return this.CalculateCompanyAccountInterest(months);
            }
            else if (this.Customer.ClientType.Equals(CustomerType.Individual))
            {
                return this.CalculateIndividualAccountInterest(months);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        private decimal CalculateIndividualAccountInterest(int months)
        {
            const int monthsWithoudIntereset = 6;
            decimal interest = 0;

            if (months > monthsWithoudIntereset)
            {
                interest += base.CalculateIntereset(months - monthsWithoudIntereset);
            }

            return interest;
        }

        private decimal CalculateCompanyAccountInterest(int months)
        {
            const int monntsInAYear = 12;
            decimal interest = 0;

            interest += base.CalculateIntereset(months % monntsInAYear) / 2;

            if (months > monntsInAYear)
            {
                interest += base.CalculateIntereset(months - monntsInAYear);
            }

            return interest;
        }
    }
}