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
    public partial class PricePolicyWarning : Form
    {
        public PricePolicyWarning(Agent inUsingAgent, PricePolicy inPage)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
            previousPage = inPage;
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            Home home = new Home(usingAgent);
            home.Show();
            this.Close();
            previousPage.Close();
        }
    }
}
