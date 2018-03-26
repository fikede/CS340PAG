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

        public LinkedList<Policy> search(string policyHolderFirstName, string policyHolderLastName, string agentFirstName, string agentLastName, string policyNumber)
        {
            LinkedList<Policy> policyList = new LinkedList<Policy>();

            return policyList;
        }

        public LinkedList<Policy> delinquentAccounts(string state, double amountOverdue, string agentFirstName, string agentLastName)
        {
            LinkedList<Policy> policyList = new LinkedList<Policy>();

            return policyList;
        }

        public void addAgent( Agent inAgent)
        {
            inAgent.saveToDataBase();
        }
    }
}
