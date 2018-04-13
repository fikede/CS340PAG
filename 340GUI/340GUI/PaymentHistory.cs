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
        public PaymentHistory(PolicyPage inPage, String policyNum, String holderFirstName, String holderLastName)
        {
            InitializeComponent();
            previousePage = inPage;
            label_ShowPolicyNum.Text = policyNum;
            label_ShowPolicyholderName.Text = holderFirstName + " " + holderLastName;
        }

        private void linkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previousePage.Show();
            this.Close();
        }
    }
}
