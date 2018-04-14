namespace BankSystem
{
    public class CreditAccount : Account
    {
        public CreditAccount(Client client, decimal balance, decimal monthlyInterest) 
            : base(client, balance, monthlyInterest)
        {
        }
    }
}
