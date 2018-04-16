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
        public AddAgentMakeSure(AddNewAgent inPage, Agent inUsingAgent)
        {
            InitializeComponent();
            previousPage = inPage;
            usingAgent = inUsingAgent;
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
    }
}
