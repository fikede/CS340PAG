using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAG340MiddleWare
{
    class Matrix
    {
        private int numberOfRows;
        private int numberOfColumns;
        private double[] matrix;

        public Matrix(int inNumberOfRows, int inNumberOfColumns)
        {
            numberOfRows = inNumberOfRows;
            numberOfColumns = inNumberOfColumns;
            matrix = new double[inNumberOfColumns * inNumberOfRows];
        }

        public Matrix inverse()
        {
            Matrix inverseMatrix = new Matrix(numberOfRows, numberOfColumns);

            return inverseMatrix;
        }

        public Matrix transpose()
        {
            Matrix matrixTransposed = new Matrix(numberOfColumns, numberOfRows);

            return matrixTransposed;
        }

        public static Matrix operator*(Matrix lhsMatrix, Matrix rhsMatrix)
        {
            Matrix productMatrix = new Matrix(lhsMatrix.numberOfColumns, rhsMatrix.numberOfRows);

            return productMatrix;
        }
    }
}
