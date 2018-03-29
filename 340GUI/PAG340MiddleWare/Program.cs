using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAG340MiddleWare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Testing underneath - jef
            Matrix matrix = new Matrix(3, 5);
            FillMatrix(matrix);
            Console.WriteLine(matrix.ToString());

            Matrix matrix2 = new Matrix(5, 3);
            FillMatrix(matrix2);
            Console.WriteLine(matrix2.ToString());

            Matrix productMatrix = matrix * matrix2;
            Console.WriteLine(productMatrix.ToString());

            Matrix newMatrix = matrix.transpose();
            Console.WriteLine(newMatrix.ToString());

        }

        //Method for testing
        public static void FillMatrix(Matrix m)
        {
            int numOfRows = m.NumberOfRows;
            int numOfColumns = m.NumberOfColumns;
            for (int row = 0; row < numOfRows; row++)
            {
                for (int column = 0; column < numOfColumns; column++)
                {
                    double value = column + row * (numOfColumns);
                    m.setNumberAt(row, column, value);
                }
            }
        }
    }
}
