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
    public partial class FailToLogin : Form
    {
        public FailToLogin()
        {
            InitializeComponent();
        }

        private void FailToLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
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
                this.Close();
            }
        }
    }
}
