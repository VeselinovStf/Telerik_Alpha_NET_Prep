using System;

namespace BankSystem.MySolution
{
    public abstract class Account : IWithdraw
    {
        protected decimal balance;

        public Customer Customer { get; set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
        }

        public decimal MonthlyInterest { get; set; }

        public Account(Customer clientType, decimal balance) : this(clientType)
        {
            this.balance = balance;
        }

        public Account(Customer clientType, decimal balance, decimal monthlyInterest) : this(clientType, balance)
        {
            this.MonthlyInterest = monthlyInterest;
        }

        public Account(Customer clientType)
        {
            this.balance = 0;
            this.Customer = clientType;
            this.MonthlyInterest = this.MonthlyInterest / 100M;
        }

        public override string ToString()
        {
            return String.Format("{0} Balance:{1}", this.Customer.ToString(), this.Balance);
        }

        public virtual decimal CalculateIntereset(Int32 months)
        {
            return months * this.MonthlyInterest;
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }
    }
}