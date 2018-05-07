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
        public LossWarning(double profit, PolicyPage inPage, MakeClaim claim)
        {
            InitializeComponent();
            prepreviousPage = inPage;
            previousPage = claim;
            if(profit > -5.0)
            {
                label_WarningComment1.Text = "A loss of" + (-profit) + " percent has been detected";
                label_MoreLoss1.Visible = false;
                label_MoreLoss2.Visible = false;
            }
            else
            {
                label_MoreLoss1.Text = "A loss of " + (-profit) + " percent has been detected";
                label_WarningComment1.Visible = false;
                label_WarningComment2.Visible = false;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            prepreviousPage.Refresh();
            previousPage.Close();
            this.Close();
        }
    }
}
