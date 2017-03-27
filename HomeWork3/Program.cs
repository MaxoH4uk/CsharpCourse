using System;
using System.Linq;

namespace HomeWork3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string inputString = Console.ReadLine();
            WorkWithString workWithOneString = new WorkWithString(inputString);
            if (workWithOneString.isPolindrom())
            {
                Console.WriteLine("Входная строка - палиндром");
            }
            else
                Console.WriteLine("Входная строка - не палиндром");
            Console.WriteLine($"Перевернутая строка: {workWithOneString.returnReverseString()}");
            Console.WriteLine($"Количество слов в строке равно: {workWithOneString.countsHowManyWordsPerLine()}");
            Console.Read();
        }        
    }
}
