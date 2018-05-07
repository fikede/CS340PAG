using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PAG340MiddleWare
{
     public class Agent : Savable
    {
        private string firstName;
        private string lastName;
        private string id;
        private string userName;
        private string hashPassword;
        private string userType;
        private string dept;

        public Agent()
        {
            firstName = "";
            lastName = "";
            id = "";
            userName = null;
            hashPassword = "";
            userType = "";
            dept = "";
        }

        public Agent(string inFirstName, string inLastName, string inID, string inUserName,
                    string inHashPassword, string inUserType, string inDept)
        {
            firstName = inFirstName;
            lastName = inLastName;
            id = inID;
            userName = inUserName;
            hashPassword = inHashPassword;
            userType = inUserType;
            dept = inDept;
        }

        public Agent(Agent inAgent)
        {
            firstName = inAgent.firstName;
            lastName = inAgent.lastName;
            id = inAgent.id;
            hashPassword = inAgent.hashPassword;
            userType = inAgent.userType;
            dept = inAgent.dept;
        }

        public override void saveToDataBase()
        {
            String connectionString = PAG340MiddleWare.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "addEmployee";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeID", id);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@username", userName);
            cmd.Parameters.AddWithValue("@passwordHashed", hashPassword);
            cmd.Parameters.AddWithValue("@usertype", userType);
            cmd.Parameters.AddWithValue("@department", dept);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Policy> search(string policyHolderFirstName, string policyHolderLastName, string policyNumber)
        {
            List<Policy> policyList = new List<Policy>();
            String connectionString = PAG340MiddleWare.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "searchPolicy";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@policyNumber", policyNumber);
            cmd.Parameters.AddWithValue("@agentID", id);
            cmd.Parameters.AddWithValue("@holderFName", policyHolderFirstName);
            cmd.Parameters.AddWithValue("@holderLName", policyHolderLastName);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            policyList = getSearchResults(reader);
            conn.Close();
            return policyList;
        }

        protected List<Policy> getSearchResults(SqlDataReader reader)
        {
            List<Policy> policyList = new List<Policy>();
            while (reader.Read())
            {
                Policy policy = new Policy();
                policy.getPolicyInfoWithReader(reader);
                policyList.Add(policy);
            }
            return policyList;
        }

        public List<Policy> delinquentAccounts(string state, double amountOverdue)
        {
            List<Policy> policyList = new List<Policy>();
            String connectionString = PAG340MiddleWare.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "searchPolicy";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@agentID", id);
            if(state.Length == 2) cmd.Parameters.AddWithValue("@searchState", state);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            policyList = getSearchResults(reader);
            conn.Close();
            policyList = calculateDelinquentAccounts(policyList, amountOverdue);

            return policyList;
        }

        protected List<Policy> calculateDelinquentAccounts(List<Policy> policies, double amountOverdue)
        {
            List<Policy> policyList = new List<Policy>();

            foreach(Policy policy in policies)
            {
                List<Payment> payments = policy.GetPaymentHistory();
                TimeSpan sinceStart = DateTime.Today.Subtract(policy.StartDate);
                double expectedSum = policy.Premium * (sinceStart.TotalDays / 30.42); //To get months.
                double actualSum = calculateActualSum(payments);
                if ((expectedSum - actualSum) > amountOverdue) policyList.Add(policy);
            }

            return policyList;
        }

        protected double calculateActualSum(List<Payment> payments)
        {
            double sum = 0;
            foreach (Payment payment in payments)
            {
                if (payment.Type != 'c' && payment.Type != 'C') sum += payment.Amount;
            }
            return sum;
        }

        public bool logIn(string inID, string inHashPassword)
        {

            String connectionString = PAG340MiddleWare.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "execute loginEmployee '" + inID + "','" + inHashPassword + "'";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                this.id = inID;
                this.hashPassword = inHashPassword;
                int columnNum = reader.GetOrdinal("first_name");
                this.firstName = reader.GetString(columnNum++);
                this.lastName = reader.GetString(columnNum++);
                this.userName = reader.GetString(columnNum++);
                columnNum++; //skipping over password.
                this.userType = reader.GetString(columnNum++);
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public void logOut()
        {

        }

        public bool isManager()
        {
            if (userType.Equals("m") || userType.Equals("M")) return true;
            else return false;  
        }

        public string Firstname
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Hashpassword
        {
            get { return hashPassword; }
            set { hashPassword = value; }
        }

        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
    }
}
