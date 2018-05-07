using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PAG340MiddleWare.Properties;

namespace PAG340MiddleWare
{
    public class Beneficiary : Savable
    {
        private string firstName;
        private string lastName;
        private string policyNumber;
        
        public Beneficiary()
        {
            firstName = "";
            lastName = "";
            policyNumber = "";
        }

        public Beneficiary(string inFirstName, string inLastName, string inPolicyNumber)
        {
            firstName = inFirstName;
            lastName = inLastName;
            policyNumber = inPolicyNumber;
        }

        public override void saveToDataBase()
        {
            String connectionString = Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "addBeneficiary";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@policyNumber", policyNumber);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AddPolicyInfo(string inFirstName, string inLastName)
        {
            firstName = inFirstName;
            lastName = inLastName;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string PolicyNumber
        {
            get { return policyNumber; }
            set { policyNumber = value; }
        }
    }
}
