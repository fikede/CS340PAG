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
        }

        private void PricePolicy_Load(object sender, EventArgs e)
        {

        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if(label_ShowTotalAmountOfPayment.Visible)
            {
                AddPolicy addPolicy = new AddPolicy();
                addPolicy.Show();
            }
            else
            {
                PriceFirstError priceFirst = new PriceFirstError();
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
            //Policy pricing = new Policy(label_FatherAAD.Text, label_MotherAAD.Text, )
            //Policy(double inFathersAgeAtDeath, double inMothersAgeAtDeath, double inCigsPerDay, double inSmokingHis, double inSystolicBldPressure,
            //double inGramsFatPerDay, bool inHeartDisease, bool inCancer, bool inHospitalized, string inDangerousActivities)
            //label_ShowTotalAmountOfPayment = PricePolicy();
            if (textBox_PolicyholderDOB.Text != null && textBox_FatherAAD.Text != null && textBox_MotherAAD.Text != null && textBox_SmokingHistory.Text != null
                && textBox_CigPerDay.Text != null && textBox_HoursOfExercise.Text != null)
            {
                label_ShowPayoffAmount.Visible = true;
                label_ShowTotalAmountOfPayment.Visible = true;
            }
            else
            {
                PricePolicyWarning warning = new PricePolicyWarning(usingAgent, this);
                warning.Show();
            }
        }
    }
}
