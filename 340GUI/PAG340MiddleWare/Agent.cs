using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
            hashPassword = "";
            dept = "";
        }

        public Agent(string inFirstName, string inLastName, string inID, string inUserName,
                    string inHashPassword, string inUserType, string inDept)
        {
            firstName = inFirstName;
            lastName = inLastName;
            id = inID;
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
            String connectionString = "Data Source=DATABASE\\CSCI3400011030;Initial Catalog = LIC_PAG;" + "Integrated Security=False;user='LIC_PAG_MW';pwd='PAG'";
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "INSERT INTO Employee(ID, first_Name, last_Name, username, password_hashed, usertype, department) " +
                " VALUES ('" + id + "', '" + firstName + "', '" + lastName + "', '" + userName + "', '" + hashPassword + "', '" + userType + "', '" + dept + "')";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Policy> search(string policyHolderFirstName, string policyHolderLastName, string policyNumber)
        {
            List<Policy> policyList = new List<Policy>();

            return policyList;
        }

        public List<Policy> delinquentAccounts(string state, double amountOverdue)
        {
            List<Policy> policyList = new List<Policy>();
           
            return policyList;
        }

        public bool logIn(string inID, string inHashPassword)
        {

            String connectionString = "Data Source=DATABASE\\CSCI3400011030;Initial Catalog = LIC_PAG;" + "Integrated Security=False;user='LIC_PAG_MW';pwd='PAG'";
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
               //if(reader.GetString(columnNum++) != null) this.dept = reader.GetString(columnNum++);
                return true;
            }
            else
            {
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
