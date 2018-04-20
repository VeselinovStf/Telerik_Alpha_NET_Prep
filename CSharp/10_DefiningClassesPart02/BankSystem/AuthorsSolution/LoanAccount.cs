using System;

namespace BankSystem
{
    internal class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override decimal CalculateIntereset(int months)
        {
            if (this.Customer.Type == CustomerType.Company)
            {
                return this.CalculateCompanyAccountInterest(months);
            }
            else if (this.Customer.Type == CustomerType.Individual)
            {
                return this.CalculateIndividualAccountInterest(months);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        private decimal CalculateIndividualAccountInterest(Int32 months)
        {
            const Int32 monthsWithoudIntereset = 3;
            decimal interest = 0;

            if (months > monthsWithoudIntereset)
            {
                interest += base.CalculateIntereset(months - monthsWithoudIntereset);
            }

            return interest;
        }

        private decimal CalculateCompanyAccountInterest(Int32 months)
        {
            const Int32 monthsWithoudIntereset = 2;
            decimal interest = 0;

            if (months > monthsWithoudIntereset)
            {
                interest += base.CalculateIntereset(months - monthsWithoudIntereset);
            }

            return interest;
        }
    }
}