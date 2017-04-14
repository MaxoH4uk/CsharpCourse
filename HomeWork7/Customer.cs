using System;
using System.Collections.Generic;

namespace HomeWork7
{
    public class Customer : Human
    {
        public uint CustomerId { get; set; }

        public Customer(string name, string surname, uint customerId) 
            : base(name, surname)
        {
            this.CustomerId = customerId;   
        }
    }
}
