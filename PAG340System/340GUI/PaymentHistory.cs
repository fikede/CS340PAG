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
    public partial class PaymentHistory : Form
    {
        public PaymentHistory(PolicyPage inPage, Policy thePolicy)
        {
            InitializeComponent();
            previousePage = inPage;
            label_ShowPolicyNum.Text = thePolicy.PolicyNumber;
            label_ShowPolicyholderName.Text = thePolicy.Holder.FirstName + " " + thePolicy.Holder.LastName;
            List<PAG340MiddleWare.Payment> paymentHistory = thePolicy.GetPaymentHistory();

        }

        private void linkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previousePage.Show();
            this.Close();
        }

        private void shutDown(object sender, FormClosingEventArgs e)
        {
            //if (Application.OpenForms.Count == 4) Application.Exit();
        }
    }
}
