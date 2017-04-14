using System;

namespace HomeWork6
{
    class Matrix
    {
        public uint MatrixRowsCount { get; private set; }
        public uint MatrixColumnsCount { get; private set; }

        private int[,] data;

        public Matrix(uint matrixRowsCount, uint matrixColumnsCount)
        {
            MatrixRowsCount = matrixRowsCount;
            MatrixColumnsCount = matrixColumnsCount;
            FillMatrix();
        }

        public virtual int GetItem(uint x, uint y)
        {
            if (x < MatrixRowsCount && y < MatrixColumnsCount)
            {
                return data[x, y];
            }

            else
                return 0;
        }

        public virtual void SetItem(uint x, uint y, int value)
        {
            if (x < MatrixRowsCount && y < MatrixColumnsCount)
            {
                data[x, y] = value;
            }
        }

        protected virtual void FillMatrix()
        {
            data = new int[MatrixRowsCount,MatrixColumnsCount];
            Random rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for (int i = 0; i < MatrixRowsCount; i++)
            {
                for (int j = 0; j < MatrixColumnsCount; j++)
                {
                    data[i, j] = rnd.Next(-10, 10);
                }
            }
        }

        public virtual Matrix GetSumOfMatrices(Matrix secondMatrix)
        {
            var sumOfMatrices = new Matrix(MatrixRowsCount, MatrixColumnsCount);

            for (uint i = 0; i < MatrixRowsCount; i++)
            {
                for (uint j = 0; j < MatrixColumnsCount; j++)
                {
                    sumOfMatrices.SetItem(i, j, this.GetItem(i, j) + secondMatrix.GetItem(i, j));
                }
            }

            return sumOfMatrices;
        }

        public virtual Matrix GetSumOfMatrixAndNumber(int number)
        {
            var sumOfMatrixAndNumber = new Matrix(MatrixRowsCount, MatrixColumnsCount);

            for (uint i = 0; i < MatrixRowsCount; i++)
            {
                for (uint j = 0; j < MatrixColumnsCount; j++)
                {
                    sumOfMatrixAndNumber.SetItem(i, j, this.GetItem(i, j) + number);
                }
            }

            return sumOfMatrixAndNumber;
        }

        public virtual Matrix GetMatrixProduct(Matrix secondMatrix)
        {
            var c = new Matrix(MatrixRowsCount, MatrixColumnsCount);

            for (uint i = 0; i < c.MatrixRowsCount; i++)
            {
                for (uint k = 0; k < c.MatrixColumnsCount; k++)
                {
                    for (uint j = 0; j < MatrixRowsCount; j++)
                    {
                        c.SetItem(i, k, this.GetItem(i, j) * secondMatrix.GetItem(j, k));
                    }
                }
            }

            return c;
        }

        public virtual Matrix GetProductOfNumberWithMatrix(int inputNumber)
        {
            var productOfNumberWithMatrix = new Matrix(MatrixRowsCount, MatrixColumnsCount);

            for (uint i = 0; i < MatrixRowsCount; i++)
            {
                for (uint j = 0; j < MatrixColumnsCount; j++)
                {
                    productOfNumberWithMatrix.SetItem(i, j, this.GetItem(i, j) * inputNumber);
                }
            }

            return productOfNumberWithMatrix;
        }

        public virtual Matrix GetTransposedMatrix()
        {
            var transposedMatrix = new Matrix(MatrixRowsCount, MatrixColumnsCount);

            for (uint j = 0; j < MatrixColumnsCount; j++)
            {
                for (uint i = 0; i < MatrixRowsCount; i++)
                {
                    transposedMatrix.SetItem(j, i, this.GetItem(i, j));
                }
            }

            return transposedMatrix;
        }

        public virtual int GetDeterminantOfMatrix()
        {
            if (this.MatrixColumnsCount == 2 && this.MatrixRowsCount == 2)
            {
                return this.GetItem(0, 0) * this.GetItem(1, 1) - this.GetItem(0, 1) * this.GetItem(1, 0);
            }

            int sign = 1, determinant = 0;
            for (uint i = 0; i < this.MatrixColumnsCount; i++)
            {
                int[,] minor = GetMinor(i);
                determinant += sign * this.GetItem(0, i) * GetDeterminantOfMatrix();
                sign = -sign;
            }
            return determinant;
        }

        public virtual int[,] GetMinor(uint n)
        {
            int[,] result = new int[this.MatrixRowsCount - 1, this.MatrixRowsCount - 1];
            for (uint i = 1; i < this.MatrixRowsCount; i++)
            {
                for (uint j = 0; j < n; j++)
                    result[i - 1, j] = this.GetItem(i, j);
                for (uint j = n + 1; j < this.MatrixRowsCount; j++)
                    result[i - 1, j - 1] = this.GetItem(i, j);
            }
            return result;
        }
    }
}
