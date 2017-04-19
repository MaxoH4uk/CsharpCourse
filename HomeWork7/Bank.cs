using System;
using System.Collections.Generic;

namespace HomeWork7
{
    public class Bank
    {
        public List<Account> AccountsList = new List<Account>();
        public List<Customer> Customers = new List<Customer>();
        public List<Employee> Employees = new List<Employee>();

        public void AcceptNewEmployees(string name, string surname, uint personnelNumber, uint accessLevel)
        {
            Employees.Add(new Employee(name, surname, personnelNumber, accessLevel));
        }

        public void AcceptCustomers(string name, string surname, uint customerId)
        {
            Customers.Add(new Customer(name, surname, customerId));
        }
    }
}
