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
    public partial class Home : Form
    {
        public Home(bool isManager)
        {
            InitializeComponent();
            if(!isManager)
            {
                linkLabel_AddNewAgent.Visible = false;
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Search nextForm = new Search();
            nextForm.Show();
            this.Close();
        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {

        }
    }
}
