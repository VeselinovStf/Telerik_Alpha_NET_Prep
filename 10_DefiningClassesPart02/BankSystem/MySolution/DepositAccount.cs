using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.MySolution
{
    internal class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer clientType, decimal balance, decimal monthlyInterest)
            : base(clientType, balance, monthlyInterest)
        {
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

        void IWithdraw.Deposit(decimal amount)
        {
            this.balance -= amount;
        }
    }
}