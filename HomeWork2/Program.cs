using System;

namespace HomeWork2
{
    class Program
    {
        static bool TryEnterIntNumberFromConsole(out uint number)
        {
            Console.Write("Введите целое число: ");
            string numberAsString = Console.ReadLine();

            if (uint.TryParse(numberAsString, out number))
            {
                return true;
            }

            else
                return false;
        }

        static int[] SortArrayViaBubblesAlgorithm(int[] arrayOfRandomNumbers)
        {
            for (int i = 0, arrayLength = arrayOfRandomNumbers.Length; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayOfRandomNumbers.Length - 1; j++)
                {
                    if (arrayOfRandomNumbers[j] > arrayOfRandomNumbers[j + 1])
                    {
                        int tmp = arrayOfRandomNumbers[j];
                        arrayOfRandomNumbers[j] = arrayOfRandomNumbers[j + 1];
                        arrayOfRandomNumbers[j + 1] = tmp;
                    }
                }
            }

            return arrayOfRandomNumbers;
        }

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                uint number;

                if (TryEnterIntNumberFromConsole(out number))
                {
                    int[] arrayOfRandomNumbers = new int[number];
                    Random rnd = new Random();

                    Console.WriteLine("\nМассив случайных чисел:");

                    for (int i = 0; i < number; i++)
                    {
                        arrayOfRandomNumbers[i] = rnd.Next(-1000, 1000);
                        Console.WriteLine($"{i + 1}-е число: {arrayOfRandomNumbers[i]} ");
                    }

                    Console.WriteLine("\nОтсортированный массив:");

                    SortArrayViaBubblesAlgorithm(arrayOfRandomNumbers);

                    for (int i = 0; i < arrayOfRandomNumbers.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-е число {arrayOfRandomNumbers[i]} ");
                    }

                    Console.WriteLine("\nДля выхода из программы нажмите Esc\nДля повторного запуска программы нажмите любую кнопку\n");
                }

                else
                {
                    Console.WriteLine("Ошибка! Вы не ввели целое число");
                    Console.ReadKey();
                }                
            }
            while ((Console.ReadKey(true).Key != ConsoleKey.Escape));
        }
    }
}
