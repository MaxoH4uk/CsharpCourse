using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число 1: ");
            string number1AsString =  Console.ReadLine();

            Console.Write("Введите число 2: ");
            string number2AsString = Console.ReadLine();

            Console.Write("Введите число 3: ");
            string number3AsString = Console.ReadLine();

            uint number1;
            if(!uint.TryParse(number1AsString, out number1))
            {
                Console.WriteLine("Ввели не число");
                return;
            }

            uint number2;
            if (!uint.TryParse(number2AsString, out number2))
            {
                Console.WriteLine("Ввели не число");
                return;
            }

            uint number3;
            if (!uint.TryParse(number3AsString, out number3))
            {
                Console.WriteLine("Ввели не число");
                return;
            }

            uint minNumber = Math.Min(Math.Min(number1, number2), number3);

            Console.Write("Минимальное число: ");
            Console.WriteLine(minNumber);

            Console.Write("Числа Фибоначчи меньшие 1го числа: ");
            uint firstFibNumber = 0;
            uint secondFibNumber = 1;
            if(number1 != 0)
            {
                Console.Write(firstFibNumber + " ");
            }

            while(secondFibNumber < number1)
            {
                Console.Write(secondFibNumber + " ");
                uint nextSecondNumber = firstFibNumber + secondFibNumber;
                firstFibNumber = secondFibNumber;
                secondFibNumber = nextSecondNumber;
            }
            Console.WriteLine();

            Console.Write("Числа Фибоначчи меньшие 2го числа: ");
             firstFibNumber = 0;
             secondFibNumber = 1;
            if (number2 != 0)
            {
                Console.Write(firstFibNumber + " ");
            }

            while (secondFibNumber < number2)
            {
                Console.Write(secondFibNumber + " ");
                uint nextSecondNumber = firstFibNumber + secondFibNumber;
                firstFibNumber = secondFibNumber;
                secondFibNumber = nextSecondNumber;
            }
            Console.WriteLine();

            Console.Write("Числа Фибоначчи меньшие 3го числа: ");
             firstFibNumber = 0;
             secondFibNumber = 1;
            if (number3 != 0)
            {
                Console.Write(firstFibNumber + " ");
            }

            while (secondFibNumber < number3)
            {
                Console.Write(secondFibNumber + " ");
                uint nextSecondNumber = firstFibNumber + secondFibNumber;
                firstFibNumber = secondFibNumber;
                secondFibNumber = nextSecondNumber;
            }
            Console.Read();

           

        }
    }
}
