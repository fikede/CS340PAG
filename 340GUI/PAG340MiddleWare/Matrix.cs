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

        /*
         * This is so that two matricies can be multiplied together.
         * What it does is takes a row from the lhsMatrix and column from the rhsMatrix and preforms a dot product of the two.
         * There is an exception thrown if a user tries to multiply two incompatible matrices.
         * The product of the two matrices will also have the number of rows of the lhsMatrix and the number of columns of the rhsMatrix.
         **/
        public static Matrix operator*(Matrix lhsMatrix, Matrix rhsMatrix)
        {
            Matrix productMatrix;

            if (lhsMatrix.numberOfColumns != rhsMatrix.numberOfRows)
            {
                Exception exception = new Exception("The number of columns of the left matrix must equal the number rows of the right matrix.");
                throw exception;
            }
            else
            {
                int lhsNumberOfRows = lhsMatrix.numberOfRows;
                int rhsNumberOfColumns = rhsMatrix.numberOfColumns;
                int lhsNumberOfColumns = lhsMatrix.numberOfColumns;
                //The resulting Matrix will have the same number of rows as the lhsMatrix and the same number of columns as the rhsMatrix
                productMatrix = new Matrix(lhsNumberOfRows, rhsNumberOfColumns);
                for(int index1 = 0; index1 < lhsNumberOfRows; index1++)
                {
                    for (int index2 = 0; index2 < rhsNumberOfColumns; index2++)
                    {
                        double result = 0.0;
                        double lhsNumber;
                        double rhsNumber;

                        for(int index3 = 0; index3 < lhsNumberOfColumns; index3++)
                        {
                            lhsNumber = lhsMatrix.getNumberAt(index1, index3);
                            rhsNumber = rhsMatrix.getNumberAt(index3, index2);
                            result += (lhsNumber * rhsNumber);
                        }

                        productMatrix.setNumberAt(index1, index2, result);
                    }
                }

            }
            
            return productMatrix;
        }

        /*
         * Every index in the array of a row and column number is found by
         * index = columnNumber + rowNumber(numberOfColumns)
         **/
        private int getIndexOf(int rowNumber, int columnNumber)
        {
            int index = numberOfColumns;
            index *= rowNumber;
            index += columnNumber;
            return index;
        }

        public int NumberOfRows
        {
            get { return numberOfRows; }
            set { numberOfRows = value; }
        }

        public int NumberOfColumns
        {
            get { return numberOfColumns; }
            set { numberOfColumns = value; }
        }

        public double getNumberAt(int rowNumber, int columnNumber)
        {
            int index = getIndexOf(rowNumber, columnNumber);
            double numberAt = matrix[index];
            return numberAt;
        }

        public void setNumberAt(int rowNumber, int columnNumber, double numberToBeSet)
        {
            int index = getIndexOf(rowNumber, columnNumber);
            matrix[index] = numberToBeSet;
        }


        public override string ToString()
        {
            string output = "Number of Rows: " + numberOfRows + ", Number of Columns: " + numberOfColumns + " ";
            for(int index1 = 0; index1 < numberOfRows; index1++)
            {
                output += "\n";
                for(int index2 = 0; index2 < numberOfColumns; index2++)
                {
                    double numberAt = getNumberAt(index1, index2);
                    output += numberAt + "   ";
                }
            }
            return output;
        }
    }
}
