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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                FailToLogin failed = new FailToLogin();
                failed.Show();
                this.Hide();
            }
        }

        private void textBox_AgentNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
