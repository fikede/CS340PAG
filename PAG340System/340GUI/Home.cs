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
    public partial class Home : Form
    {
        public Home(Agent inUsingAgent)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
            if(!usingAgent.isManager())
            {
                linkLabel_AddNewAgent.Visible = false;
            }
        }

        private void linkLabel_CreatePolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PricePolicy pricePolicy = new PricePolicy(usingAgent);
            pricePolicy.Show();
            this.Close();
        }

        private void linkLabel_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Search search = new Search(usingAgent);
            search.Show();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_DelinquentAccounts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Delinquent delinquent = new Delinquent(usingAgent);
            delinquent.Show();
            this.Close();
        }

        private void linkLabel_AddNewAgent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewAgent addNewAgent = new AddNewAgent(usingAgent);
            addNewAgent.Show();
            this.Close();
        }

        private void pictureBox_LICLogo_Click(object sender, EventArgs e)
        {
            Home homePage = new Home(usingAgent);
            homePage.Show();
            this.Close();
        }

        private void linkLabel_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Close();
        }
    }
}
