using System;

namespace BankSystem
{
    internal class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        void IWithdraw.Deposit(decimal amount)
        {
            if (this.balance < amount)
                throw new InvalidOperationException();

            this.balance -= amount;
        }

        public override decimal CalculateIntereset(int months)
        {
            if (this.Balance > 1000)
            {
                return base.CalculateIntereset(months);
            }
            else
            {
                return 0;
            }
        }
    }
}