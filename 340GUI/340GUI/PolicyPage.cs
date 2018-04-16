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
        public PolicyPage(Agent inUsingAgent, Search inPage, Policy usingPolicy)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
            previousPage = inPage;
            inPolicy = usingPolicy;
            //Labels, textBoxes, and comboBox are filled with the original info.
            label_ShowPolicyNumber.Text = inPolicy.PolicyNumber;
            label_ShowPolicyholderFirstName.Text = inPolicy.Holder.FirstName;
            label_ShowPolicyholderLastName.Text = inPolicy.Holder.LastName;
            label_ShowAddressStreet.Text = inPolicy.Holder.Street;
            label_ShowAddressCity.Text = inPolicy.Holder.City;
            label_ShowAddressState.Text = inPolicy.Holder.State;
            label_ShowAddressZip.Text = inPolicy.Holder.ZIP;
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
            label_ShowDangerousActivity.Text = inPolicy.DangerousActivities;
            //label_ShowHoursOfExercise.Text = Convert.ToString(inPolicy.???????????); in the class Policy, there is no housrs of exercise per week
            label_ShowPolicyStartDate.Text = inPolicy.StartDate.ToString("yyyyMMdd");//need to be fixed?
            label_ShowPolicyEndDate.Text = inPolicy.EndDate.ToString("yyyyMMdd");//need to be fixed?
            label_ShowAgentNumber.Text = inPolicy.RepresentativeAgent.ID;
            label_ShowAgentFirstName.Text = inPolicy.RepresentativeAgent.Firstname;
            label_ShowAgentLastName.Text = inPolicy.RepresentativeAgent.Lastname;
            label_ShowPayoffAmount.Text = Convert.ToString(inPolicy.PayOffAmount);//need to be fixed?
            label_ShowMonthlyPremium.Text = Convert.ToString(inPolicy.Premium);//need to be fixed?
            label_ShowBeneficiaryFirstName.Text = inPolicy.Beneficiary.FirstName;
            label_ShowBeneficiaryLastName.Text = inPolicy.Beneficiary.LastName;
        }

        private void PolicyPage_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_CancelPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CancelPolicy cancelPolicy = new CancelPolicy(usingAgent, this, inPolicy);
            cancelPolicy.Show();
        }

        private void linkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            previousPage.Show();
        }

        private void linkLabel_UpdatePolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePolicy update = new UpdatePolicy(usingAgent, this, inPolicy, previousPage);
            update.Show();
            this.Hide();
        }

        private void linkLabel_MakeClaim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MakeClaim claim = new MakeClaim(previousPage, inPolicy, this);
            claim.Show();
        }

        private void linkLabel_ViewPaymentHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PaymentHistory payment = new PaymentHistory(this, inPolicy);
            payment.Show();
            this.Hide();
        }

        private string convertBool(bool b)
        {
            if (b) return "Yes";
            else return "No";
        }
    }
}
