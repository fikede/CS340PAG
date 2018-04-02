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
            IncompleteForm incomplete = new IncompleteForm();
            incomplete.Show();
        }

        private void linkLabel_Search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncompleteForm incomplete = new IncompleteForm();
            incomplete.Show();
        }
        private void ManagerHome_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_DelinquentAccounts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncompleteForm incomplete = new IncompleteForm();
            incomplete.Show();
        }

        private void linkLabel_AddNewAgent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewAgent addNewAgent = new AddNewAgent();
            addNewAgent.Show();
        }

        private void pictureBox_LICLogo_Click(object sender, EventArgs e)
        {
            Home homePage = new Home(usingAgent);
            this.Hide();
            homePage.Show();
        }

        private void linkLabel_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginPage = new Login();
            this.Close();
            loginPage.Show();
        }
    }
}
