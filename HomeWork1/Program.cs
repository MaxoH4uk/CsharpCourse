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
                int[] nums = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        Console.Write($"Введите {i + 1}-е число: ");
                        nums[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Beep();
                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели недопустимый символ. Попробуйте еще раз.");
                        i--;
                    }
                }

                Console.WriteLine($"\nМинимальным является число: {nums.Min()}");
                Console.WriteLine("\nПоследовательность Фибоначчи:\n");

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(Fib(nums[i]));
                }

                Console.WriteLine("\nЕсли Вам надоела эта бесполезная программа, нажмите Esc\nЕсли Вы хотите попробовать еще раз крашнуть программу, нажмите любую кнопку\n");
            }
            while ((Console.ReadKey(true).Key != ConsoleKey.Escape));
        }

        static string Fib(int a)
        {

            string s = "";
            List<int> seq = new List<int>();

            if (a <= 1)
            {
                return "empty";
            }

            else if (a == 2)
            {
                return "0 1 1";
            }

            else
            {
                seq.Add(0);
                seq.Add(1);
                seq.Add(1);

                for (int i = 3; seq[i - 1] + seq[i - 2] < a; i++)
                {
                    seq.Add(seq[i - 1] + seq[i - 2]);
                }

                for (int i = 0; i < seq.Count; i++)
                {
                    s += seq[i] + " ";
                }

                return s;
            }
        }
    }
}
