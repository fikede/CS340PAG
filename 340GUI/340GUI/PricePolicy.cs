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
            label_ShowTotalAmountOfPayment.Visible = false;
            label_ShowPayoffAmount.Visible = false;
            radioButton_YesCancer.Checked = true;
            radioButton_YesHeartDisease.Checked = true;
            radioButton_YesHospitalized.Checked = true;
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if(label_ShowTotalAmountOfPayment.Visible)
            {
                AddPolicy addPolicy = new AddPolicy(pricingPolicy, usingAgent);
                addPolicy.Show();
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
            if (textBox_PolicyholderDOB.Text == "" || textBox_FatherAAD.Text == "" || textBox_MotherAAD.Text == "" || textBox_SmokingHistory.Text == ""
                || textBox_CigPerDay.Text == "" || textBox_HoursOfExercise.Text != "")
            {
                PriceButtonWarning priceFirst = new PriceButtonWarning(false);
                priceFirst.Show();
            }
            else
            {
                pricingPolicy = new Policy(Int32.Parse(textBox_FatherAAD.Text), Int32.Parse(textBox_MotherAAD.Text), Int32.Parse(textBox_CigPerDay.Text),
                    Int32.Parse(textBox_SmokingHistory.Text), Int32.Parse(textBox_SystolicBloodPressure.Text), Int32.Parse(textBox_AverageFatPerDay.Text),
                    radioButton_YesHeartDisease.Checked, radioButton_YesCancer.Checked, radioButton_YesHospitalized.Checked, textBox_DangerousActivity.Text);
                //label_ShowPayoffAmount.Text = Convert.ToString(pricing.PricePolicy);
                label_ShowTotalAmountOfPayment.Text = Convert.ToString(pricingPolicy.PricePolicy());
                label_ShowPayoffAmount.Visible = true;
                label_ShowTotalAmountOfPayment.Visible = true;
            }
        }
    }
}
