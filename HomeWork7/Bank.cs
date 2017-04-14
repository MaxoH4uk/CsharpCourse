using System;
using System.Collections.Generic;

namespace HomeWork7
{
    public class Bank
    {
        public List<Account> accountsList { get; private set; }
        public List<Customer> customers = new List<Customer>();
        public List<Employee> Employees = new List<Employee>();

        public void AcceptNewEmployees(string name, string surname, uint personnelNumber, uint accessLevel, double currentTime)
        {
            if (!IsOpenedBank(currentTime))
            {
                Console.WriteLine("Банк работает с 9.00 до 18.00. Обратитесь в это время!");
                Console.Read();
                return;

            }

            Employees.Add(new Employee(name, surname, personnelNumber, accessLevel));
        }

        public void AcceptCustomers(string name, string surname, uint customerId, double currentTime)
        {
            if (!IsOpenedBank(currentTime))
            {
                Console.WriteLine("Банк работает с 9.00 до 18.00. Обратитесь в это время!");
                Console.Read();
                return;

            }

            customers.Add(new Customer(name, surname, customerId));
        }

        public bool IsOpenedBank(double currentTime)
        {
            return currentTime > 9.00 && currentTime < 18.00 ? true : false;
        }
    }
}
