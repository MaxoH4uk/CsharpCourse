using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                List <int> numbers = new List <int>();
                List<int> result = new List<int>();
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        Console.Write($"Введите {i + 1}-е число: ");
                        numbers.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Beep();
                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели недопустимый символ. Попробуйте еще раз.");
                        i--;
                    }
                }

                Console.WriteLine($"\nМинимальным является число: {numbers.Min()}");
                Console.WriteLine("\nПоследовательность Фибоначчи:\n");
                for (int i = 0; i < 3; i++)
                {
                    string s = "";
                    result.AddRange(Fib(numbers[i]));
                    for (int j = 0; j < result.Count; j++)
                    {
                        s += result[j] + " ";
                    }
                    Console.WriteLine(s);
                    result.Clear();
                }
                Console.WriteLine("\nЕсли Вам надоела эта бесполезная программа, нажмите Esc\nЕсли Вы хотите попробовать еще раз крашнуть программу, нажмите любую кнопку\n");
            }
            while ((Console.ReadKey(true).Key != ConsoleKey.Escape));
        }

        static List <int> Fib(int a)
        {            
            List<int> seq = new List<int>();
            seq.Add(0);            
            if (a <= 1)
            {                
                return seq;
            }
            seq.Add(1);
            seq.Add(1);
            if (a == 2)
            {
                return seq;
            }
            else
            {
                for (int i = 3, cur = seq[i - 1] + seq[i - 2]; cur < a; cur += seq[i - 1], i++)
                {
                    seq.Add(cur);
                }                
                return seq;
            }
        }
    }
}
