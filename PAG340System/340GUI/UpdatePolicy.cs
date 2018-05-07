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
    public partial class UpdatePolicy : Form
    {
        public UpdatePolicy(Agent inUsingAgent, PolicyPage policy, Policy usingPolicy, Search theSearchPage)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
            previousPage = policy;
            inPolicy = usingPolicy;
            searchPage = theSearchPage;
            //Labels, textBoxes, and comboBox are filled with the original info.
            label_ShowPolicyNumber.Text = inPolicy.PolicyNumber;
            textBox_PolicyholderFirstName.Text = inPolicy.Holder.FirstName;
            textBox_PolicyholderLastName.Text = inPolicy.Holder.LastName;
            textBox_AddressStreet.Text = inPolicy.Holder.Street;
            textBox_AddressCity.Text = inPolicy.Holder.City;
            comboBox_AddressState.Text = inPolicy.Holder.State;
            textBox_AddressZip.Text = inPolicy.Holder.ZIP;
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
            label_ShowHospitaized.Text = convertBool(inPolicy.Hospitalized);

            if (inPolicy.DangerousActivities != "")
            {
                label_ShowDangerousActivity.Text = inPolicy.DangerousActivities;
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

        private void button_SubmitChanges_Click(object sender, EventArgs e)
        {
            
            String[] arrayOfInputs = {textBox_PolicyholderFirstName.Text, textBox_PolicyholderLastName.Text, textBox_AddressStreet.Text, textBox_AddressCity.Text,
                comboBox_AddressState.Text, textBox_AddressZip.Text};
            if (incompleteInfo(arrayOfInputs))
            {
                UpdateMakeSure update = new UpdateMakeSure(searchPage, this, inPolicy, usingAgent, textBox_PolicyholderFirstName.Text, textBox_PolicyholderLastName.Text,
                textBox_AddressStreet.Text, textBox_AddressCity.Text, comboBox_AddressState.Text, textBox_AddressZip.Text, textBox_BeneficiaryFirstName.Text, textBox_BeneficiaryLastName.Text);
                update.Show();
            }
            else
            {
                UpdateWarning warning = new UpdateWarning();
                warning.Show();
            }
        }

        private string convertBool (bool b)
        {
            if (b) return "Yes";
            else return "No";
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            UpdateUnsave unsave = new UpdateUnsave(previousPage, this);
            unsave.Show();
        }

        private bool incompleteInfo(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == "") return false;
            }
            return true;
        }

        private void shutDown(object sender, FormClosingEventArgs e)
        {
            //if (Application.OpenForms.Count == 2) Application.Exit();
        }
    }
}
