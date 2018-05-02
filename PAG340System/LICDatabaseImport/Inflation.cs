using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LICDatabaseImport
{
    class Inflation
    {
        private String filePath = LICDatabaseImport.Properties.Settings.Default.FilePath;
        private List<string> years = new List<string>();
        private List<string> januaryValues = new List<string>();
        private List<string> februaryValues = new List<string>();
        private List<string> marchValues = new List<string>();
        private List<string> aprilValues = new List<string>();
        private List<string> mayValues = new List<string>();
        private List<string> juneValues = new List<string>();
        private List<string> julyValues = new List<string>();
        private List<string> augustValues = new List<string>();
        private List<string> septeberValues = new List<string>();
        private List<string> octoberValues = new List<string>();
        private List<string> novemberValues = new List<string>();
        private List<string> decemberValues = new List<string>();

        public void getInfo()
        {
            readInfo("Years.CSV", years);
            readInfo("January.CSV", januaryValues);
            readInfo("February.CSV", februaryValues);
            readInfo("March.CSV", marchValues);
            readInfo("April.CSV", aprilValues);
            readInfo("May.CSV", mayValues);
            readInfo("June.CSV", juneValues);
            readInfo("July.CSV", julyValues);
            readInfo("August.CSV", augustValues);
            readInfo("September.CSV", septeberValues);
            readInfo("October.CSV", octoberValues);
            readInfo("November.CSV", novemberValues);
            readInfo("December.CSV", decemberValues);

            saveToDatabase("January", 1, januaryValues, years);
            saveToDatabase("February", 2, februaryValues, years);
            saveToDatabase("March", 3, marchValues, years);
            saveToDatabase("April", 4, aprilValues, years);
            saveToDatabase("May", 5, mayValues, years);
            saveToDatabase("June", 6, juneValues, years);
            saveToDatabase("July", 7, julyValues, years);
            saveToDatabase("August", 8, augustValues, years);
            saveToDatabase("September", 9, septeberValues, years);
            saveToDatabase("October", 10, octoberValues, years);
            saveToDatabase("November", 11, novemberValues, years);
            saveToDatabase("December", 12, decemberValues, years);
        }

        private void readInfo(string fileInput, List<string> input)
        {
            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + fileInput))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        input.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }
        }

        private decimal convertAmount(string amount)
        {
            decimal result = new decimal(Double.Parse(amount));
            result = Math.Round(result, 3);
            result += 0.000m;
            return result;
        }

        private void saveToDatabase(string month, int monthNum, List<string> inputMonth, List<string> inputYear)
        {
            string currentYear = "";
            string stringAmount = "";
            for (int i = 0; i < inputYear.Count; i++)
            {
                currentYear = inputYear[i];
                stringAmount = inputMonth[i];
                decimal currentAmount = convertAmount(stringAmount);
                string connectionString = LICDatabaseImport.Properties.Settings.Default.SqlConnection;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("addDollarInflation", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@monthName", monthName);
                cmd.Parameters.AddWithValue("@monthNumber", monthNum);
                cmd.Parameters.AddWithValue("@year", currentYear);
                cmd.Parameters.AddWithValue("@amount", currentAmount);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}