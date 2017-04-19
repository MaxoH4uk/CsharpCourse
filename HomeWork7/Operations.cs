using System;
using System.Collections.Generic;

namespace HomeWork7
{
    public class Operations
    {
        public Account CreateAccount(Customer customer)
        {
            return new Account(customer.CustomerId);
        }

        public void CloseAccount(Customer customer)
        {
            Bank bank = new Bank();            

            foreach (var acc in bank.AccountsList)
            {
                if (acc.Number == customer.CustomerId)
                {
                    bank.AccountsList.Remove(acc);
                }
            }
        }

        public void DepositMoney(uint sum, uint accountNumber)
        {
            Account account = new Account(accountNumber);
            account.DepositMoney(sum);
        }

        public void WithdrawMoney(uint sum, uint accountNumber)
        {
            Account account = new Account(accountNumber);
            account.WithdrawMoney(sum);
        }
    }
}
