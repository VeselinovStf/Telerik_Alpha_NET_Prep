namespace BankSystem
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Client client, decimal balance, decimal monthlyInterest) 
            : base(client, balance, monthlyInterest)
        {
        }
    }
}
