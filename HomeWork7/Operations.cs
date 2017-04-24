using System;

namespace HomeWork7
{
    public class Operations
    {
        public void CreateAccount(Customer customer)
        {
            Bank.AccountsList.Add(new Account(customer));
            Console.WriteLine($"Счет с номером {customer.CustomerId}, владелец которого {customer.Name} {customer.Surname} был успешно открыт!");
        }

        public void CloseAccount(uint customerId)
        {
            foreach (var acc in Bank.AccountsList)
            {
                if (acc.Number == customerId)
                {
                    Bank.AccountsList.Remove(acc);
                    Console.WriteLine($"Счет №{acc.Number} был закрыт!");
                    break;
                }
            }
        }

        public void DepositMoney(uint sum, Account account)
        {
            account.DepositMoney(sum);
        }

        public void WithdrawMoney(uint sum, Account account)
        {
            account.WithdrawMoney(sum);
        }
    }
}
