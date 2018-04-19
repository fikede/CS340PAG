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
    public partial class LossWarning : Form
    {
        public LossWarning(double LossRate, PolicyPage inPage)
        {
            InitializeComponent();
            previousPage = inPage;
            double Loss = 3.2;
            if(LossRate == Loss)
            {
                label_MoreLoss1.Visible = false;
                label_MoreLoss2.Visible = false;
            }
            else
            {
                label_WarningComment1.Visible = false;
                label_WarningComment2.Visible = false;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            previousPage.Show();
            this.Close();
        }
    }
}
