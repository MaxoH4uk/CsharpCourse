using System;
using System.Collections.Generic;

namespace HomeWork6
{
    public class Matrix
    {
        private static List<uint> matrixSize;
        private static List<int> transposedMatrix;

        public static bool TryEnterNumberFromConsole(out int number)
        {
            string numberAsString = Console.ReadLine();

            if (!(int.TryParse(numberAsString, out number)))
            {
                Console.Write("Ввели не число");
                return false;
            }
            return true;
        }

        public static int[,] GetSizeOfMatrix(string matrixSizeToString)
        {
            matrixSize = new List<uint>();
            for (int i = 0; i < matrixSizeToString.Length; i++)
            {
                if (!Char.IsDigit(matrixSizeToString[i]))
                {
                    continue;
                }
                else
                    matrixSize.Add(Convert.ToUInt32(matrixSizeToString[i].ToString()));
            }
            int[,] inputMatrix = new int[matrixSize[0], matrixSize[1]];
            return inputMatrix;
        }

        public static void PrintMatrixToConsole(int[,] inputMatrix)
        {
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                {
                    Console.Write(inputMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static int[,] CreateMatrix(int[,] inputMatrix)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            for (int i = 0; i < matrixSize[0]; i++)
            {
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    inputMatrix[i, j] = rnd.Next(-10, 10);
                }
            }
            return inputMatrix;
        }

        public static void PrintSumOfMatricesToConsole(int[,] firstMatrix, int[,] secondMatrix)
        {
            if (firstMatrix.GetLength(0) == secondMatrix.GetLength(0) && firstMatrix.GetLength(1) == secondMatrix.GetLength(1))
            {
                for (int i = 0; i < firstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < firstMatrix.GetLength(1); j++)
                    {
                        Console.Write((firstMatrix[i, j] + secondMatrix[i, j]) + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Матрицы имеют разную размерность. Сложение невозможно");
        }

        public static void PrintMatrixProductToConsole(int[,] firstMatrix, int[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
            {
                int[,] c = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int k = 0; k < c.GetLength(1); k++)
                    {
                        for (int j = 0; j < firstMatrix.GetLength(0); j++)
                        {
                            c[i, k] += firstMatrix[i, j] * secondMatrix[j, k];
                        }
                        Console.Write(c[i, k] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Число столбцов первой матрицы не равно числу строк второй. Умножение невозможно");
        }

        public static void PrintTheSumOfNumberWithMatrixToConsole(int[,] inputMatrix, int inputNumber)
        {
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                {
                    Console.Write(inputMatrix[i, j] + inputNumber + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTheProductOfNumberWithMatrixToConsole(int[,] inputMatrix, int inputNumber)
        {
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                {
                    Console.Write(inputMatrix[i, j] * inputNumber + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTheTransposedMatrixToConsole(int[,] inputMatrix)
        {
            transposedMatrix = new List<int>();

            for (int j = 0; j < inputMatrix.GetLength(1); j++)
            {
                for (int i = 0; i < inputMatrix.GetLength(0); i++)
                {
                    Console.Write(inputMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static int GetDeterminantOfMatrix(int[,] inputMatrix)
        {
            if (inputMatrix.Length == 4)
            {
                return inputMatrix[0, 0] * inputMatrix[1, 1] - inputMatrix[0, 1] * inputMatrix[1, 0];
            }

            int sign = 1, determinant = 0;
            for (int i = 0; i < inputMatrix.GetLength(1); i++)
            {
                int[,] minor = GetMinor(inputMatrix, i);
                determinant += sign * inputMatrix[0, i] * GetDeterminantOfMatrix(minor);
                sign = -sign;
            }
            return determinant;
        }

        private static int[,] GetMinor(int[,] inputMatrix, int n)
        {
            int[,] result = new int[inputMatrix.GetLength(0) - 1, inputMatrix.GetLength(0) - 1];
            for (int i = 1; i < inputMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < n; j++)
                    result[i - 1, j] = inputMatrix[i, j];
                for (int j = n + 1; j < inputMatrix.GetLength(0); j++)
                    result[i - 1, j - 1] = inputMatrix[i, j];
            }
            return result;
        }
    }
}
