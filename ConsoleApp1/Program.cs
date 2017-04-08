using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк матрицы: ");
            int howManyLine = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число столбцов матрицы: ");
            int howManyСolumn = Convert.ToInt32(Console.ReadLine());

            Matrix A = new Matrix(howManyLine, howManyСolumn);

            Console.WriteLine("Создана матрица А");

            A.CreatMatrix();
            A.PrintMatrix();
            Thread.Sleep(10);
            Matrix B = new Matrix(howManyLine, howManyСolumn);

            Console.WriteLine("Создана матрица B");

            B.CreatMatrix();
            B.PrintMatrix();

            Console.Read();
        }
    }
}
