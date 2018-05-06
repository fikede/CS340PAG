using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PAG340MiddleWare.Properties;

namespace PAG340MiddleWare
{
    public class PolicyHolder : Savable
    {
        private string firstName;
        private string lastName;
        private string id;
        private DateTime birthDate;
        private string street;
        private string city;
        private string state;
        private string zip;

        public PolicyHolder()
        {
            firstName = "";
            lastName = "";
            id = "";
            birthDate = new DateTime();
            street = "";
            city = "";
            state = "";
            zip = "";
        }

        public PolicyHolder(string inFirstName, string inLastName, string inID, DateTime inBirthDate, string inStreet, string inCity, string inState, string inZIP)
        {
            firstName = inFirstName;
            lastName = inLastName;
            id = inID;
            birthDate = inBirthDate;
            street = inStreet;
            city = inCity;
            state = inState;
            zip = inZIP;
        }

        public override void saveToDataBase()
        {
            String connectionString = Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "addPolicyHolder";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@street", street);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@zip", zip);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AddPolicyInfo(string inFirstName, string inLastName, string inStreet, string inCity, string inState, string inZIP)
        {
            firstName = inFirstName;
            lastName = inLastName;
            street = inStreet;
            city = inCity;
            state = inState;
            zip = inZIP;
        }

        public string getNextId()
        {
            String connectionString = Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "EXECUTE returnPolicyHolderID";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            String newID = "";

            if (reader.Read())
            {
                int columnNum = reader.GetOrdinal("ID");
                newID = reader.GetString(columnNum);
                newID = addOneToID(newID);
            }
            conn.Close();
            return newID;
        }

        private string addOneToID(string newID)
        {
            char[] charNewID = new char[newID.Length];
            bool notAddedOne = true;
            for (int i = newID.Length - 1; i >= 0; i--)
            {
                if (newID[i] == '9' && notAddedOne)
                {
                    charNewID[i] = '0';
                }
                else if (notAddedOne)
                {
                    charNewID[i] = newID[i];
                    charNewID[i]++;
                    notAddedOne = false;
                }
                else
                {
                    charNewID[i] = newID[i];
                }
            }
            String outID = new String(charNewID);

            return outID;
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

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string ZIP
        {
            get { return zip; }
            set { zip = value; }
        }
    }
}
