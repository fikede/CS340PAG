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
    public partial class CancelPolicy : Form
    {
        public CancelPolicy(Agent inUsingAgent, PolicyPage policy)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
            previousPage = policy;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Home home = new Home(usingAgent);
            home.Show();
            this.Close();
            previousPage.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
