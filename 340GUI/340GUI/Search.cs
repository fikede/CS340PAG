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

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void textBox_PolicyNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Search search = new Search(usingAgent);
            search.Show();
            this.Close();
        }

        private void linkLabel_CreatePolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PricePolicy pricePolicy = new PricePolicy(usingAgent);
            pricePolicy.Show();
            this.Close();
        }

        private void linkLabel_DelinquentAccounts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Delinquent delinquent = new Delinquent(usingAgent);
            delinquent.Show();
            this.Close();
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

        private void textBox_AgentFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_AgentLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_PolicyholderFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_PolicyholderLastName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel_AddNewAgent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home(usingAgent);
            AddNewAgent addNewAgent = new AddNewAgent(usingAgent, home);
            addNewAgent.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label_AgentLastName_Click(object sender, EventArgs e)
        {

        }

        private void label_AgentFirstName_Click(object sender, EventArgs e)
        {
            //if()
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
