namespace BankSystem.MySolution
{
    public class Customer
    {
        public Customer(ClientTypes clientType, string name)
        {
            this.ClientType = clientType;
            this.Name = name;
        }

        public ClientTypes ClientType { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "Customer name : " + this.Name;
        }
    }
}