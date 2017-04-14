using System;

namespace HomeWork6
{
    class ToeplitzMatrix : Matrix
    {
        int[] firstRow;
        int[] firstCol;

        public ToeplitzMatrix(uint matrixRowsCount, uint matrixColumnsCount)
            : base(matrixRowsCount, matrixColumnsCount)
        {
        }

        public override int GetItem(uint x, uint y)
        {
            // TODO: проверка на выход за границы массива
            if (x != 0 && y != 0)
            {
                x = x - Math.Min(x, y);
                y = y - Math.Min(x, y);
            }

            if (y == 0)
            {
                return firstRow[x];
            }

            if (x == 0)
            {
                return firstCol[y - 1];
            }

            return 0;
        }

        public override void SetItem(uint x, uint y, int value)
        {
            // TODO: проверка на выход за границы массива
            if (x != 0 && y != 0)
            {
                x = x - Math.Min(x, y);
                y = y - Math.Min(x, y);
            }

            if (y == 0)
            {
                firstRow[x] = value;
            }

            if (x == 0)
            {
                firstCol[y - 1] = value;
            }
        }

        protected override void FillMatrix()
        {
            firstRow = new int[MatrixColumnsCount];
            firstCol = new int[MatrixRowsCount];
            Random rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for (int i = 0; i < firstRow.Length; i++)
            {
                firstRow[i] = rnd.Next(-10, 10);
            }

            for (int i = 0; i < firstCol.Length; i++)
            {
                firstCol[i] = rnd.Next(-10, 10);
            }
        }
    }
}
