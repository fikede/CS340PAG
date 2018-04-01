using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _340GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (matchingID("ID") && matchingPassword("PSSWRD") && IsItManager(""))
            {
               // if both ID and password are maching, go to ManagerHomePage
            }
            else if (matchingID("ID") && matchingPassword("PSSWRD") && !IsItManager(""))
            {
                // if both ID and password are matching, and not Manager's ID, then go to AgentHomePage
            }
            else
            {
                //if ID or password is incorrect, go to FailToLogin.cs
            }
        }

        private bool matchingID (string ID)
        {
            //hasing? find ID
            return true;
        }

        private bool matchingPassword (string password)
        {
            //find password
            return true;
        }

        private bool IsItManager (string ID)
        {
            //Is this Manager's ID?
            return true;
        }

        private void Agent_Number_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
