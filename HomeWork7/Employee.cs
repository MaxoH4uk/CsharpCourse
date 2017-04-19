using System;
using System.Collections.Generic;

namespace HomeWork7
{
    public class Employee : Human
    {
        public bool IsBusy { get; set; } = false;
        public uint PersonnelNumber { get; set; }
        public uint AccessLevel { get; set; }

        public Employee(string name, string surname, uint personnelNumber, uint accessLevel) 
            : base(name, surname)
        {
            this.PersonnelNumber = personnelNumber;
            this.AccessLevel = accessLevel;
        }

        public void ExcecuteOperation(Customer.Operation operation, Customer customer)
        {
            Operations operations = new Operations();

            switch (operation)
            {
                case (Customer.Operation.CloseAccount):
                    operations.CloseAccount(customer);
                    break;

                case (Customer.Operation.CreateAccount):
                    operations.CreateAccount(customer);
                    break;
            }
        }

        public void ExcecuteOperation(Customer.Operation operation, uint sum, uint accountNumber)
        {
            Operations operations = new Operations();

            switch (operation)
            {
                case (Customer.Operation.PutMoney):
                    operations.DepositMoney(sum, accountNumber);
                    break;

                case (Customer.Operation.WithrowMoney):
                    operations.WithdrawMoney(sum, accountNumber);
                    break;
            }
        }

    }
}
