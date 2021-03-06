﻿using System;

namespace HomeWork7
{
    public class Account
    {
        public uint Number { get; private set; }
        public uint Balance { get; private set; }
        public Customer CustomerOwner { get; private set; }

        public Account(Customer customerOwner)
        {
            this.Number = customerOwner.CustomerId;
            this.CustomerOwner = customerOwner;
        }

        public void WithdrawMoney(uint Sum)
        {
            if (Balance >= Sum)
            {
                Balance -= Sum;
                Console.WriteLine($"Со счета №{Number} было списано {Sum} рублей. Баланс: {Balance} рублей!");
            }
            else
                Console.WriteLine($"Вы хотите снять {Sum} рублей, но Ваш баланс составляет: {Balance} рублей!");
        }

        public void DepositMoney(uint Sum)
        {
            Balance += Sum;
            Console.WriteLine($"На счет №{Number} было внесено {Sum} рублей. Баланс: {Balance} рублей!");
        }
    }
}
