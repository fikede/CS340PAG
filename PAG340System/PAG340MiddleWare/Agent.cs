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
            String query = "Execute addEmployee " + id + ", " + firstName + ", " + lastName + ", " + userName + ", " + hashPassword + ", " + userType + ", " + dept;
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Policy> search(string policyHolderFirstName, string policyHolderLastName, string policyNumber)
        {
            List<Policy> policyList = new List<Policy>();
            String connectionString = PAG340MiddleWare.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query;
            if (policyNumber != "")
            {
                query = "execute searchPolicybyPolicyNumber " + policyNumber + ", " + id;
            }
            else
            {
                query = "execute searchPolicybyHolderName " + policyHolderFirstName + ", " + policyHolderLastName + ", " + id;
            }

            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            policyList = getSearchResults(reader);
            conn.Close();
            return policyList;
        }

        private List<Policy> getSearchResults(SqlDataReader reader)
        {
            List<Policy> policyList = new List<Policy>();
            int columnNumber;
            int booleanValue;
            Decimal decimalValue;
            while (reader.Read())
            {
                Policy policy = new Policy();
                PolicyHolder holder = new PolicyHolder();
                Agent rep = new Agent();
                Beneficiary beneficiary = new Beneficiary();
                columnNumber = reader.GetOrdinal("number");
                policy.PolicyNumber = reader.GetString(columnNumber);

                columnNumber = reader.GetOrdinal("holder_ID");
                holder.ID = reader.GetString(columnNumber);

                columnNumber = reader.GetOrdinal("emp_ID");
                rep.ID = reader.GetString(columnNumber);

                columnNumber = reader.GetOrdinal("holder_DOB");
                holder.BirthDate = reader.GetDateTime(columnNumber);

                columnNumber = reader.GetOrdinal("fathers_age_at_death");
                if (!reader.IsDBNull(columnNumber))
                {
                    decimalValue = reader.GetDecimal(columnNumber);
                    policy.FathersAgeAtDeath = Convert.ToDouble(decimalValue);
                }

                columnNumber = reader.GetOrdinal("mothers_age_at_death");
                if (!reader.IsDBNull(columnNumber))
                {
                    decimalValue = reader.GetDecimal(columnNumber);
                    policy.MothersAgeAtDeath = Convert.ToDouble(decimalValue);
                }

                columnNumber = reader.GetOrdinal("cigs_per_day");
                policy.CigsPerDay = reader.GetInt32(columnNumber);

                columnNumber = reader.GetOrdinal("smoking_history");
                decimalValue = reader.GetDecimal(columnNumber);
                policy.SmokingHis = Convert.ToDouble(decimalValue);

                columnNumber = reader.GetOrdinal("systolic_blood_pressure");
                policy.SystolicBldPressure = reader.GetInt32(columnNumber);

                columnNumber = reader.GetOrdinal("average_grams_fat_per_day");
                policy.GramsFatPerDay = reader.GetInt32(columnNumber);

                columnNumber = reader.GetOrdinal("heart_disease");
                booleanValue = reader.GetInt32(columnNumber);
                policy.HeartDisease = Convert.ToBoolean(booleanValue);

                columnNumber = reader.GetOrdinal("cancer");
                booleanValue = reader.GetInt32(columnNumber);
                policy.Cancer = Convert.ToBoolean(booleanValue);

                columnNumber = reader.GetOrdinal("hospitalized");
                booleanValue = reader.GetInt32(columnNumber);
                policy.Hospitalized = Convert.ToBoolean(booleanValue);

                columnNumber = reader.GetOrdinal("dangerous_activities");
                policy.DangerousActivities = reader.GetString(columnNumber);

                columnNumber = reader.GetOrdinal("start_date");
                policy.StartDate = reader.GetDateTime(columnNumber);

                columnNumber = reader.GetOrdinal("end_date");
                if(!reader.IsDBNull(columnNumber)) policy.EndDate = reader.GetDateTime(columnNumber);

                columnNumber = reader.GetOrdinal("payoff_amount");
                decimalValue = reader.GetDecimal(columnNumber);
                policy.PayOffAmount = Convert.ToDouble(decimalValue);

                columnNumber = reader.GetOrdinal("monthly_premium");
                decimalValue = reader.GetDecimal(columnNumber);
                policy.Premium = Convert.ToDouble(decimalValue);

                columnNumber = reader.GetOrdinal("first_name");
                holder.FirstName = reader.GetString(columnNumber);

                columnNumber = reader.GetOrdinal("last_name");
                holder.LastName = reader.GetString(columnNumber);

                columnNumber = reader.GetOrdinal("street");
                holder.Street = reader.GetString(columnNumber);

                columnNumber = reader.GetOrdinal("city");
                holder.City = reader.GetString(columnNumber);

                columnNumber = reader.GetOrdinal("state");
                holder.State = reader.GetString(columnNumber);

                columnNumber = reader.GetOrdinal("zip");
                holder.ZIP = reader.GetString(columnNumber);


                policy.RepresentativeAgent = rep;
                policy.Holder = holder;
                policy.Beneficiary = beneficiary;

                policyList.Add(policy);
            }
            return policyList;
        }

        public List<Policy> delinquentAccounts(string state, double amountOverdue)
        {
            List<Policy> policyList = new List<Policy>();
           
            return policyList;
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
