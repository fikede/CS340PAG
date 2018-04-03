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
    public partial class AddNewAgent : Form
    {
        public AddNewAgent(Agent inAgent, Home inPage)
        {
            InitializeComponent();
            usingManager = new Manager(inAgent);
            previousPage = inPage;
        }

        private void Amount_Overdue_isAt_Least_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            String AgentNumber = label_ShowAgentNumber.Text;
            String UserName = textBox_Username.Text;
            String AgentFirstName = textBox_AgentFirstName.Text;
            String AgentLastName = textBox_AgentLastName.Text;
            String Password = textBox_Password.Text;
            String UserType = getUserTypeCharacter(comboBox_UserType.Text);
            String DateOfBirth = textBox_DateOfBirthday.Text;
            String Department = comboBox_Department.Text;
            Agent newAgent = new Agent(AgentFirstName, AgentLastName, AgentNumber, UserName, Password, UserType, Department);
            usingManager.addAgent(newAgent);            
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            AddAgentMakeSure confirmPage = new AddAgentMakeSure(this , previousPage);
            confirmPage.Show();
        }

        private void comboBox_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string getUserTypeCharacter(String s)
        {
            if (s.Equals("Manager")) return "M";
            else return "A";
        }
    }
}
