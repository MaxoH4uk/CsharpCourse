using System;

namespace HomeWork3
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Введите строку: ");
                string inputString = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(inputString))
                {
                    Console.WriteLine("Вы ввели пустую строку. Попробуйте еще раз");
                    continue;
                }
                WorkWithString workWithOneString = new WorkWithString(inputString);
                if (workWithOneString.isPolindrom())
                {
                    Console.WriteLine("Входная строка - палиндром");
                }
                else
                    Console.WriteLine("Входная строка - не палиндром");
                Console.WriteLine($"Перевернутая строка: {workWithOneString.returnReverseString(inputString)}");
                Console.WriteLine($"Количество слов в строке равно: {workWithOneString.countsHowManyWordsPerLine()}");
                Console.WriteLine("\nДля выхода из программы нажмите Esc\nДля повторного запуска программы нажмите любую кнопку\n");
            }
            while ((Console.ReadKey(true).Key != ConsoleKey.Escape));
        }
    }
}
