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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pictureBox_Warning.Visible = false;
            label_WarningComment.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agent usingAgent = new Agent();
            string id = textBox_AgentNumber.Text;
            string password = textBox_Password.Text;
            if (usingAgent.logIn(id, password))
            {
                Home homePage = new Home(usingAgent);
                this.Hide();
                homePage.Show();
            }
            else
            {
                pictureBox_Warning.Visible = true;
                label_WarningComment.Visible = true;
            }
        }
    }
}
