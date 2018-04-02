using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PAG340MiddleWare
{
    public class Payment : Savable
    {
        private string policyNumber;
        private DateTime date;
        private double amount;
        private char type;

        public Payment()
        {
            policyNumber = "";
            date = new DateTime();
            amount = 0.0;
            type = ' ';
        }

        public Payment(string inPolicyNumber, DateTime inDate, double inAmount, char inType)
        {
            policyNumber = inPolicyNumber;
            date = inDate;
            amount = inAmount;
            type = inType;
        }

        public override void saveToDataBase()
        {

        }

        public string PolicyNumber
        {
            get { return policyNumber; }
            set { policyNumber = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public char Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
