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
    public partial class AddAgentMakeSure : Form
    {
        public AddAgentMakeSure(AddNewAgent inPage, Agent inUsingAgent, bool submit)
        {
            InitializeComponent();
            previousPage = inPage;
            usingAgent = inUsingAgent;
            if (submit) {
                label_CancelConfirm.Visible = false;
                button_Yes.Visible = false;
                button_No.Visible = false;
            }
            else
            {
                label_SubmitSuccess.Visible = false;
                button_Ok.Visible = false;
            }
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            Home home = new Home(usingAgent);
            home.Show();
            previousPage.Close();
            this.Close();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            Home home = new Home(usingAgent);
            home.Show();
            previousPage.Close();
            this.Close();
        }
    }
}
