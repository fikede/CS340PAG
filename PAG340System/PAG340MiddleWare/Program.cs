using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            /*Testing underneath - jef
            
            Agent agent = new Agent();
            agent.logIn("11111111111111111111", "test");

            Agent newagent = new Agent("firstName", "lastName", "12341234123412341234","jfarmer", "hi", "A", "Freelancer");
            newagent.saveToDataBase();

            Manager manager = new Manager();
            string s = manager.getNextId();
            */
        }

        /*Method for testing
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
        }*/ 
    }
}
