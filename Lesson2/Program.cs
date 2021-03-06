﻿using Common;
using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint arrayLength;
            if (!Utils.TryEnterNumberFromConsole(out arrayLength))
            {
                Console.Read();
                return;
            }

            double[] array = new double[arrayLength];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * 100;
            }
            PrintDoubleArray(array);
            Console.WriteLine();

            for (int j = array.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        double temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            PrintDoubleArray(array);
            Console.WriteLine();
            Console.Read();
        }

        static void PrintDoubleArray(double[] arayForPrint)
        {
            for (int i = 0; i < arayForPrint.Length; i++)
            {
                Console.Write(arayForPrint[i].ToString("0.00") + " ");
            }
        }
    }
}
