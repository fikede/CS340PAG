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
        private double[,] matrix;

        public Matrix(int inNumberOfRows, int inNumberOfColumns)
        {
            numberOfRows = inNumberOfRows;
            numberOfColumns = inNumberOfColumns;
            matrix = new double[inNumberOfRows, inNumberOfColumns];
        }

        public Matrix(int inRowNumber, int inColumnNumber, Matrix inMatrix)
        {
            numberOfRows = inMatrix.numberOfRows - 1;
            numberOfColumns = inMatrix.numberOfColumns - 1;
            matrix = new double[numberOfRows, numberOfColumns];
            double value;
            int oldRowNumber = 0;
            for(int rowNumber = 0; rowNumber < NumberOfRows; rowNumber++)
            {
                if (oldRowNumber == inRowNumber) oldRowNumber++;
                int oldColumnNumber = 0;
                for(int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
                {
                    if (oldColumnNumber == inColumnNumber) oldColumnNumber++;
                    value = inMatrix.getNumberAt(oldRowNumber, oldColumnNumber);
                    setNumberAt(rowNumber, columnNumber, value);
                    oldColumnNumber++;
                }
                oldRowNumber++;
            }
        }

        public Matrix inverse()
        {
            double determinant = getDeterminant();
            Matrix inverseMatrix = new Matrix(numberOfRows, numberOfColumns);
            if (numberOfRows != numberOfColumns) throw new Exception("Matrix is not square.");
            else if (determinant == 0) throw new Exception("Matrix is not is not invertible");
            else
            {
                inverseMatrix.OfMinors(this);
                inverseMatrix.OfCofactors();
                inverseMatrix.transpose();
                inverseMatrix.MultiplyByANumber(1 / determinant);
            }
            
              return inverseMatrix;
        }

        private void OfMinors(Matrix inMatrix)
        {
            double value;
            for(int rowNumber = 0; rowNumber < numberOfRows; rowNumber++)
            {
                for(int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
                {
                    Matrix newMatrix = new Matrix(rowNumber + 1, columnNumber + 1, inMatrix);
                    value = newMatrix.getDeterminant();
                    setNumberAt(rowNumber, columnNumber, value);
                }
            }
        }

        private void OfCofactors()
        {
            for (int rowNumber = 0; rowNumber < numberOfRows; rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
                {
                    if(rowNumber % 2 == 0)
                    {
                        if(columnNumber % 2 == 1)
                        {
                            double opposite = 0.0 - getNumberAt(rowNumber, columnNumber);
                            setNumberAt(rowNumber, columnNumber, opposite);
                        }
                    }
                    else if(columnNumber % 2 == 0)
                    {
                        double opposite = 0.0 - getNumberAt(rowNumber, columnNumber);
                        setNumberAt(rowNumber, columnNumber, opposite);
                    }
                }
            }
        }

        private void MultiplyByANumber(double number)
        {
            double value;
            for(int rowNumber = 0; rowNumber < numberOfRows; rowNumber++)
            {
                for(int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
                {
                    value = getNumberAt(rowNumber, columnNumber);
                    value *= number;
                    setNumberAt(rowNumber, columnNumber, value);
                }
            }
        }

        private double getDeterminant()
        {
            double determinant = 0.0;
            if(numberOfColumns == 2)
            {
                determinant += getNumberAt(0, 0) * getNumberAt(1, 1);
                determinant -= getNumberAt(0, 1) * getNumberAt(1, 0);
            }
            else
            {
                double value;
               for(int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
                {
                    value = getNumberAt(0, columnNumber);
                    if (value == 0.0) return value;
                    Matrix newMatrix = new Matrix(0, columnNumber, this);
                    if (columnNumber % 2 == 0) determinant += value * newMatrix.getDeterminant();
                    else determinant -= value * newMatrix.getDeterminant();
                }
            }
            return determinant;
        }

        /*
         * This method is used to produce the transpose of a Matrix.
         * First a new matrix matrixTransposed is made that has it's number of rows equal to the number of columns of the existing matrix and vice versa.
         * Then all that is done is the rows and columns are fliped.
         * For example if the existing has a value v at row m and column n then that v will go at row n column m in matrixTransposed.
         * -jef
         **/
        public Matrix transpose()
        {
            Matrix matrixTransposed = new Matrix(numberOfColumns, numberOfRows);
            double value;
            for(int rowNumber = 0; rowNumber < numberOfRows; rowNumber++)
            {
                for(int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
                {
                    value = getNumberAt(rowNumber, columnNumber);
                    matrixTransposed.setNumberAt(columnNumber, rowNumber, value);
                }
            }

            return matrixTransposed;
        }

        /*
         * This is so that two matricies can be multiplied together.
         * What it does is takes a row from the lhsMatrix and column from the rhsMatrix and preforms a dot product of the two.
         * There is an exception thrown if a user tries to multiply two incompatible matrices.
         * The product of the two matrices will also have the number of rows of the lhsMatrix and the number of columns of the rhsMatrix.
         * -jef
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
                //The resulting Matrix will have the same number of rows as the lhsMatrix and the same number of columns as the rhsMatrix - jef
                productMatrix = new Matrix(lhsNumberOfRows, rhsNumberOfColumns);
                for(int lhsRowNumber = 0; lhsRowNumber < lhsNumberOfRows; lhsRowNumber++)
                {
                    for (int rhsColumnNumber = 0; rhsColumnNumber < rhsNumberOfColumns; rhsColumnNumber++)
                    {
                        double result = 0.0;
                        double lhsNumber;
                        double rhsNumber;

                        for(int lhsColumnNumber = 0; lhsColumnNumber < lhsNumberOfColumns; lhsColumnNumber++)
                        {
                            lhsNumber = lhsMatrix.getNumberAt(lhsRowNumber, lhsColumnNumber);
                            rhsNumber = rhsMatrix.getNumberAt(lhsColumnNumber, rhsColumnNumber);
                            result += (lhsNumber * rhsNumber);
                        }

                        productMatrix.setNumberAt(lhsRowNumber, rhsColumnNumber, result);
                    }
                }

            }
            
            return productMatrix;
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
            double numberAt = matrix[rowNumber, columnNumber];
            return numberAt;
        }

        public void setNumberAt(int rowNumber, int columnNumber, double numberToBeSet)
        {
            matrix[rowNumber, columnNumber] = numberToBeSet;
        }


        public override string ToString()
        {
            string output = "Number of Rows: " + numberOfRows + ", Number of Columns: " + numberOfColumns + " ";
            for(int rowNumber = 0; rowNumber < numberOfRows; rowNumber++)
            {
                output += "\n";
                for(int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
                {
                    double numberAt = getNumberAt(rowNumber, columnNumber);
                    output += numberAt + "   ";
                }
            }
            return output;
        }
    }
}
