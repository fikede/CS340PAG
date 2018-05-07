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
    public partial class AddPolicy : Form
    {
        public AddPolicy(Policy thePolicy, Agent inUsingAgent, PricePolicy pricePolicy)
        {
            InitializeComponent();
            inPolicy = thePolicy;
            usingAgent = inUsingAgent;
            previousPage = pricePolicy;
            //labels
            label_ShowPolicyNumber.Text = inPolicy.PolicyNumber;

            thePolicy.RepresentativeAgent = inUsingAgent;
            label_ShowPolicyholderDOB.Text = inPolicy.Holder.BirthDate.ToString("yyyy/MM/dd");

            if (Convert.ToString(inPolicy.FathersAgeAtDeath) != "0")
            {
                label_ShowFatherAAD.Text = Convert.ToString(inPolicy.FathersAgeAtDeath);
            }

            if (Convert.ToString(inPolicy.MothersAgeAtDeath) != "0")
            {
                label_ShowMotherAAD.Text = Convert.ToString(inPolicy.MothersAgeAtDeath);
            }

            label_ShowSmokingHistory.Text = Convert.ToString(inPolicy.SmokingHis);
            label_ShowCigPerDay.Text = Convert.ToString(inPolicy.CigsPerDay);
            label_ShowSystolicBloodPressure.Text = Convert.ToString(inPolicy.SystolicBldPressure);
            label_ShowAverageFatPerDay.Text = Convert.ToString(inPolicy.GramsFatPerDay);
            label_ShowHeartDisease.Text = convertBool(inPolicy.HeartDisease);
            label_ShowCancer.Text = convertBool(inPolicy.Cancer);
            label_ShowHospitalized.Text = convertBool(inPolicy.Hospitalized);

            if (inPolicy.DangerousActivities != "")
            {
                label_ShowDangerousActivities.Text = inPolicy.DangerousActivities;
            }

            label_ShowPolicyStartDate.Text = inPolicy.StartDate.ToString("yyyy/MM/dd");

            if (inPolicy.EndDate.ToString("yyyy/MM/dd") != "0001/01/01")
            {
                label_ShowPolicyEndDate.Text = inPolicy.EndDate.ToString("yyyy/MM/dd");
            }

            label_ShowAgentNumber.Text = inPolicy.RepresentativeAgent.ID;
            label_ShowAgentFirstName.Text = inPolicy.RepresentativeAgent.Firstname;
            label_ShowAgentLastName.Text = inPolicy.RepresentativeAgent.Lastname;
            label_ShowPayoffAmount.Text = "$" + Convert.ToString(inPolicy.PayOffAmount);
            label_ShowMonthlyPremium.Text = "$" + Convert.ToString(inPolicy.Premium);
            textBox_BeneficiaryFirstName.Text = inPolicy.Beneficiary.FirstName;
            textBox_BeneficiaryLastName.Text = inPolicy.Beneficiary.LastName;
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_ShowPolicyholderFirstName.Text == "" || textBox_ShowPolicyholderLastName.Text == "" || textBox_ShowAddressStreet.Text == "" 
                || textBox_AddressCity.Text == "" || comboBox_AddressState.Text == "" || textBox_AddressZip.Text == "" || textBox_BeneficiaryFirstName.Text == "" 
                || textBox_BeneficiaryLastName.Text == "")
            {
                AddPolicyWarning warning = new AddPolicyWarning();
                warning.Show();
            }
            else
            {
                inPolicy.AddPolicyInfo(textBox_ShowPolicyholderFirstName.Text, textBox_ShowPolicyholderLastName.Text, textBox_ShowAddressStreet.Text,
                    textBox_AddressCity.Text, comboBox_AddressState.Text, textBox_AddressZip.Text, textBox_BeneficiaryFirstName.Text, textBox_BeneficiaryLastName.Text);
                AddPolicyMakeSure makeSure = new AddPolicyMakeSure(true, inPolicy, this, usingAgent, previousPage);
                makeSure.Show();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            AddPolicyMakeSure makeSure = new AddPolicyMakeSure(false, inPolicy, this, usingAgent, previousPage);
            makeSure.Show();
        }

        private string convertBool(bool b)
        {
            if (b) return "Yes";
            else return "No";
        }

        private void shutDown(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2) Application.Exit();
        }
    }
}
