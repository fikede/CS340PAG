using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LICDatabaseImport
{
    class LifePolicy : Savable
    {
        private char[] policyNum = new char[30];
        private char[] holderID = new char[20];
        private char[] holderDOB = new char[8];
        private char[] fatherDOD = new char[5];
        private char[] motherDOD = new char[5];
        private char[] cigsPerDay = new char[5];
        private char[] smokingHistory = new char[5];
        private char[] systolicBloodPressure = new char[4];
        private char[] averageGramsFatPerDay = new char[5];
        private char[] heartDisease = new char[1];
        private char[] cancer = new char[1];
        private char[] hospitalized = new char[1];
        private char[] dangerousActivities = new char[255];
        private char[] policyStartDate = new char[8];
        private char[] policyEndDate = new char[8];
        private char[] agentID = new char[20];
        private char[] payoffAmount = new char[10];
        private char[] monthlyPremium = new char[10];
        private List<string> numbers;

        public LifePolicy(List<string> inNumbers)
        {
            numbers = inNumbers;
        }
        public override void parseInfo(string s)
        {
            policyNum = getInfo(0, 29, s, policyNum);
            holderID = getInfo(30, 49, s, holderID);
            holderDOB = getInfo(50, 57, s, holderDOB);
            fatherDOD = getInfo(58, 62, s, fatherDOD);
            motherDOD = getInfo(63, 67, s, motherDOD);
            cigsPerDay = getInfo(68, 72, s, cigsPerDay);
            smokingHistory = getInfo(73, 77, s, smokingHistory);
            systolicBloodPressure = getInfo(78, 81, s, systolicBloodPressure);
            averageGramsFatPerDay = getInfo(82, 86, s, averageGramsFatPerDay);
            heartDisease = getInfo(87, 87, s, heartDisease);
            cancer = getInfo(88, 88, s, cancer);
            hospitalized = getInfo(89, 89, s, hospitalized);
            dangerousActivities = getInfo(90, 344, s, dangerousActivities);
            policyStartDate = getInfo(345, 352, s, policyStartDate);
            policyEndDate = getInfo(353, 360, s, policyEndDate);
            agentID = getInfo(361, 380, s, agentID);
            payoffAmount = getInfo(381, 390, s, payoffAmount);
            monthlyPremium = getInfo(391, 400, s, monthlyPremium);
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

        private string dateConversion(char[] dateInput)
        {
            string dateString = convertToString(dateInput);
            if (dateString.Length < 2) return "null";

            return dateString;
        }

        private decimal calculateYearsInDecimal(char[] ageInput)
        {
            decimal result = 0.00m;
            decimal years = 0.00m;
            decimal months = 0.00m;
            string ageYears = "";
            string ageMonths = "";

            for (int i = 0; i < 3; i++)
            {
                ageYears += ageInput[i];
            }

            if (ageYears.Contains("N/A"))
            {
                return 0;
            }

            for (int i = 3; i < ageInput.Length; i++)
            {
                ageMonths += ageInput[i];
            }

            years = Decimal.Parse(ageYears);
            months = Decimal.Parse(ageMonths);
            months /= 12;
            months = Math.Round(months, 2);
            result += (years + months);
            return result;
        }

        private decimal convertAmount(char[] input)
        {
            string amountString = convertToString(input);
            decimal result = new Decimal(Double.Parse(amountString));
            result /= 100.00m;
            result += 0.00m;
            return result;
        }

        private int convertToInt(char[] input)
        {
            string inputString = convertToString(input);
            int value = Int32.Parse(inputString);
            return value;
        }

        private int convertYorN(char[] input)
        {
            string letter = convertToString(input);
            if (letter.ToUpper() == "Y")
                return 1;
            else
                return 0;
        }

        public override void saveToDatabase()
        {
            string inputPolicyNum = convertToString(policyNum);
            string inputHolderID = convertToString(holderID);
            string inputAgentID = convertToString(agentID);
            string inputHolderDOB = dateConversion(holderDOB);
            decimal inputFatherDOD = calculateYearsInDecimal(fatherDOD);
            decimal inputMotherDOD = calculateYearsInDecimal(motherDOD);
            int inputCigsPerDay = convertToInt(cigsPerDay);
            decimal inputSmokingHistory = calculateYearsInDecimal(smokingHistory);
            int inputSystolicBloodPressure = convertToInt(systolicBloodPressure);
            int inputAverageGramsFatPerDay = convertToInt(averageGramsFatPerDay);
            int inputHeartDisease = convertYorN(heartDisease);
            int inputCancer = convertYorN(cancer);
            int inputHospitalized = convertYorN(hospitalized);
            string inputDangerousActivities = convertToString(dangerousActivities);
            string inputPolicyStartDate = dateConversion(policyStartDate);
            string inputPolicyEndDate = dateConversion(policyEndDate);
            decimal inputPayoffAmount = convertAmount(payoffAmount);
            decimal inputMonthlyPremium = convertAmount(monthlyPremium);
            numbers.Add(inputPolicyNum);
            if (false)
            {
                String connectionString = LICDatabaseImport.Properties.Settings.Default.SqlConnection;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("addPolicy", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@policyNumber", inputPolicyNum);
                cmd.Parameters.AddWithValue("@holderID", inputHolderID);
                cmd.Parameters.AddWithValue("@empID", inputAgentID);
                cmd.Parameters.AddWithValue("@holderDOB", inputHolderDOB);
                if (inputFatherDOD > 0) cmd.Parameters.AddWithValue("@fatherDeath", inputFatherDOD);
                if (inputMotherDOD > 0) cmd.Parameters.AddWithValue("@motherDeath", inputMotherDOD);
                cmd.Parameters.AddWithValue("@cigsPerDay", inputCigsPerDay);
                cmd.Parameters.AddWithValue("@smokeHistory", inputSmokingHistory);
                cmd.Parameters.AddWithValue("@sysBP", inputSystolicBloodPressure);
                cmd.Parameters.AddWithValue("@aGramsFat", inputAverageGramsFatPerDay);
                cmd.Parameters.AddWithValue("@heartDisease", inputHeartDisease);
                cmd.Parameters.AddWithValue("@cancer", inputCancer);
                cmd.Parameters.AddWithValue("@hospitalized", inputHospitalized);
                cmd.Parameters.AddWithValue("@dangerousActivities", inputDangerousActivities);
                cmd.Parameters.AddWithValue("@startDate", inputPolicyStartDate);
                if (inputPolicyEndDate != "null") cmd.Parameters.AddWithValue("@endDate", inputPolicyEndDate);
                cmd.Parameters.AddWithValue("@payoffAmount", inputPayoffAmount);
                cmd.Parameters.AddWithValue("@monthlyPremium", inputMonthlyPremium);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}