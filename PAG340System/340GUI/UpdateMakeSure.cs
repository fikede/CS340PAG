using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAG340MiddleWare;

namespace _340GUI
{
    public partial class UpdateMakeSure : Form
    {
        public UpdateMakeSure(Search theSearchPage,PolicyPage inPage, Policy inUsingPolicy, Agent inUsingAgent, string policyholderFirstName, string policyholderLastName, 
            string addressStreet, string addressCity, string addressState, string addressZIP, string theBenefFirstName, string theBenefLastName)
        {
            InitializeComponent();
            searchPage = theSearchPage;
            previousPage = inPage;
            usingPolicy = inUsingPolicy;
            usingAgent = inUsingAgent;
            phFirstName = policyholderFirstName;
            phLastName = policyholderLastName;
            street = addressStreet;
            city = addressCity;
            state = addressState;
            zIP = addressZIP;
            benefFirstName = theBenefFirstName;
            benefLastName = theBenefLastName;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            usingPolicy.AddPolicyInfo(phFirstName, phLastName, street, city, state, zIP, benefFirstName, benefLastName);
            PolicyPage policy = new PolicyPage(usingAgent, searchPage, usingPolicy);
            policy.Show();
            SuccessPage success = new SuccessPage();
            success.Show();
        }
    }
}
