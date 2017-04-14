using System;
using System.Collections.Generic;

namespace HomeWork7
{
    public class Operations
    {
       public void CreateAccount(Employee employee, uint customerId)
        {
            if (employee.AccessLevel < 1)
            {
                Console.WriteLine("Слишком низкий уровень доступа!");
                Console.Read();
                return;
            }
        }

        public void CloseAccount(Employee employee, uint customerId)
        {
            if (employee.AccessLevel < 1)
            {
                Console.WriteLine("Слишком низкий уровень доступа!");
                Console.Read();
                return;
            }
        }

        public void DepositMoney(Employee employee, uint sum, uint accountNumber)
        {
            if (employee.AccessLevel < 2)
            {
                Console.WriteLine("Слишком низкий уровень доступа!");
                Console.Read();
                return;
            }

            Account account = new Account(accountNumber);
            account.DepositMoney(sum);
        }

        public void WithdrawMoney(Employee employee, uint sum, uint accountNumber)
        {
            if (employee.AccessLevel < 2)
            {
                Console.WriteLine("Слишком низкий уровень доступа!");
                Console.Read();
                return;
            }

            Account account = new Account(accountNumber);
            account.WithdrawMoney(sum);
        }
    }
}
