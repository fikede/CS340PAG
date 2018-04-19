using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LICDatabaseImport
{
    class User : Savable
    {
        // for User
        private char[] username = new char[20];
        private char[] userFName = new char[100];
        private char[] userLName = new char[100];
        private char[] password = new char[255];
        private char[] usertype = new char[1];
        private char[] ID = new char[20];
        private char[] addressStreet = new char[30];
        private char[] addressCity = new char[20];
        private char[] addressState = new char[2];
        private char[] addressZip = new char[9];
        private char[] department = new char[50];

        public override void parseInfo(string s)
        {
            username = getInfo(0, 19, s, username);
            userFName = getInfo(20, 119, s, userFName);
            userLName = getInfo(120, 219, s, userLName);
            password = getInfo(220, 474, s, password);
            usertype = getInfo(475, 475, s, usertype);
            ID = getInfo(476, 495, s, ID);
            addressStreet = getInfo(496, 525, s, addressStreet);
            addressCity = getInfo(526, 545, s, addressCity);
            addressState = getInfo(546, 547, s, addressState);
            addressZip = getInfo(548, 556, s, addressZip);
            department = getInfo(557, 606, s, department);
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
            string inputUserName = convertToString(username);
            string inputFirstName = convertToString(userFName);
            string inputLastName = convertToString(userLName);
            string inputPasword = convertToString(password);
            string inputUserType = convertToString(usertype);
            string inputID = convertToString(ID);
            string inputStreet = convertToString(addressStreet);
            string inputCity = convertToString(addressCity);
            string inputState = convertToString(addressState);
            string inputZip = convertToString(addressZip);
            string inputDepartment = convertToString(department);

            String connectionString = "Data Source=DATABASE\\CSCI3400011030;Initial Catalog = LIC_PAG;" + "Integrated Security=False;user='LIC_PAG_MW';pwd='PAG'";
            SqlConnection conn = new SqlConnection(connectionString);

            // employee
            if (inputUserType.Equals("A") || inputUserType.Equals("D") || inputUserType.Equals("M"))
            {
                SqlCommand cmd = new SqlCommand("addEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeID", inputID);
                cmd.Parameters.AddWithValue("@firstName", inputFirstName);
                cmd.Parameters.AddWithValue("@lastName", inputLastName);
                cmd.Parameters.AddWithValue("@username", inputUserName);
                cmd.Parameters.AddWithValue("@password", inputPasword);
                cmd.Parameters.AddWithValue("@usertype", inputUserType);
                cmd.Parameters.AddWithValue("@department", inputDepartment);

                conn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i == 0)
                {
                    throw new Exception("Cannot Save");
                }
                conn.Close();
            }

            // policyholder
            else
            {
                SqlCommand cmd = new SqlCommand("addPolicyHolder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", inputID);
                cmd.Parameters.AddWithValue("@firstName", inputFirstName);
                cmd.Parameters.AddWithValue("@lastName", inputLastName);
                cmd.Parameters.AddWithValue("@street", inputStreet);
                cmd.Parameters.AddWithValue("@city", inputCity);
                cmd.Parameters.AddWithValue("@state", inputState);
                cmd.Parameters.AddWithValue("@zip", inputZip);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
