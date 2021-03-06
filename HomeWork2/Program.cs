﻿using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                uint number;
                if (!TryEnterIntNumberFromConsole(out number))
                {
                    Console.WriteLine("Ошибка! Вы не ввели целое число");
                    continue;
                }

                int[] arrayOfRandomNumbers = new int[number];
                Random rnd = new Random();
                Console.WriteLine("\nМассив случайных чисел:");
                for (int i = 0; i < number; i++)
                {
                    arrayOfRandomNumbers[i] = rnd.Next(-1000, 1000);
                }
                printArray(arrayOfRandomNumbers);

                Console.WriteLine("\nОтсортированный массив:");
                SortArrayViaBubblesAlgorithm(arrayOfRandomNumbers);
                printArray(arrayOfRandomNumbers);
                Console.WriteLine("\nДля выхода из программы нажмите Esc\nДля повторного запуска программы нажмите любую кнопку\n");
            }
            while ((Console.ReadKey(true).Key != ConsoleKey.Escape));
        }

        static bool TryEnterIntNumberFromConsole(out uint number)
        {
            Console.Write("Введите целое число: ");
            string numberAsString = Console.ReadLine();
            return uint.TryParse(numberAsString, out number);
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

        static void printArray(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine($"{i + 1}-е число {inputArray[i]} ");
            }
        }
    }
}
