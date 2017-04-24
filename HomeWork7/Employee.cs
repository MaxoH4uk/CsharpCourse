using System;

namespace HomeWork7
{
    public enum Role
    {
        Manager,
        Administrator
    }

    public class Employee : Human
    {
        public bool IsBusy { get; private set; } = false;
        public uint PersonnelNumber { get; private set; }
        public Role Role { get; }

        public Employee(string name, string surname, uint personnelNumber, Role role)
            : base(name, surname)
        {
            this.PersonnelNumber = personnelNumber;
            this.Role = role;
        }

        public void ExcecuteOperation(Operation operation, Customer customer, DateTime time)
        {
            if (time.Hour < 9 || time.Hour > 23)
            {
                throw new Exception("Банк работает с 9:00 до 23:00. Обратитесь позже!");
            }

            this.IsBusy = true;
            Operations operations = new Operations();

            switch (operation)
            {
                case (Operation.CloseAccount):
                    operations.CloseAccount(customer.CustomerId);
                    this.IsBusy = false;
                    break;

                case (Operation.CreateAccount):
                    operations.CreateAccount(customer);
                    this.IsBusy = false;
                    break;
            }
        }

        public void ExcecuteOperation(Operation operation, uint sum, Account account, DateTime time)
        {
            if (time.Hour < 9 || time.Hour > 23)
            {
                throw new Exception("Банк работает с 9:00 до 23:00. Обратитесь позже!");
            }

            this.IsBusy = true;
            Operations operations = new Operations();

            switch (operation)
            {
                case (Operation.DepositMoney):
                    operations.DepositMoney(sum, account);
                    this.IsBusy = false;
                    break;

                case (Operation.WithdrawMoney):
                    operations.WithdrawMoney(sum, account);
                    this.IsBusy = false;
                    break;
            }
        }
    }
}
