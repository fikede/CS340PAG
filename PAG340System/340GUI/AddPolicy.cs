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
        public AddPolicy(Policy thePolicy, Agent inUsingAgent)
        {
            InitializeComponent();
            inPolicy = thePolicy;
            usingAgent = inUsingAgent;
            //labels
            //label_ShowPolicyNumber.Text = inPolicy.PolicyNumber;      // do we have a method for this?
            label_ShowPolicyholderDOB.Text = inPolicy.Holder.BirthDate.ToString("yyyyMMdd"); //need to be fixed?
            label_ShowFatherAAD.Text = Convert.ToString(inPolicy.FathersAgeAtDeath);//need to be fixed?
            label_ShowMotherAAD.Text = Convert.ToString(inPolicy.MothersAgeAtDeath);//need to be fixed?
            label_ShowSmokingHistory.Text = Convert.ToString(inPolicy.SmokingHis);//need to be fixed?
            label_ShowCigPerDay.Text = Convert.ToString(inPolicy.CigsPerDay);//need to be fixed?
            label_ShowSystolicBloodPressure.Text = Convert.ToString(inPolicy.SystolicBldPressure);//need to be fixed?
            label_ShowAverageFatPerDay.Text = Convert.ToString(inPolicy.GramsFatPerDay);//need to be fixed?
            label_ShowHeartDisease.Text = convertBool(inPolicy.HeartDisease);
            label_ShowCancer.Text = convertBool(inPolicy.Cancer);
            label_ShowHospitalized.Text = convertBool(inPolicy.Hospitalized);
            label_ShowDangerousActivities.Text = inPolicy.DangerousActivities;
            //label_ShowHoursOfExercise.Text = Convert.ToString(inPolicy.???????????); in the class Policy, there is no housrs of exercise per week
            label_ShowPolicyStartDate.Text = inPolicy.StartDate.ToString("yyyyMMdd");//need to be fixed?
            label_ShowPolicyEndDate.Text = inPolicy.EndDate.ToString("yyyyMMdd");//need to be fixed?
            label_ShowAgentNumber.Text = inPolicy.RepresentativeAgent.ID;
            label_ShowAgentFirstName.Text = inPolicy.RepresentativeAgent.Firstname;
            label_ShowAgentLastName.Text = inPolicy.RepresentativeAgent.Lastname;
            label_ShowPayoffAmount.Text = Convert.ToString(inPolicy.PayOffAmount);//need to be fixed?
            label_ShowMonthlyPremium.Text = Convert.ToString(inPolicy.Premium);//need to be fixed?
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
                AddPolicyMakeSure makeSure = new AddPolicyMakeSure(true, inPolicy, this, usingAgent);
                makeSure.Show();
                //inPolicy.saveToDataBase();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            AddPolicyMakeSure makeSure = new AddPolicyMakeSure(false, inPolicy, this, usingAgent);
            makeSure.Show();
        }

        private string convertBool(bool b)
        {
            if (b) return "Yes";
            else return "No";
        }

        private void AddPolicy_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
