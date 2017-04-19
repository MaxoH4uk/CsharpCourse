using System;
using System.Collections.Generic;

namespace HomeWork7
{
    
    public class Customer : Human
    {
        public enum Operation
        {
            CreateAccount = 1,
            CloseAccount,
            WithrowMoney,
            PutMoney
        }

        public uint CustomerId { get; set; }        

        public Customer(string name, string surname, uint customerId) 
            : base(name, surname)
        {
            this.CustomerId = customerId;   
        }

        public Employee GetEmployee(Operation operation, List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                if (operation == Operation.CreateAccount ||
                    operation == Operation.CreateAccount  &&
                    employee.AccessLevel >= 1 &&
                    !employee.IsBusy)
                {
                    return employee;
                }

                if ((operation == Operation.PutMoney ||
                    operation == Operation.WithrowMoney) &&
                    employee.AccessLevel >= 2 &&
                    !employee.IsBusy)
                {
                    return employee;
                }                
            }

            return null;
        }
    }
}
