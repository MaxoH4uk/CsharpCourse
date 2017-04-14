using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint matrixRowsCount;
            uint matrixColumnsCount;

            Console.Write("Введите количество строк матрицы: ");
            if (!TryEnterNumberFromConsole(out matrixRowsCount))
            {
                Console.Read();
                return;
            }

            Console.Write("Введите количество столбцов матрицы: ");
            if (!TryEnterNumberFromConsole(out matrixColumnsCount))
            {
                Console.Read();
                return;
            }
            Console.WriteLine();

            Console.WriteLine("Матрица А: ");
            Matrix A = new Matrix(matrixRowsCount, matrixColumnsCount);
            PrintMatrixToConsole(A);
            Console.WriteLine();

            Console.WriteLine("Матрица B: ");
            Matrix B = new Matrix(matrixRowsCount, matrixColumnsCount);
            PrintMatrixToConsole(B);
            Console.WriteLine();

            Console.WriteLine("A + B: ");
            PrintMatrixToConsole(A.GetSumOfMatrices(B));
            Console.WriteLine();

            Console.WriteLine("A + 5: ");
            PrintMatrixToConsole(A.GetSumOfMatrixAndNumber(5));
            Console.WriteLine();

            Console.WriteLine("A * B: ");
            PrintMatrixToConsole(A.GetMatrixProduct(B));
            Console.WriteLine();

            Console.WriteLine("B * 5: ");
            PrintMatrixToConsole(B.GetProductOfNumberWithMatrix(5));
            Console.WriteLine();

            Console.WriteLine("Транспонированная матрица А: ");
            PrintMatrixToConsole(A.GetTransposedMatrix());
            Console.WriteLine();

            ToeplitzMatrix tm = new ToeplitzMatrix(matrixRowsCount, matrixColumnsCount);
            Console.WriteLine(tm.GetItem(2, 2));

            Console.Write("Определитель матрицы B: ");
            Console.WriteLine(B.GetDeterminantOfMatrix());
            Console.WriteLine();

            /*Console.WriteLine("Теплицева матрица: ");
            Matrix toeplitz = new Matrix(matrixRowsCount, matrixColumnsCount);
            toeplitzMatrix = new int[matrixRowsCount, matrixColumnsCount];
            toeplitzMatrix = toeplitz.CreateMatrix();
            PrintMatrixToConsole(secondMatrix);
            Console.WriteLine();*/

            Console.Read();
        }

        public static bool TryEnterNumberFromConsole(out uint number)
        {
            string numberAsString = Console.ReadLine();

            if (!(uint.TryParse(numberAsString, out number)))
            {
                Console.Write("Ввели не число");
                return false;
            }
            return true;
        }

        public static void PrintMatrixToConsole(Matrix matrix)
        {
            for (uint i = 0; i < matrix.MatrixRowsCount; i++)
            {
                for (uint j = 0; j < matrix.MatrixColumnsCount; j++)
                {
                    Console.Write(matrix.GetItem(i, j) + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
