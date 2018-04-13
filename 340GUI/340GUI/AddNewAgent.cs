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
    public partial class AddNewAgent : Form
    {
        public AddNewAgent(Agent inAgent, Home inPage)
        {
            InitializeComponent();
            usingManager = new Manager(inAgent);
            label_ShowAgentNumber.Text = usingManager.getNextId();
            previousPage = inPage;
        }

        private void Amount_Overdue_isAt_Least_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_AgentFirstName.Text == "" || textBox_AgentLastName.Text == ""|| textBox_Username.Text == "" || textBox_Password.Text =="")
            {

            }
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
            AddAgentMakeSure makeSurePage = new AddAgentMakeSure(this, previousPage);
            makeSurePage.Show();
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            AddAgentMakeSure confirmPage = new AddAgentMakeSure(this , previousPage);
            confirmPage.Show();
        }

        private string getUserTypeCharacter(String s)
        {
            if (s.Equals("Manager")) return "M";
            else return "A";
        }
    }
}
