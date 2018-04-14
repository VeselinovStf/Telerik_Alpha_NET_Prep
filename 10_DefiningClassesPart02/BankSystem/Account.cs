namespace BankSystem
{
    public class Account: IAccountable
    {
        private Client client;
        private decimal balance;
        private decimal monthlyInterest;

        public Account(Client client, decimal balance, decimal monthlyInterest)
        {
            this.client = client;
            this.balance = balance;
            this.monthlyInterest = monthlyInterest;
        }

        public Client ClientName { get => client; }
        public decimal Balance { get => balance; }
        public decimal MonthlyProcent { get => monthlyInterest;}

        public void DepositeMoney(decimal money)
        {
            this.balance += money;
        }

        public void Withdraw(decimal money)
        {
            this.balance -= money;
        }
    }
}
