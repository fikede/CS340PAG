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
                label_ShowDangerousActivity.Text = inPolicy.DangerousActivities;
            }

            label_ShowPolicyStartDate.Text = inPolicy.StartDate.ToString("yyyy/MM/dd");

            String endDate = inPolicy.EndDate.ToString("yyyy/MM/dd");
            if (endDate != "0001/01/01")
            {
                label_ShowPolicyEndDate.Text = endDate;
            }

            label_ShowAgentNumber.Text = inPolicy.RepresentativeAgent.ID;
            label_ShowAgentFirstName.Text = inPolicy.RepresentativeAgent.Firstname;
            label_ShowAgentLastName.Text = inPolicy.RepresentativeAgent.Lastname;
            label_ShowPayoffAmount.Text = Convert.ToString(inPolicy.PayOffAmount);
            label_ShowMonthlyPremium.Text = Convert.ToString(inPolicy.Premium);

            List<Beneficiary> beneficiariesList = usingPolicy.GetBeneficiaries();
            if (beneficiariesList.Count == 0) listBox_BeneficiaryName.Items.Add("There are no beneficiaries.");
            else
            {
                foreach (Beneficiary beneficiaryNames in beneficiariesList)
                {
                    listBox_BeneficiaryName.Items.Add(beneficiaryNames.FirstName + " " + beneficiaryNames.LastName);
                }
            }
            //label_ShowBeneficiaryFirstName.Text = inPolicy.Beneficiary.FirstName;
            //label_ShowBeneficiaryLastName.Text = inPolicy.Beneficiary.LastName;
        }

        private void linkLabel_CancelPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //IncompleteFeature incomplete = new IncompleteFeature();
            //incomplete.Show();
            if (label_ShowPolicyEndDate.Text == "N/A")
            {
                CancelPolicy cancelPolicy = new CancelPolicy(inPolicy, this);
                cancelPolicy.Show();
            }
            else
            {
                PolicyWarning warning = new PolicyWarning();
                warning.Show();
            }
        }

        private void linkLabel_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            previousPage.Show();
        }

        private void linkLabel_UpdatePolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //IncompleteFeature incomplete = new IncompleteFeature();
            //incomplete.Show();
            UpdatePolicy update = new UpdatePolicy(usingAgent, this, inPolicy, previousPage);
            update.Show();
            this.Hide();
        }

        private void linkLabel_MakeClaim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //IncompleteFeature incomplete = new IncompleteFeature();
            //incomplete.Show();
            if (label_ShowPolicyEndDate.Text == "N/A")
            {
                MakeClaim claim = new MakeClaim(previousPage, inPolicy, this, usingAgent);
                claim.Show();
            }
            else
            {
                PolicyWarning warning = new PolicyWarning();
                warning.Show();
            }
        }

        private void linkLabel_ViewPaymentHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //IncompleteFeature incomplete = new IncompleteFeature();
            //incomplete.Show();
            PaymentHistory payment = new PaymentHistory(this, inPolicy);
            payment.Show();
            this.Hide();
        }

        private string convertBool(bool b)
        {
            if (b) return "Yes";
            else return "No";
        }

        private void shutDown(object sender, FormClosingEventArgs e)
        {
            //if (Application.OpenForms.Count == 3) Application.Exit();
        }

        public void updateEndDate(DateTime time)
        {
            label_ShowPolicyEndDate.Text = time.ToString("yyyy/MM/dd");
        }
    }
}
