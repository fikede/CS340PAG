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
    public partial class PricePolicy : Form
    {
        public PricePolicy(Agent inUsingAgent)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
            label_dateWarning.Visible = false;
            label_ShowTotalAmountOfPayment.Visible = false;
            radioButton_NoCancer.Checked = true;
            radioButton_NoHeartDisease.Checked = true;
            radioButton_NoHospitalized.Checked = true;
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if(label_ShowTotalAmountOfPayment.Visible)
            {
                pricingPolicy.Premium = Convert.ToDouble(label_ShowTotalAmountOfPayment.Text);
                pricingPolicy.StartDate = DateTime.Today;
                pricingPolicy.Holder.ID = pricingPolicy.Holder.getNextId();
                pricingPolicy.PolicyNumber = pricingPolicy.getNextNumber();
                AddPolicy addPolicy = new AddPolicy(pricingPolicy, usingAgent, this);
                addPolicy.Show();
                this.Hide();
            }
            else
            {
                PriceButtonWarning priceFirst = new PriceButtonWarning(true);
                priceFirst.Show();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            PricePolicyWarning warning = new PricePolicyWarning(usingAgent, this);
            warning.Show();
        }

        private void button_Price_Click(object sender, EventArgs e)
        {
            if (!textBox_PolicyholderDOB.Text.Contains("/")) label_dateWarning.Visible = true;
            else if (textBox_PolicyholderDOB.Text == "" || textBox_FatherAAD.Text == "" || textBox_MotherAAD.Text == "" || textBox_SmokingHistory.Text == ""
                || textBox_CigPerDay.Text == "" || textBox_PayOffAmount.Text == "")
            {
                PriceButtonWarning priceFirst = new PriceButtonWarning(false);
                priceFirst.Show();
            }
            else
            {
                string stringDOB = textBox_PolicyholderDOB.Text;
                double value;
                if (Double.TryParse(textBox_FatherAAD.Text, out value))
                {

                }
                DateTime DOB = DateTime.Parse(textBox_PolicyholderDOB.Text);
                pricingPolicy = new Policy(DOB, Convert.ToDouble(textBox_FatherAAD.Text), Convert.ToDouble(textBox_MotherAAD.Text), Convert.ToDouble(textBox_CigPerDay.Text),
                    Convert.ToDouble(textBox_SmokingHistory.Text), Convert.ToDouble(textBox_SystolicBloodPressure.Text), Convert.ToDouble(textBox_AverageFatPerDay.Text),
                    radioButton_YesHeartDisease.Checked, radioButton_YesCancer.Checked, radioButton_YesHospitalized.Checked, textBox_DangerousActivity.Text);
                pricingPolicy.PayOffAmount = Convert.ToDouble(textBox_PayOffAmount.Text);
                double premium = pricingPolicy.PricePolicy();
                label_ShowTotalAmountOfPayment.Text = " " + premium;
                label_ShowTotalAmountOfPayment.Visible = true;
            }
        }

        private void shutDown(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2) Application.Exit();
        }

        private bool correctInputName()
        {

            return false;
        }

        private bool correctInputDate()
        {

            return false;
        }

        private bool correctInputDouble()
        {

            return false;
        }

        private bool correctInputString()
        {

            return false;
        }
    }
}
