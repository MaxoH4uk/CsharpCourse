using System;

namespace HomeWork7
{
    public class Program
    {
        static void Main(string[] args)
        {
#region начальная_инициализация
            Bank bank = new Bank();

            bank.Employees.Add(new Employee("Ivan", "Ivanov", 1, Role.Manager));
            bank.Employees.Add(new Employee("Sidor", "Sidorov", 4, Role.Administrator));

            bank.Customers.Add(new Customer("Semen", "Semenov", 11567));
            bank.Customers.Add(new Customer("Petr", "Petrov", 11568));
            bank.Customers.Add(new Customer("Semen", "Semenov", 11569));

            Bank.AccountsList.Add(new Account(bank.Customers[0]));
            Bank.AccountsList.Add(new Account(bank.Customers[1]));
#endregion           

            try
            {
                //внесем деньги на счет клиента
                var employee = bank.GetEmployee(Operation.DepositMoney, bank.Customers[0]);
                if (employee == null)
                    return;
                employee.ExcecuteOperation(Operation.DepositMoney, 123, bank.GetCustomerAccount(bank.Customers[0]), DateTime.Now);
                Console.WriteLine();

                //снимем деньги со счета клиента
                employee = bank.GetEmployee(Operation.WithdrawMoney, bank.Customers[0]);                
                if (employee == null)
                    return;
                employee.ExcecuteOperation(Operation.WithdrawMoney, 12, bank.GetCustomerAccount(bank.Customers[0]), DateTime.Now);
                Console.WriteLine();

                //создадим счет клиента
                employee = bank.GetEmployee(Operation.CreateAccount, bank.Customers[2]);
                if (employee == null)
                    return;
                employee.ExcecuteOperation(Operation.CreateAccount, bank.Customers[2], DateTime.Now);
                Console.WriteLine();

                //закроем счет клиента
                employee = bank.GetEmployee(Operation.CloseAccount, bank.Customers[2]);
                if (employee == null)
                    return;
                employee.ExcecuteOperation(Operation.CloseAccount, bank.Customers[2], DateTime.Now);
                Console.WriteLine();

                Console.Read();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
    }
}
