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
            Balance -= Sum;
        }

        public void DepositMoney(uint Sum)
        {
            Balance += Sum;
        }
    }
}
