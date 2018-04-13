﻿using System;
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
    public partial class Delinquent : Form
    {
        public Delinquent(Agent inUsingAgent)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
            listBox_DelinquentList.Visible = false;
            if (usingAgent.isManager())
            {
                label_ShowAgentFirstName.Visible = false;
                label_ShowAgentLastName.Visible = false;
            }
            else
            {
                textBox_AgentFirstName.Visible = false;
                textBox_AgentLastName.Visible = false;
                linkLabel_AddNewAgent.Visible = false;
                label_ShowAgentFirstName.Text = usingAgent.Firstname;
                label_ShowAgentLastName.Text = usingAgent.Lastname;
            }
        }

        private void AddAgent_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home(usingAgent);
            home.Show();
            this.Close();
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

        private void linkLabel_AddNewAgent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home(usingAgent);
            AddNewAgent addNewAgent = new AddNewAgent(usingAgent, home);
            addNewAgent.Show();
            this.Close();
        }

        private void linkLabel_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            IncompleteForm incomplete = new IncompleteForm();
            incomplete.Show();
            if(textBox_AgentFirstName.Text == null && textBox_AgentLastName.Text == null && textBox_AmountOverdue.Text == null && comboBox_State.Text == "No state specified")
            {
                listBox_DelinquentList.Visible = false;
            }
        }
    }
}
