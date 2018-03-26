using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAG340MiddleWare
{
    class Agent : Savable
    {
        private string firstName;
        private string lastName;
        private string id;
        private string userName;
        private string hashPassword;
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
                    string inHashPassword, string inDept)
        {
            firstName = inFirstName;
            lastName = inLastName;
            id = inID;
            hashPassword = inHashPassword;
            dept = inDept;
        }

        public override void saveToDataBase()
        {

        }

        public LinkedList<Policy> search(string policyHolderFirstName, string policyHolderLastName, string policyNumber)
        {
            LinkedList<Policy> policyList = new LinkedList<Policy>();

            return policyList;
        }

        public LinkedList<Policy> delinquentAccounts(string state, double amountOverdue)
        {
            LinkedList<Policy> policyList = new LinkedList<Policy>();

            return policyList;
        }

        public bool logIn(string inID, string inHashPassword)
        {
            bool access = false;

            return access;
        }

        public void logOut()
        {

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

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
    }
}
