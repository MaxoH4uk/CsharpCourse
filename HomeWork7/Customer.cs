namespace HomeWork7
{
    public enum Operation
    {
        CreateAccount,
        CloseAccount,
        WithdrawMoney,
        DepositMoney
    }

    public class Customer : Human
    {
        public uint CustomerId { get; private set; }

        public Customer(string name, string surname, uint customerId)
            : base(name, surname)
        {
            this.CustomerId = customerId;
        }
    }
}
