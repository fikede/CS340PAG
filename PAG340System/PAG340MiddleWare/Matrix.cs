﻿using System;
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
            for (int rowNumber = 0; rowNumber < NumberOfRows; rowNumber++)
            {
                if (oldRowNumber == inRowNumber) oldRowNumber++;
                int oldColumnNumber = 0;
                for (int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
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
            if (numberOfRows != numberOfColumns) throw new Exception("Matrix is not square.");
            Matrix inverseMatrix = new Matrix(numberOfRows, numberOfColumns);
            inverseMatrix.makeThisIdentityMatrix();
            Matrix A = this * inverseMatrix;
            A.checkForZero();
            if (A.matrix[0, 0] == 0.0) throw new Exception("Inverse matrix doesn't exist.");

            for(int rowNumber = 0; rowNumber < numberOfRows; rowNumber++)
            {
                for(int columnNumber = 0; columnNumber < rowNumber; columnNumber++)
                {
                    double factor = A.matrix[rowNumber, columnNumber];
                    A.subtractRowFrom(rowNumber, columnNumber, factor);
                    inverseMatrix.subtractRowFrom(rowNumber, columnNumber, factor);
                }
                double divisor = A.matrix[rowNumber, rowNumber];
                A.divideRowBy(rowNumber, divisor);
                inverseMatrix.divideRowBy(rowNumber, divisor);
            }

            for(int columnNumber = numberOfColumns - 1; columnNumber > 0; columnNumber--)
            {
                for (int rowNumber = 0; rowNumber < columnNumber; rowNumber++)
                {
                    double factor = A.matrix[rowNumber, columnNumber];
                    A.subtractRowFrom(rowNumber, columnNumber, factor);
                    inverseMatrix.subtractRowFrom(rowNumber, columnNumber, factor);
                }
            }

            return inverseMatrix;
        }

        private void divideRowBy(int rowNumber, double divisor)
        {
            for(int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
            {
                matrix[rowNumber, columnNumber] /= divisor;
            }
        }

        private void subtractRowFrom(int rowToBeSubtracted, int subtractingRow, double factor)
        {
            for(int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
            {
                matrix[rowToBeSubtracted, columnNumber] -= factor * matrix[subtractingRow, columnNumber];
            }
        }

        private void checkForZero()
        {
            for(int rowNumber = 0; rowNumber < NumberOfRows; rowNumber++)
            {
                if (matrix[rowNumber, 0] != 0.0)
                {
                    if (rowNumber != 0)
                    {
                        this.swap(0, rowNumber);
                        break;
                    }
                    else break;
                }
            }
        }

        private void swap(int rowToBeReplaced, int replacingRow)
        {
            double[] temporaryRow = new double[numberOfColumns];
            for(int columnNumber = 0; columnNumber < numberOfColumns; columnNumber++)
            {
                temporaryRow[columnNumber] = matrix[rowToBeReplaced, columnNumber];
                matrix[rowToBeReplaced, columnNumber] = matrix[replacingRow, columnNumber];
                matrix[replacingRow, columnNumber] = temporaryRow[columnNumber];
            }
        }

        private void makeThisIdentityMatrix()
        {
            for(int i = 0; i < numberOfRows; i++)
            {
                matrix[i,i] = 1;
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
