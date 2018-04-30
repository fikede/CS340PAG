using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LICDatabaseImport
{
    class PaymentHistory : Savable
    {
        // for PaymentHistory

        private List<string> policyNumbers;
        private char[] amount = new char[10];
        private char[] paymentDateTime = new char[12];
        private char[] paymentPolicyNum = new char[30];
        private char[] paymentDescription = new char[1];
        public PaymentHistory(List<string> inNumbers)
        {
            policyNumbers = inNumbers;
        }
        public override void parseInfo(string s)
        {
            amount = getInfo(0, 9, s, amount);
            paymentDateTime = getInfo(10, 21, s, paymentDateTime);
            paymentPolicyNum = getInfo(22, 51, s, paymentPolicyNum);
            paymentDescription = getInfo(52, 52, s, paymentDescription);
            saveToDatabase();
        }

        public void updateClaimedPolicies()
        {
            int columnNumber = 0;
            List<string> policyList = new List<string>();
            List<string> dates = new List<string>();
            DateTime date = new DateTime();

            string connectionString = LICDatabaseImport.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("getClaims", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                columnNumber = reader.GetOrdinal("policy_number");
                policyList.Add(reader.GetString(columnNumber));
                columnNumber = reader.GetOrdinal("date");
                date = reader.GetDateTime(columnNumber);
                dates.Add(date.ToShortDateString()); //removed the times for ending a policy... not needed.
            }
            conn.Close();
            // now that we have the policies and dates....

            // PROBABLY INEFFICIENT BUT EFFECTIVE.
            for (int i = 0; i < policyList.Count; i++)
            {
                SqlCommand cmd_Policy = new SqlCommand("endPolicy", conn);
                cmd_Policy.CommandType = CommandType.StoredProcedure;
                cmd_Policy.Parameters.AddWithValue("@policyNumber", policyList[i]);
                cmd_Policy.Parameters.AddWithValue("@cancelDate", dates[i]);
                conn.Open();
                cmd_Policy.ExecuteNonQuery();
                conn.Close();
            }
            // end the policy.
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

        private string dateConversion(char[] dateInput)
        {
            string dateString = "";
            for (int i = 0; i < 4; i++)
            {
                dateString += dateInput[i];
            }
            dateString += "-";
            for (int i = 4; i < 6; i++)
            {
                dateString += dateInput[i];
            }
            dateString += "-";
            for (int i = 6; i < 8; i++)
            {
                dateString += dateInput[i];
            }
            dateString += " ";
            for (int i = 8; i < 10; i++)
            {
                dateString += dateInput[i];
            }
            dateString += ":";
            for (int i = 10; i < dateInput.Length; i++)
            {
                dateString += dateInput[i];
            }
            dateString += ":00"; // need to add seconds.
            return dateString;
        }
        private decimal convertAmount(char[] input)
        {
            string amountString = convertToString(input);
            decimal result = new decimal(Double.Parse(amountString));
            result /= 100.00m;
            result = Math.Round(result, 2);
            result += 0.00m;
            return result;
        }

        public override void saveToDatabase()
        {
            string inputPolicyNum = convertToString(paymentPolicyNum);
            string inputPaymentDate = dateConversion(paymentDateTime);
            string inputDescription = convertToString(paymentDescription);
            decimal inputAmount = convertAmount(amount);
            if (policyNumbers.Contains(inputPolicyNum))
            {
                string connectionString = LICDatabaseImport.Properties.Settings.Default.SqlConnection;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("addPayment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@policyNumber", inputPolicyNum);
                cmd.Parameters.AddWithValue("@paymentDate", inputPaymentDate);
                cmd.Parameters.AddWithValue("@paymentType", inputDescription);
                cmd.Parameters.AddWithValue("@amount", inputAmount);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
