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
            textBox_Categories.Visible = false;
            comboBox_State.Text = "No State Specified";
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
            AddNewAgent addNewAgent = new AddNewAgent(usingAgent);
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
            //IncompleteForm incomplete = new IncompleteForm();
            //incomplete.Show();
            if(textBox_AgentFirstName.Text != "" || textBox_AgentLastName.Text != "" || textBox_AmountOverdue.Text != "" 
                || comboBox_State.Text != "No State Specified")
            {
                List<Policy> delinquentList = new List<Policy>();
                if (usingAgent.isManager())
                {
                    Manager usingManager = new Manager(usingAgent);
                    delinquentList = usingManager.delinquentAccounts(comboBox_State.Text, Convert.ToDouble(textBox_AmountOverdue.Text)
                        , textBox_AgentFirstName.Text, textBox_AgentLastName.Text);
                }
                else
                {
                    delinquentList = usingAgent.delinquentAccounts(comboBox_State.Text, Convert.ToDouble(textBox_AmountOverdue.Text));
                }

                foreach (Policy policy in delinquentList)
                {
                    string listString = alignItemString(policy);
                    listBox_DelinquentList.Items.Add(listString);
                }

                if (listBox_DelinquentList.Items.Count == 0)
                {
                    listBox_DelinquentList.Items.Add("There is no result.");
                }
                listBox_DelinquentList.Visible = true;
                textBox_Categories.Visible = true;
            }
        }

        private string alignItemString(Policy policy)
        {
            int length;
            string output = "   ";
            output += policy.PolicyNumber;
            length = 30 - policy.PolicyNumber.Length;
            for (int i = 0; i < length; i++) output += " ";
            output += policy.Holder.FirstName + " " + policy.Holder.LastName;
            length = 50 - (policy.Holder.FirstName.Length + policy.Holder.LastName.Length + 1);
            for (int i = 0; i < length; i++) output += " ";
            output += policy.RepresentativeAgent.Firstname + " " + policy.RepresentativeAgent.Lastname;
            length = 50 - (policy.RepresentativeAgent.Firstname.Length + policy.RepresentativeAgent.Lastname.Length + 1);
            for (int i = 0; i < length; i++) output += " ";
            //output += policy.Overdue; I cannot find overdue.
            return output;
        }

        private void shutDown(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1) Application.Exit();
        }
    }
}
