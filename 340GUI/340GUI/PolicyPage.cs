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
        public PolicyPage(Agent inUsingAgent)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
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

        }

        private void linkLabel_UpdatePolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePolicy update = new UpdatePolicy(usingAgent, this);
            update.Show();
            this.Hide();
        }

        private void linkLabel_MakeClaim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MakeClaim claim = new MakeClaim();
            claim.Show();
        }
    }
}
