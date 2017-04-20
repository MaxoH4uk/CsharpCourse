using System;
using System.Collections.Generic;

namespace HomeWork7
{
    public class Bank
    {
        public static List<Account> AccountsList = new List<Account>();
        public List<Customer> Customers = new List<Customer>();
        public List<Employee> Employees = new List<Employee>();

        public void AcceptNewEmployees(string name, string surname, uint personnelNumber, Role role)
        {
            Employees.Add(new Employee(name, surname, personnelNumber, role));
        }

        public void AcceptCustomers(string name, string surname, uint customerId)
        {
            Customers.Add(new Customer(name, surname, customerId));
        }

        public Account GetCustomerAccount(Customer customer)
        {
            foreach (var acc in AccountsList)
            {
                if (customer.CustomerId == acc.Number)
                {
                    return acc;
                }
            }
            return null;
        }

        public Employee GetEmployee(Operation operation, Customer customer)
        {
            foreach (var employee in Employees)
            {
                if (operation == Operation.CreateAccount ||
                    operation == Operation.CloseAccount &&
                    employee.Role == Role.Manager &&
                    !employee.IsBusy)
                {
                    return employee;
                }

                if ((operation == Operation.DepositMoney ||
                    operation == Operation.WithdrawMoney) &&
                    employee.Role == Role.Administrator &&
                    !employee.IsBusy)
                {
                    return employee;
                }
            }

            Console.WriteLine("Свободных сотрудников, соответствующих Вашему запросу сейчас нет!");
            Console.Read();
            return null;
        }
    }
}
