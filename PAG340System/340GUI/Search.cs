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
    public partial class Search : Form
    {
        public Search(Agent inUsingAgent)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
            listBox_Searching.Visible = false;
            label_WarningStatement1.Visible = false;
            label_WarningStatement2.Visible = false;
            pictureBox_Warning.Visible = false;
            if (usingAgent.isManager())
            {
                label_ShowAgentFirstName.Visible = false;
                label_ShowAgentLastName.Visible = false;
            }
            else
            {
                linkLabel_AddNewAgent.Visible = false;
                textBox_AgentFirstName.Visible = false;
                textBox_AgentLastName.Visible = false;
                label_ShowAgentFirstName.Text = usingAgent.Firstname;
                label_ShowAgentLastName.Text = usingAgent.Lastname;
            }
        }

        private void linkLabel_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Search search = new Search(usingAgent);
            search.Show();
            this.Close();
        }

        private void linkLabel_CreatePolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncompleteFeature incomplete = new IncompleteFeature();
            incomplete.Show();
            //PricePolicy pricePolicy = new PricePolicy(usingAgent);
            //pricePolicy.Show();
            //this.Close();
        }

        private void linkLabel_DelinquentAccounts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncompleteFeature incomplete = new IncompleteFeature();
            incomplete.Show();
            //Delinquent delinquent = new Delinquent(usingAgent);
            //delinquent.Show();
            //this.Close();
        }

        private void linkLabel_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void linkLabe_Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home(usingAgent);
            home.Show();
            this.Close();
        }

        private void linkLabel_AddNewAgent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home(usingAgent);
            AddNewAgent addNewAgent = new AddNewAgent(usingAgent);
            addNewAgent.Show();
            this.Close();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_PolicyNumber.Text != "" || textBox_AgentFirstName.Text != "" || textBox_AgentLastName.Text != "" || 
                textBox_PolicyholderFirstName.Text != "" || textBox_PolicyholderLastName.Text != "")
            {
                if (usingAgent.isManager())
                {
                    Manager usingManager = new Manager(usingAgent);
                    policyList = usingManager.search(textBox_PolicyholderFirstName.Text, textBox_PolicyholderLastName.Text, textBox_AgentFirstName.Text, 
                        textBox_AgentLastName.Text, textBox_PolicyNumber.Text);
                }
                else
                {
                    policyList = usingAgent.search(textBox_PolicyholderFirstName.Text, textBox_PolicyholderLastName.Text, textBox_PolicyNumber.Text);
                }
   
                foreach (Policy policy in policyList)
                {
                    string listString = alignItemString(policy);
                    listBox_Searching.Items.Add(listString);
                }

                pictureBox_Warning.Visible = false;
                label_WarningStatement1.Visible = false;
                label_WarningStatement2.Visible = false;
                listBox_Searching.Visible = true;
            }
            else
            {
                pictureBox_Warning.Visible = true;
                label_WarningStatement1.Visible = true;
                label_WarningStatement2.Visible = true;
                listBox_Searching.Visible = false;
            }
        }

        private string alignItemString(Policy policy)
        {
            int length;
            string output = "";
            output += policy.PolicyNumber;
            length = 30 - policy.PolicyNumber.Length;
            for (int i = 0; i < length; i++) output += " ";
            output += policy.Holder.FirstName + " " + policy.Holder.LastName;
            length = 50 - (policy.Holder.FirstName.Length + policy.Holder.LastName.Length + 1);
            for (int i = 0; i < length; i++) output += " ";
            output += policy.RepresentativeAgent.Firstname + " " + policy.RepresentativeAgent.Lastname;
            return output;
        }

        private void listBox_Searching_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_Searching.SelectedIndex;
            Policy policy = policyList.ElementAt(index);
            PolicyPage policyPage = new PolicyPage(usingAgent, this, policy);
            policyPage.Show();
            this.Hide();
        }

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
