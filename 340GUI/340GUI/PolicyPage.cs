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
    public partial class PolicyPage : Form
    {
        public PolicyPage(Agent inUsingAgent, Search inPage)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
            previousPage = inPage;
        }

        private void PolicyPage_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_CancelPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CancelPolicy cancelPolicy = new CancelPolicy(usingAgent, this);
            cancelPolicy.Show();
        }

        private void linkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            previousPage.Show();
        }

        private void linkLabel_UpdatePolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePolicy update = new UpdatePolicy(usingAgent, this);
            update.Show();
            this.Hide();
        }

        private void linkLabel_MakeClaim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MakeClaim claim = new MakeClaim(previousPage);
            claim.Show();
        }

        private void linkLabel_ViewPaymentHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PaymentHistory payment = new PaymentHistory(this, label_ShowPolicyNumber.Text, label_ShowPolicyholderFirstName.Text, label_ShowPolicyholderLastName.Text);
            payment.Show();
            this.Hide();
        }
    }
}
