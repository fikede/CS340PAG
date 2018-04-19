using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
