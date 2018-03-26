using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAG340MiddleWare
{
    class Manager : Agent
    {
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
    }
}
