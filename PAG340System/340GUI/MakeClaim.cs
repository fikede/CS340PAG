﻿using System;
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
        public MakeClaim(Search search, Policy inPolicy, PolicyPage inPage, Agent agent)
        {
            InitializeComponent();
            goBack = search;
            usingPolicy = inPolicy;
            previousPage = inPage;
            label_profitMade.Visible = false;
            button_Ok.Visible = false;
            usingAgent = agent;
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
            previousPage.updateEndDate(DateTime.Today);
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
                button_Cancel.Visible = false;
                button_Confirm.Visible = false;
                button_Ok.Visible = true;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
            previousPage.Close();
            PolicyPage newPage = new PolicyPage(usingAgent, goBack, usingPolicy);
        }
    }
}
