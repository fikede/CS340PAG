using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LICDatabaseImport
{
    class Beneficiary : Savable
    {
        private char[] beneficiaryPolicyNum = new char[30];
        private char[] beneficiaryFName = new char[100];
        private char[] beneficiaryLName = new char[100];

        public override void parseInfo(string s)
        {
            beneficiaryPolicyNum = getInfo(0, 29, s, beneficiaryPolicyNum);
            beneficiaryFName = getInfo(30, 129, s, beneficiaryFName);
            beneficiaryLName = getInfo(130, 229, s, beneficiaryLName);
            saveToDatabase();
        }

        private static char[] getInfo(int start, int end, string input, char[] output)
        {
            int index = 0;
            for (int i = start; i <= end; i++)
            {
                output[index] = input[i];
                index++;
            }
            return output;
        }

        private string convertToString(char[] input)
        {
            string inputString = new string(input);
            string output = inputString.Trim();
            return output;
        }

        public override void saveToDatabase()
        {
            string inputPolicyNum = convertToString(beneficiaryPolicyNum);
            string inputFirstName = convertToString(beneficiaryFName);
            string inputLastName = convertToString(beneficiaryLName);

            String connectionString = LICDatabaseImport.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("addBeneficary", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@policyNumber", inputPolicyNum);
            cmd.Parameters.AddWithValue("@firstName", inputFirstName);
            cmd.Parameters.AddWithValue("@lastName", inputLastName);

            conn.Open();
            int i = cmd.ExecuteNonQuery();

            if (i == 0)
            {
                throw new Exception("Cannot Save");
            }
            conn.Close();
        }
    }
}
