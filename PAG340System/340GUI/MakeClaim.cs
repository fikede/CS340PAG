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
            label_profitMade.Visible = false;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            //Make Claim method
            //need to be fixed
            usingPolicy.CancelPolicy();
            Payment claim = new Payment(usingPolicy.PolicyNumber, DateTime.Today, usingPolicy.PayOffAmount, 'C');
            claim.saveToDataBase();
            double profit = usingPolicy.CalculateProfitMade();
            if (profit < 0.0)
            {
                LossWarning warning = new LossWarning(profit, previousPage, this);
                warning.Show();
            }
            else
            {
                label_profitMade.Visible = true;
                label_profitMade.Text = "The company made " + profit + " percent profit!";
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
