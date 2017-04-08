using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrixSize = new int[1, 1];
            int[,] secondMatrixSize = new int[1, 1];
            int numberForAdditionWithMatrices;
            int numberForMultiplicationByMatrices;

            Console.Write("Введите количество строк и столбцов первой матрицы: ");
            string firstMatrixSizeToString = Console.ReadLine();

            Console.Write("Введите количество строк и столбцов второй матрицы : ");
            string secondMatrixSizeToString = Console.ReadLine();

            Console.Write("Введите число для сложения с матрицами: ");
            if (!Matrix.TryEnterNumberFromConsole(out numberForAdditionWithMatrices))
            {
                Console.Read();
                return;
            }

            Console.Write("Введите число для умножения на матрицы: ");
            if (!Matrix.TryEnterNumberFromConsole(out numberForMultiplicationByMatrices))
            {
                Console.Read();
                return;
            }
            Console.WriteLine();

            try
            {
                firstMatrixSize = Matrix.GetSizeOfMatrix(firstMatrixSizeToString);
                secondMatrixSize = Matrix.GetSizeOfMatrix(secondMatrixSizeToString);
            }
            catch
            {
                Console.WriteLine("Нужно вводить количество строк и количество столбцов!");
                Console.Read();
                return;
            }

            Console.WriteLine("Первая матрица: ");
            int[,] firstMatrix = Matrix.CreateMatrix(firstMatrixSize);
            Matrix.PrintMatrixToConsole(firstMatrix);
            Console.WriteLine();

            Console.WriteLine("Вторая матрица: ");
            int[,] secondMatrix = Matrix.CreateMatrix(secondMatrixSize);
            Matrix.PrintMatrixToConsole(secondMatrix);
            Console.WriteLine();

            Console.WriteLine("Результат сложения матриц: ");
            Matrix.PrintSumOfMatricesToConsole(firstMatrix, secondMatrix);
            Console.WriteLine();

            Console.WriteLine("Резльтат сожения первой матрицы с числом: ");
            Matrix.PrintTheSumOfNumberWithMatrixToConsole(firstMatrix, numberForAdditionWithMatrices);
            Console.WriteLine();

            Console.WriteLine("Резльтат сложения второй матрицы с числом: ");
            Matrix.PrintTheSumOfNumberWithMatrixToConsole(secondMatrix, numberForAdditionWithMatrices);
            Console.WriteLine();

            Console.WriteLine("Резльтат произведения матриц: ");
            Matrix.PrintMatrixProductToConsole(firstMatrix, secondMatrix);
            Console.WriteLine();

            Console.WriteLine("Резльтат умножения первой матрицы на число: ");
            Matrix.PrintTheProductOfNumberWithMatrixToConsole(firstMatrix, numberForAdditionWithMatrices);
            Console.WriteLine();

            Console.WriteLine("Резльтат умножения второй матрицы на число: ");
            Matrix.PrintTheProductOfNumberWithMatrixToConsole(secondMatrix, numberForAdditionWithMatrices);
            Console.WriteLine();

            Console.WriteLine("Резльтат транспонирования первой матрицы: ");
            Matrix.PrintTheTransposedMatrixToConsole(firstMatrix);
            Console.WriteLine();

            Console.WriteLine("Резльтат транспонирования второй матрицы: ");
            Matrix.PrintTheTransposedMatrixToConsole(secondMatrix);
            Console.WriteLine();

            Console.Write("Определитель первой матрицы: ");
            Console.WriteLine(Matrix.GetDeterminantOfMatrix(firstMatrix));
            Console.WriteLine();

            Console.Write("Определитель второй матрицы: ");
            Console.WriteLine(Matrix.GetDeterminantOfMatrix(secondMatrix));
            Console.WriteLine();

            Console.Read();
        }
    }
}
