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
    public partial class MakeClaim : Form
    {
        public MakeClaim(Search search, Policy inPolicy, PolicyPage inPage)
        {
            InitializeComponent();
            goBack = search;
            usingPolicy = inPolicy;
            previousPage = inPage;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            //Make Claim method
            //need to be fixed
            double lossRate = 3.2;
            double moreLossRate = 5.4;
            if (usingPolicy.CalculateProfitMade() >= lossRate && usingPolicy.CalculateProfitMade() < moreLossRate)
            {
                LossWarning warning = new LossWarning(lossRate, previousPage);
                warning.Show();
            }
            else if (usingPolicy.CalculateProfitMade() >= moreLossRate)
            {
                LossWarning warning = new LossWarning(moreLossRate, previousPage);
                warning.Show();
            }
            else
            {
                goBack.Show();
                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
