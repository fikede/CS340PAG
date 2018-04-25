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
            label_ShowPolicyholderDOB.Text = inPolicy.Holder.BirthDate.ToString("yyyyMMdd"); //need to be fixed?
            label_ShowFatherAAD.Text = Convert.ToString(inPolicy.FathersAgeAtDeath);//need to be fixed?
            label_ShowMotherAAD.Text = Convert.ToString(inPolicy.MothersAgeAtDeath);//need to be fixed?
            label_ShowSmokingHistory.Text = Convert.ToString(inPolicy.SmokingHis);//need to be fixed?
            label_ShowCigPerDay.Text = Convert.ToString(inPolicy.CigsPerDay);//need to be fixed?
            label_ShowSystolicBloodPressure.Text = Convert.ToString(inPolicy.SystolicBldPressure);//need to be fixed?
            label_ShowAverageFatPerDay.Text = Convert.ToString(inPolicy.GramsFatPerDay);//need to be fixed?
            label_ShowHeartDisease.Text = convertBool(inPolicy.HeartDisease);
            label_ShowCancer.Text = convertBool(inPolicy.Cancer);
            label_ShowHospitaized.Text = convertBool(inPolicy.Hospitalized);
            label_ShowDangerousActivity.Text = inPolicy.DangerousActivities;
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

        private void button_SubmitChanges_Click(object sender, EventArgs e)
        {
            UpdateMakeSure update = new UpdateMakeSure(searchPage, previousPage, inPolicy, usingAgent, textBox_PolicyholderFirstName.Text, textBox_PolicyholderLastName.Text,
                textBox_AddressStreet.Text, textBox_AddressCity.Text, comboBox_AddressState.Text, textBox_AddressZip.Text, textBox_BeneficiaryFirstName.Text, textBox_BeneficiaryLastName.Text);
            update.Show();
        }

        private string convertBool (bool b)
        {
            if (b) return "Yes";
            else return "No";
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            String[] arrayOfInputs = {textBox_PolicyholderFirstName.Text, textBox_PolicyholderLastName.Text, textBox_AddressStreet.Text, textBox_AddressCity.Text,
                comboBox_AddressState.Text, textBox_AddressZip.Text, textBox_BeneficiaryFirstName.Text, textBox_BeneficiaryLastName.Text};
            if (incompleteInfo(arrayOfInputs))
            {
                UpdateUnsave updateUnsave = new UpdateUnsave(searchPage, previousPage, inPolicy, usingAgent, textBox_PolicyholderFirstName.Text, textBox_PolicyholderLastName.Text,
                textBox_AddressStreet.Text, textBox_AddressCity.Text, comboBox_AddressState.Text, textBox_AddressZip.Text, textBox_BeneficiaryFirstName.Text, textBox_BeneficiaryLastName.Text);
                updateUnsave.Show();
            }
            else
            {
                UpdateWarning warning = new UpdateWarning();
                warning.Show();
            }
        }

        private bool incompleteInfo(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == "") return false;
            }
            return true;
        }
    }
}
