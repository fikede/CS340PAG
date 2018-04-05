using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PAG340MiddleWare
{
    public class Manager : Agent
    {
        public Manager() : base()
        {

        }

        public Manager(string inFirstName, string inLastName, string inID, string inUserName,
                    string inHashPassword, string inUserType, string inDept) : base(inFirstName, inLastName, inID, inUserName, inHashPassword, inUserType, inDept)
        {

        }

        public Manager(Agent inAgent) : base( inAgent)
        {

        }

        public override void saveToDataBase()
        {

        }

        public List<Policy> search(string policyHolderFirstName, string policyHolderLastName, string agentFirstName, string agentLastName, string policyNumber)
        {
            List<Policy> policyList = new List<Policy>();

            return policyList;
        }

        public List<Policy> delinquentAccounts(string state, double amountOverdue, string agentFirstName, string agentLastName)
        {
            List<Policy> policyList = new List<Policy>();

            return policyList;
        }

        public void addAgent( Agent inAgent)
        {
            inAgent.saveToDataBase();
        }

        public string getNextId()
        {
            String connectionString = "Data Source=DATABASE\\CSCI3400011030;Initial Catalog = LIC_PAG;" + "Integrated Security=False;user='LIC_PAG_MW';pwd='PAG'";
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "EXECUTE returnEmployeeID";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            String newID = "";

            if(reader.Read())
            {
                int columnNum = reader.GetOrdinal("ID");
                newID = reader.GetString(columnNum);
            }

            return newID;
        }
    }
}
