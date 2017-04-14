using System;
using System.Collections.Generic;

namespace HomeWork7
{
    public class Account
    {
        public uint Number { get; set; }
        public uint Balance { get; set; }

        public Account(uint accountNumber)
        {
            Number = accountNumber;
        }

        public void WithdrawMoney(uint Sum)
        {
            if (Balance < Sum)
            {
                Console.WriteLine("На счету недостаточно денег!");
                Console.Read();
                return;
            }

            Balance -= Sum;
        }

        public void DepositMoney(uint Sum)
        {
            Balance += Sum;
        }
    }
}
