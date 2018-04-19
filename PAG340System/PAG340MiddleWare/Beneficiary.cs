using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PAG340MiddleWare
{
    public class Beneficiary : Savable
    {
        private string firstName;
        private string lastName;
        
        public Beneficiary()
        {
            firstName = "";
            lastName = "";
        }

        public Beneficiary(string inFirstName, string inLastName)
        {
            firstName = inFirstName;
            lastName = inLastName;
        }

        public override void saveToDataBase()
        {

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
    }
}
