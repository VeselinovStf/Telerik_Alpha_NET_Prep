namespace BankSystem
{
    public class DepositAccount : Account
    {
        public DepositAccount(Client client, decimal balance, decimal monthlyInterest) 
            : base(client, balance, monthlyInterest)
        {
        }
    }
}
