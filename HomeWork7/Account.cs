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
           if (Balance >= Sum)
            {
                Balance -= Sum;
                Console.WriteLine($"Со счета было списано {Sum} рублей. Баланс: {Balance}!");
            }
        }

        public void DepositMoney(uint Sum)
        {
            Balance += Sum;
            Console.WriteLine($"На счет было внесено {Sum} рублей. Баланс: {Balance}!");
        }
    }
}
