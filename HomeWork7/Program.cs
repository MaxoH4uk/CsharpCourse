using System;
using System.Collections.Generic;

namespace HomeWork7
{
    class Program
    {    
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            bank.Employees.Add(new Employee("Ivan", "Ivanov", 1, 1));
            bank.Employees.Add(new Employee("Sidor", "Sidorov", 4, 2));

            bank.Customers.Add(new Customer("Semen", "Semenov", 1));
            bank.Customers.Add(new Customer("Petr", "Petrov", 2));

            var querry = Customer.Operation.PutMoney;
            var employee = bank.Customers[0].GetEmployee(querry, bank.Employees);            

            if (employee == null)
            {
                Console.WriteLine("Свободных сотрудников, соответствующих Вашему запросу сейчас нет!");
                Console.Read();
                return;
            }

            employee.IsBusy = true;
            employee.ExcecuteOperation(querry, 123, bank.Customers[0].CustomerId);
            querry = Customer.Operation.WithrowMoney;
            employee.ExcecuteOperation(querry, 12, bank.Customers[0].CustomerId);

            Console.Read();
        }      
    }
}
