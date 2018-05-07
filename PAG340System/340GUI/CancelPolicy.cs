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
        public CancelPolicy(Policy thePolicy, PolicyPage policyPage)
        {
            InitializeComponent();
            inPolicy = thePolicy;
            previousPage = policyPage;
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            inPolicy.CancelPolicy();
            previousPage.updateEndDate(DateTime.Today);
            this.Close();
            previousPage.Refresh();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
