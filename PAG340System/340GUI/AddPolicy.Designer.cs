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
    partial class AddPolicy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_BeneficiaryLastName = new System.Windows.Forms.Label();
            this.label_BeneficiaryFirstName = new System.Windows.Forms.Label();
            this.label_MonthlyPremium = new System.Windows.Forms.Label();
            this.label_PayoffAmount = new System.Windows.Forms.Label();
            this.label_AgentLastName = new System.Windows.Forms.Label();
            this.label_AgentFirstName = new System.Windows.Forms.Label();
            this.label_AgentNumber = new System.Windows.Forms.Label();
            this.label_PolicyEndDate = new System.Windows.Forms.Label();
            this.label_PolicyStartDate = new System.Windows.Forms.Label();
            this.label_DangerousActivities = new System.Windows.Forms.Label();
            this.label_Hospitalized = new System.Windows.Forms.Label();
            this.label_Cancer = new System.Windows.Forms.Label();
            this.label_HeartDisease = new System.Windows.Forms.Label();
            this.label_AverageFatPerDay = new System.Windows.Forms.Label();
            this.label_SystolicBloodPressure = new System.Windows.Forms.Label();
            this.label_CigPerDay = new System.Windows.Forms.Label();
            this.label_SmokingHistory = new System.Windows.Forms.Label();
            this.label_MotherAAD = new System.Windows.Forms.Label();
            this.label_FatherAAD = new System.Windows.Forms.Label();
            this.label_PolicyholderDOB = new System.Windows.Forms.Label();
            this.label_AddressZip = new System.Windows.Forms.Label();
            this.label_AddressState = new System.Windows.Forms.Label();
            this.label_AddressCity = new System.Windows.Forms.Label();
            this.label_AddressStreet = new System.Windows.Forms.Label();
            this.label_PolicyholderLastName = new System.Windows.Forms.Label();
            this.label_PolicyholderFirstName = new System.Windows.Forms.Label();
            this.label_PolicyNumber = new System.Windows.Forms.Label();
            this.textBox_ShowPolicyholderFirstName = new System.Windows.Forms.TextBox();
            this.textBox_ShowPolicyholderLastName = new System.Windows.Forms.TextBox();
            this.textBox_ShowAddressStreet = new System.Windows.Forms.TextBox();
            this.textBox_AddressCity = new System.Windows.Forms.TextBox();
            this.textBox_AddressZip = new System.Windows.Forms.TextBox();
            this.textBox_BeneficiaryFirstName = new System.Windows.Forms.TextBox();
            this.textBox_BeneficiaryLastName = new System.Windows.Forms.TextBox();
            this.comboBox_AddressState = new System.Windows.Forms.ComboBox();
            this.label_AddPolicy = new System.Windows.Forms.Label();
            this.label_ShowPolicyNumber = new System.Windows.Forms.Label();
            this.label_ShowPolicyholderDOB = new System.Windows.Forms.Label();
            this.label_ShowFatherAAD = new System.Windows.Forms.Label();
            this.label_ShowMotherAAD = new System.Windows.Forms.Label();
            this.label_ShowSmokingHistory = new System.Windows.Forms.Label();
            this.label_ShowCigPerDay = new System.Windows.Forms.Label();
            this.label_ShowSystolicBloodPressure = new System.Windows.Forms.Label();
            this.label_ShowAverageFatPerDay = new System.Windows.Forms.Label();
            this.label_ShowHeartDisease = new System.Windows.Forms.Label();
            this.label_ShowCancer = new System.Windows.Forms.Label();
            this.label_ShowHospitalized = new System.Windows.Forms.Label();
            this.label_ShowDangerousActivities = new System.Windows.Forms.Label();
            this.label_ShowPolicyStartDate = new System.Windows.Forms.Label();
            this.label_ShowPolicyEndDate = new System.Windows.Forms.Label();
            this.label_ShowAgentNumber = new System.Windows.Forms.Label();
            this.label_ShowAgentFirstName = new System.Windows.Forms.Label();
            this.label_ShowAgentLastName = new System.Windows.Forms.Label();
            this.label_ShowPayoffAmount = new System.Windows.Forms.Label();
            this.label_ShowMonthlyPremium = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_BeneficiaryLastName
            // 
            this.label_BeneficiaryLastName.AutoSize = true;
            this.label_BeneficiaryLastName.Location = new System.Drawing.Point(199, 643);
            this.label_BeneficiaryLastName.Name = "label_BeneficiaryLastName";
            this.label_BeneficiaryLastName.Size = new System.Drawing.Size(116, 13);
            this.label_BeneficiaryLastName.TabIndex = 55;
            this.label_BeneficiaryLastName.Text = "Beneficiary Last Name:";
            // 
            // label_BeneficiaryFirstName
            // 
            this.label_BeneficiaryFirstName.AutoSize = true;
            this.label_BeneficiaryFirstName.Location = new System.Drawing.Point(200, 620);
            this.label_BeneficiaryFirstName.Name = "label_BeneficiaryFirstName";
            this.label_BeneficiaryFirstName.Size = new System.Drawing.Size(115, 13);
            this.label_BeneficiaryFirstName.TabIndex = 54;
            this.label_BeneficiaryFirstName.Text = "Beneficiary First Name:";
            // 
            // label_MonthlyPremium
            // 
            this.label_MonthlyPremium.AutoSize = true;
            this.label_MonthlyPremium.Location = new System.Drawing.Point(225, 597);
            this.label_MonthlyPremium.Name = "label_MonthlyPremium";
            this.label_MonthlyPremium.Size = new System.Drawing.Size(90, 13);
            this.label_MonthlyPremium.TabIndex = 53;
            this.label_MonthlyPremium.Text = "Monthly Premium:";
            // 
            // label_PayoffAmount
            // 
            this.label_PayoffAmount.AutoSize = true;
            this.label_PayoffAmount.Location = new System.Drawing.Point(236, 574);
            this.label_PayoffAmount.Name = "label_PayoffAmount";
            this.label_PayoffAmount.Size = new System.Drawing.Size(79, 13);
            this.label_PayoffAmount.TabIndex = 52;
            this.label_PayoffAmount.Text = "Payoff Amount:";
            // 
            // label_AgentLastName
            // 
            this.label_AgentLastName.AutoSize = true;
            this.label_AgentLastName.Location = new System.Drawing.Point(223, 551);
            this.label_AgentLastName.Name = "label_AgentLastName";
            this.label_AgentLastName.Size = new System.Drawing.Size(92, 13);
            this.label_AgentLastName.TabIndex = 51;
            this.label_AgentLastName.Text = "Agent Last Name:";
            // 
            // label_AgentFirstName
            // 
            this.label_AgentFirstName.AutoSize = true;
            this.label_AgentFirstName.Location = new System.Drawing.Point(224, 528);
            this.label_AgentFirstName.Name = "label_AgentFirstName";
            this.label_AgentFirstName.Size = new System.Drawing.Size(91, 13);
            this.label_AgentFirstName.TabIndex = 50;
            this.label_AgentFirstName.Text = "Agent First Name:";
            // 
            // label_AgentNumber
            // 
            this.label_AgentNumber.AutoSize = true;
            this.label_AgentNumber.Location = new System.Drawing.Point(237, 505);
            this.label_AgentNumber.Name = "label_AgentNumber";
            this.label_AgentNumber.Size = new System.Drawing.Size(78, 13);
            this.label_AgentNumber.TabIndex = 49;
            this.label_AgentNumber.Text = "Agent Number:";
            // 
            // label_PolicyEndDate
            // 
            this.label_PolicyEndDate.AutoSize = true;
            this.label_PolicyEndDate.Location = new System.Drawing.Point(229, 482);
            this.label_PolicyEndDate.Name = "label_PolicyEndDate";
            this.label_PolicyEndDate.Size = new System.Drawing.Size(86, 13);
            this.label_PolicyEndDate.TabIndex = 48;
            this.label_PolicyEndDate.Text = "Policy End Date:";
            // 
            // label_PolicyStartDate
            // 
            this.label_PolicyStartDate.AutoSize = true;
            this.label_PolicyStartDate.Location = new System.Drawing.Point(226, 459);
            this.label_PolicyStartDate.Name = "label_PolicyStartDate";
            this.label_PolicyStartDate.Size = new System.Drawing.Size(89, 13);
            this.label_PolicyStartDate.TabIndex = 47;
            this.label_PolicyStartDate.Text = "Policy Start Date:";
            // 
            // label_DangerousActivities
            // 
            this.label_DangerousActivities.AutoSize = true;
            this.label_DangerousActivities.Location = new System.Drawing.Point(208, 436);
            this.label_DangerousActivities.Name = "label_DangerousActivities";
            this.label_DangerousActivities.Size = new System.Drawing.Size(107, 13);
            this.label_DangerousActivities.TabIndex = 45;
            this.label_DangerousActivities.Text = "Dangerous Activities:";
            // 
            // label_Hospitalized
            // 
            this.label_Hospitalized.AutoSize = true;
            this.label_Hospitalized.Location = new System.Drawing.Point(248, 413);
            this.label_Hospitalized.Name = "label_Hospitalized";
            this.label_Hospitalized.Size = new System.Drawing.Size(67, 13);
            this.label_Hospitalized.TabIndex = 44;
            this.label_Hospitalized.Text = "Hospitalized:";
            // 
            // label_Cancer
            // 
            this.label_Cancer.AutoSize = true;
            this.label_Cancer.Location = new System.Drawing.Point(271, 390);
            this.label_Cancer.Name = "label_Cancer";
            this.label_Cancer.Size = new System.Drawing.Size(44, 13);
            this.label_Cancer.TabIndex = 43;
            this.label_Cancer.Text = "Cancer:";
            // 
            // label_HeartDisease
            // 
            this.label_HeartDisease.AutoSize = true;
            this.label_HeartDisease.Location = new System.Drawing.Point(238, 367);
            this.label_HeartDisease.Name = "label_HeartDisease";
            this.label_HeartDisease.Size = new System.Drawing.Size(77, 13);
            this.label_HeartDisease.TabIndex = 42;
            this.label_HeartDisease.Text = "Heart Disease:";
            // 
            // label_AverageFatPerDay
            // 
            this.label_AverageFatPerDay.AutoSize = true;
            this.label_AverageFatPerDay.Location = new System.Drawing.Point(174, 344);
            this.label_AverageFatPerDay.Name = "label_AverageFatPerDay";
            this.label_AverageFatPerDay.Size = new System.Drawing.Size(141, 13);
            this.label_AverageFatPerDay.TabIndex = 41;
            this.label_AverageFatPerDay.Text = "Average Grams Fat per Day:";
            // 
            // label_SystolicBloodPressure
            // 
            this.label_SystolicBloodPressure.AutoSize = true;
            this.label_SystolicBloodPressure.Location = new System.Drawing.Point(195, 321);
            this.label_SystolicBloodPressure.Name = "label_SystolicBloodPressure";
            this.label_SystolicBloodPressure.Size = new System.Drawing.Size(120, 13);
            this.label_SystolicBloodPressure.TabIndex = 40;
            this.label_SystolicBloodPressure.Text = "Systolic Blood Pressure:";
            // 
            // label_CigPerDay
            // 
            this.label_CigPerDay.AutoSize = true;
            this.label_CigPerDay.Location = new System.Drawing.Point(245, 298);
            this.label_CigPerDay.Name = "label_CigPerDay";
            this.label_CigPerDay.Size = new System.Drawing.Size(70, 13);
            this.label_CigPerDay.TabIndex = 39;
            this.label_CigPerDay.Text = "Cigs per Day:";
            // 
            // label_SmokingHistory
            // 
            this.label_SmokingHistory.AutoSize = true;
            this.label_SmokingHistory.Location = new System.Drawing.Point(229, 275);
            this.label_SmokingHistory.Name = "label_SmokingHistory";
            this.label_SmokingHistory.Size = new System.Drawing.Size(86, 13);
            this.label_SmokingHistory.TabIndex = 38;
            this.label_SmokingHistory.Text = "Smoking History:";
            // 
            // label_MotherAAD
            // 
            this.label_MotherAAD.AutoSize = true;
            this.label_MotherAAD.Location = new System.Drawing.Point(199, 252);
            this.label_MotherAAD.Name = "label_MotherAAD";
            this.label_MotherAAD.Size = new System.Drawing.Size(116, 13);
            this.label_MotherAAD.TabIndex = 37;
            this.label_MotherAAD.Text = "Mother\'s Age at Death:";
            // 
            // label_FatherAAD
            // 
            this.label_FatherAAD.AutoSize = true;
            this.label_FatherAAD.Location = new System.Drawing.Point(202, 229);
            this.label_FatherAAD.Name = "label_FatherAAD";
            this.label_FatherAAD.Size = new System.Drawing.Size(113, 13);
            this.label_FatherAAD.TabIndex = 36;
            this.label_FatherAAD.Text = "Father\'s Age at Death:";
            // 
            // label_PolicyholderDOB
            // 
            this.label_PolicyholderDOB.AutoSize = true;
            this.label_PolicyholderDOB.Location = new System.Drawing.Point(179, 206);
            this.label_PolicyholderDOB.Name = "label_PolicyholderDOB";
            this.label_PolicyholderDOB.Size = new System.Drawing.Size(136, 13);
            this.label_PolicyholderDOB.TabIndex = 35;
            this.label_PolicyholderDOB.Text = "Policyholder\'s Date of Birth:";
            // 
            // label_AddressZip
            // 
            this.label_AddressZip.AutoSize = true;
            this.label_AddressZip.Location = new System.Drawing.Point(249, 183);
            this.label_AddressZip.Name = "label_AddressZip";
            this.label_AddressZip.Size = new System.Drawing.Size(66, 13);
            this.label_AddressZip.TabIndex = 34;
            this.label_AddressZip.Text = "Address Zip:";
            // 
            // label_AddressState
            // 
            this.label_AddressState.AutoSize = true;
            this.label_AddressState.Location = new System.Drawing.Point(239, 160);
            this.label_AddressState.Name = "label_AddressState";
            this.label_AddressState.Size = new System.Drawing.Size(76, 13);
            this.label_AddressState.TabIndex = 33;
            this.label_AddressState.Text = "Address State:\r\n";
            // 
            // label_AddressCity
            // 
            this.label_AddressCity.AutoSize = true;
            this.label_AddressCity.Location = new System.Drawing.Point(247, 137);
            this.label_AddressCity.Name = "label_AddressCity";
            this.label_AddressCity.Size = new System.Drawing.Size(68, 13);
            this.label_AddressCity.TabIndex = 32;
            this.label_AddressCity.Text = "Address City:";
            // 
            // label_AddressStreet
            // 
            this.label_AddressStreet.AutoSize = true;
            this.label_AddressStreet.Location = new System.Drawing.Point(236, 114);
            this.label_AddressStreet.Name = "label_AddressStreet";
            this.label_AddressStreet.Size = new System.Drawing.Size(79, 13);
            this.label_AddressStreet.TabIndex = 31;
            this.label_AddressStreet.Text = "Address Street:";
            // 
            // label_PolicyholderLastName
            // 
            this.label_PolicyholderLastName.AutoSize = true;
            this.label_PolicyholderLastName.Location = new System.Drawing.Point(194, 90);
            this.label_PolicyholderLastName.Name = "label_PolicyholderLastName";
            this.label_PolicyholderLastName.Size = new System.Drawing.Size(121, 13);
            this.label_PolicyholderLastName.TabIndex = 30;
            this.label_PolicyholderLastName.Text = "Policyholder Last Name:";
            // 
            // label_PolicyholderFirstName
            // 
            this.label_PolicyholderFirstName.AutoSize = true;
            this.label_PolicyholderFirstName.Location = new System.Drawing.Point(195, 67);
            this.label_PolicyholderFirstName.Name = "label_PolicyholderFirstName";
            this.label_PolicyholderFirstName.Size = new System.Drawing.Size(120, 13);
            this.label_PolicyholderFirstName.TabIndex = 29;
            this.label_PolicyholderFirstName.Text = "Policyholder First Name:";
            // 
            // label_PolicyNumber
            // 
            this.label_PolicyNumber.AutoSize = true;
            this.label_PolicyNumber.Location = new System.Drawing.Point(237, 44);
            this.label_PolicyNumber.Name = "label_PolicyNumber";
            this.label_PolicyNumber.Size = new System.Drawing.Size(78, 13);
            this.label_PolicyNumber.TabIndex = 28;
            this.label_PolicyNumber.Text = "Policy Number:";
            // 
            // textBox_ShowPolicyholderFirstName
            // 
            this.textBox_ShowPolicyholderFirstName.Location = new System.Drawing.Point(321, 64);
            this.textBox_ShowPolicyholderFirstName.MaxLength = 100;
            this.textBox_ShowPolicyholderFirstName.Name = "textBox_ShowPolicyholderFirstName";
            this.textBox_ShowPolicyholderFirstName.Size = new System.Drawing.Size(293, 20);
            this.textBox_ShowPolicyholderFirstName.TabIndex = 56;
            // 
            // textBox_ShowPolicyholderLastName
            // 
            this.textBox_ShowPolicyholderLastName.Location = new System.Drawing.Point(321, 87);
            this.textBox_ShowPolicyholderLastName.MaxLength = 100;
            this.textBox_ShowPolicyholderLastName.Name = "textBox_ShowPolicyholderLastName";
            this.textBox_ShowPolicyholderLastName.Size = new System.Drawing.Size(293, 20);
            this.textBox_ShowPolicyholderLastName.TabIndex = 57;
            // 
            // textBox_ShowAddressStreet
            // 
            this.textBox_ShowAddressStreet.Location = new System.Drawing.Point(321, 111);
            this.textBox_ShowAddressStreet.MaxLength = 30;
            this.textBox_ShowAddressStreet.Name = "textBox_ShowAddressStreet";
            this.textBox_ShowAddressStreet.Size = new System.Drawing.Size(293, 20);
            this.textBox_ShowAddressStreet.TabIndex = 58;
            // 
            // textBox_AddressCity
            // 
            this.textBox_AddressCity.Location = new System.Drawing.Point(321, 134);
            this.textBox_AddressCity.MaxLength = 20;
            this.textBox_AddressCity.Name = "textBox_AddressCity";
            this.textBox_AddressCity.Size = new System.Drawing.Size(293, 20);
            this.textBox_AddressCity.TabIndex = 59;
            // 
            // textBox_AddressZip
            // 
            this.textBox_AddressZip.Location = new System.Drawing.Point(321, 180);
            this.textBox_AddressZip.MaxLength = 9;
            this.textBox_AddressZip.Name = "textBox_AddressZip";
            this.textBox_AddressZip.Size = new System.Drawing.Size(293, 20);
            this.textBox_AddressZip.TabIndex = 61;
            // 
            // textBox_BeneficiaryFirstName
            // 
            this.textBox_BeneficiaryFirstName.Location = new System.Drawing.Point(321, 617);
            this.textBox_BeneficiaryFirstName.MaxLength = 100;
            this.textBox_BeneficiaryFirstName.Name = "textBox_BeneficiaryFirstName";
            this.textBox_BeneficiaryFirstName.Size = new System.Drawing.Size(293, 20);
            this.textBox_BeneficiaryFirstName.TabIndex = 62;
            // 
            // textBox_BeneficiaryLastName
            // 
            this.textBox_BeneficiaryLastName.Location = new System.Drawing.Point(321, 640);
            this.textBox_BeneficiaryLastName.MaxLength = 100;
            this.textBox_BeneficiaryLastName.Name = "textBox_BeneficiaryLastName";
            this.textBox_BeneficiaryLastName.Size = new System.Drawing.Size(293, 20);
            this.textBox_BeneficiaryLastName.TabIndex = 63;
            // 
            // comboBox_AddressState
            // 
            this.comboBox_AddressState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AddressState.FormattingEnabled = true;
            this.comboBox_AddressState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboBox_AddressState.Location = new System.Drawing.Point(321, 157);
            this.comboBox_AddressState.Name = "comboBox_AddressState";
            this.comboBox_AddressState.Size = new System.Drawing.Size(293, 21);
            this.comboBox_AddressState.TabIndex = 60;
            // 
            // label_AddPolicy
            // 
            this.label_AddPolicy.AutoSize = true;
            this.label_AddPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddPolicy.Location = new System.Drawing.Point(303, 20);
            this.label_AddPolicy.Name = "label_AddPolicy";
            this.label_AddPolicy.Size = new System.Drawing.Size(67, 13);
            this.label_AddPolicy.TabIndex = 65;
            this.label_AddPolicy.Text = "Add Policy";
            // 
            // label_ShowPolicyNumber
            // 
            this.label_ShowPolicyNumber.AutoSize = true;
            this.label_ShowPolicyNumber.Location = new System.Drawing.Point(323, 44);
            this.label_ShowPolicyNumber.Name = "label_ShowPolicyNumber";
            this.label_ShowPolicyNumber.Size = new System.Drawing.Size(35, 13);
            this.label_ShowPolicyNumber.TabIndex = 66;
            this.label_ShowPolicyNumber.Text = "label1";
            // 
            // label_ShowPolicyholderDOB
            // 
            this.label_ShowPolicyholderDOB.AutoSize = true;
            this.label_ShowPolicyholderDOB.Location = new System.Drawing.Point(323, 206);
            this.label_ShowPolicyholderDOB.Name = "label_ShowPolicyholderDOB";
            this.label_ShowPolicyholderDOB.Size = new System.Drawing.Size(35, 13);
            this.label_ShowPolicyholderDOB.TabIndex = 68;
            this.label_ShowPolicyholderDOB.Text = "label3";
            // 
            // label_ShowFatherAAD
            // 
            this.label_ShowFatherAAD.AutoSize = true;
            this.label_ShowFatherAAD.Location = new System.Drawing.Point(323, 229);
            this.label_ShowFatherAAD.Name = "label_ShowFatherAAD";
            this.label_ShowFatherAAD.Size = new System.Drawing.Size(27, 13);
            this.label_ShowFatherAAD.TabIndex = 69;
            this.label_ShowFatherAAD.Text = "N/A";
            // 
            // label_ShowMotherAAD
            // 
            this.label_ShowMotherAAD.AutoSize = true;
            this.label_ShowMotherAAD.Location = new System.Drawing.Point(323, 252);
            this.label_ShowMotherAAD.Name = "label_ShowMotherAAD";
            this.label_ShowMotherAAD.Size = new System.Drawing.Size(27, 13);
            this.label_ShowMotherAAD.TabIndex = 70;
            this.label_ShowMotherAAD.Text = "N/A";
            // 
            // label_ShowSmokingHistory
            // 
            this.label_ShowSmokingHistory.AutoSize = true;
            this.label_ShowSmokingHistory.Location = new System.Drawing.Point(323, 275);
            this.label_ShowSmokingHistory.Name = "label_ShowSmokingHistory";
            this.label_ShowSmokingHistory.Size = new System.Drawing.Size(35, 13);
            this.label_ShowSmokingHistory.TabIndex = 71;
            this.label_ShowSmokingHistory.Text = "label6";
            // 
            // label_ShowCigPerDay
            // 
            this.label_ShowCigPerDay.AutoSize = true;
            this.label_ShowCigPerDay.Location = new System.Drawing.Point(323, 298);
            this.label_ShowCigPerDay.Name = "label_ShowCigPerDay";
            this.label_ShowCigPerDay.Size = new System.Drawing.Size(35, 13);
            this.label_ShowCigPerDay.TabIndex = 72;
            this.label_ShowCigPerDay.Text = "label7";
            // 
            // label_ShowSystolicBloodPressure
            // 
            this.label_ShowSystolicBloodPressure.AutoSize = true;
            this.label_ShowSystolicBloodPressure.Location = new System.Drawing.Point(323, 321);
            this.label_ShowSystolicBloodPressure.Name = "label_ShowSystolicBloodPressure";
            this.label_ShowSystolicBloodPressure.Size = new System.Drawing.Size(35, 13);
            this.label_ShowSystolicBloodPressure.TabIndex = 73;
            this.label_ShowSystolicBloodPressure.Text = "label8";
            // 
            // label_ShowAverageFatPerDay
            // 
            this.label_ShowAverageFatPerDay.AutoSize = true;
            this.label_ShowAverageFatPerDay.Location = new System.Drawing.Point(323, 344);
            this.label_ShowAverageFatPerDay.Name = "label_ShowAverageFatPerDay";
            this.label_ShowAverageFatPerDay.Size = new System.Drawing.Size(35, 13);
            this.label_ShowAverageFatPerDay.TabIndex = 74;
            this.label_ShowAverageFatPerDay.Text = "label9";
            // 
            // label_ShowHeartDisease
            // 
            this.label_ShowHeartDisease.AutoSize = true;
            this.label_ShowHeartDisease.Location = new System.Drawing.Point(323, 367);
            this.label_ShowHeartDisease.Name = "label_ShowHeartDisease";
            this.label_ShowHeartDisease.Size = new System.Drawing.Size(41, 13);
            this.label_ShowHeartDisease.TabIndex = 75;
            this.label_ShowHeartDisease.Text = "label10";
            // 
            // label_ShowCancer
            // 
            this.label_ShowCancer.AutoSize = true;
            this.label_ShowCancer.Location = new System.Drawing.Point(323, 390);
            this.label_ShowCancer.Name = "label_ShowCancer";
            this.label_ShowCancer.Size = new System.Drawing.Size(41, 13);
            this.label_ShowCancer.TabIndex = 76;
            this.label_ShowCancer.Text = "label11";
            // 
            // label_ShowHospitalized
            // 
            this.label_ShowHospitalized.AutoSize = true;
            this.label_ShowHospitalized.Location = new System.Drawing.Point(323, 413);
            this.label_ShowHospitalized.Name = "label_ShowHospitalized";
            this.label_ShowHospitalized.Size = new System.Drawing.Size(41, 13);
            this.label_ShowHospitalized.TabIndex = 77;
            this.label_ShowHospitalized.Text = "label29";
            // 
            // label_ShowDangerousActivities
            // 
            this.label_ShowDangerousActivities.AutoSize = true;
            this.label_ShowDangerousActivities.Location = new System.Drawing.Point(323, 436);
            this.label_ShowDangerousActivities.Name = "label_ShowDangerousActivities";
            this.label_ShowDangerousActivities.Size = new System.Drawing.Size(27, 13);
            this.label_ShowDangerousActivities.TabIndex = 78;
            this.label_ShowDangerousActivities.Text = "N/A";
            // 
            // label_ShowPolicyStartDate
            // 
            this.label_ShowPolicyStartDate.AutoSize = true;
            this.label_ShowPolicyStartDate.Location = new System.Drawing.Point(323, 459);
            this.label_ShowPolicyStartDate.Name = "label_ShowPolicyStartDate";
            this.label_ShowPolicyStartDate.Size = new System.Drawing.Size(41, 13);
            this.label_ShowPolicyStartDate.TabIndex = 80;
            this.label_ShowPolicyStartDate.Text = "label32";
            // 
            // label_ShowPolicyEndDate
            // 
            this.label_ShowPolicyEndDate.AutoSize = true;
            this.label_ShowPolicyEndDate.Location = new System.Drawing.Point(323, 482);
            this.label_ShowPolicyEndDate.Name = "label_ShowPolicyEndDate";
            this.label_ShowPolicyEndDate.Size = new System.Drawing.Size(27, 13);
            this.label_ShowPolicyEndDate.TabIndex = 81;
            this.label_ShowPolicyEndDate.Text = "N/A";
            // 
            // label_ShowAgentNumber
            // 
            this.label_ShowAgentNumber.AutoSize = true;
            this.label_ShowAgentNumber.Location = new System.Drawing.Point(323, 505);
            this.label_ShowAgentNumber.Name = "label_ShowAgentNumber";
            this.label_ShowAgentNumber.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAgentNumber.TabIndex = 82;
            this.label_ShowAgentNumber.Text = "label34";
            // 
            // label_ShowAgentFirstName
            // 
            this.label_ShowAgentFirstName.AutoSize = true;
            this.label_ShowAgentFirstName.Location = new System.Drawing.Point(323, 528);
            this.label_ShowAgentFirstName.Name = "label_ShowAgentFirstName";
            this.label_ShowAgentFirstName.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAgentFirstName.TabIndex = 83;
            this.label_ShowAgentFirstName.Text = "label35";
            // 
            // label_ShowAgentLastName
            // 
            this.label_ShowAgentLastName.AutoSize = true;
            this.label_ShowAgentLastName.Location = new System.Drawing.Point(323, 551);
            this.label_ShowAgentLastName.Name = "label_ShowAgentLastName";
            this.label_ShowAgentLastName.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAgentLastName.TabIndex = 84;
            this.label_ShowAgentLastName.Text = "label36";
            // 
            // label_ShowPayoffAmount
            // 
            this.label_ShowPayoffAmount.AutoSize = true;
            this.label_ShowPayoffAmount.Location = new System.Drawing.Point(323, 574);
            this.label_ShowPayoffAmount.Name = "label_ShowPayoffAmount";
            this.label_ShowPayoffAmount.Size = new System.Drawing.Size(41, 13);
            this.label_ShowPayoffAmount.TabIndex = 85;
            this.label_ShowPayoffAmount.Text = "label37";
            // 
            // label_ShowMonthlyPremium
            // 
            this.label_ShowMonthlyPremium.AutoSize = true;
            this.label_ShowMonthlyPremium.Location = new System.Drawing.Point(323, 597);
            this.label_ShowMonthlyPremium.Name = "label_ShowMonthlyPremium";
            this.label_ShowMonthlyPremium.Size = new System.Drawing.Size(41, 13);
            this.label_ShowMonthlyPremium.TabIndex = 86;
            this.label_ShowMonthlyPremium.Text = "label38";
            // 
            // button_Submit
            // 
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Submit.Location = new System.Drawing.Point(252, 679);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 87;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.Location = new System.Drawing.Point(447, 679);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 88;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // AddPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 745);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label_ShowMonthlyPremium);
            this.Controls.Add(this.label_ShowPayoffAmount);
            this.Controls.Add(this.label_ShowAgentLastName);
            this.Controls.Add(this.label_ShowAgentFirstName);
            this.Controls.Add(this.label_ShowAgentNumber);
            this.Controls.Add(this.label_ShowPolicyEndDate);
            this.Controls.Add(this.label_ShowPolicyStartDate);
            this.Controls.Add(this.label_ShowDangerousActivities);
            this.Controls.Add(this.label_ShowHospitalized);
            this.Controls.Add(this.label_ShowCancer);
            this.Controls.Add(this.label_ShowHeartDisease);
            this.Controls.Add(this.label_ShowAverageFatPerDay);
            this.Controls.Add(this.label_ShowSystolicBloodPressure);
            this.Controls.Add(this.label_ShowCigPerDay);
            this.Controls.Add(this.label_ShowSmokingHistory);
            this.Controls.Add(this.label_ShowMotherAAD);
            this.Controls.Add(this.label_ShowFatherAAD);
            this.Controls.Add(this.label_ShowPolicyholderDOB);
            this.Controls.Add(this.label_ShowPolicyNumber);
            this.Controls.Add(this.label_AddPolicy);
            this.Controls.Add(this.comboBox_AddressState);
            this.Controls.Add(this.textBox_BeneficiaryLastName);
            this.Controls.Add(this.textBox_BeneficiaryFirstName);
            this.Controls.Add(this.textBox_AddressZip);
            this.Controls.Add(this.textBox_AddressCity);
            this.Controls.Add(this.textBox_ShowAddressStreet);
            this.Controls.Add(this.textBox_ShowPolicyholderLastName);
            this.Controls.Add(this.textBox_ShowPolicyholderFirstName);
            this.Controls.Add(this.label_BeneficiaryLastName);
            this.Controls.Add(this.label_BeneficiaryFirstName);
            this.Controls.Add(this.label_MonthlyPremium);
            this.Controls.Add(this.label_PayoffAmount);
            this.Controls.Add(this.label_AgentLastName);
            this.Controls.Add(this.label_AgentFirstName);
            this.Controls.Add(this.label_AgentNumber);
            this.Controls.Add(this.label_PolicyEndDate);
            this.Controls.Add(this.label_PolicyStartDate);
            this.Controls.Add(this.label_DangerousActivities);
            this.Controls.Add(this.label_Hospitalized);
            this.Controls.Add(this.label_Cancer);
            this.Controls.Add(this.label_HeartDisease);
            this.Controls.Add(this.label_AverageFatPerDay);
            this.Controls.Add(this.label_SystolicBloodPressure);
            this.Controls.Add(this.label_CigPerDay);
            this.Controls.Add(this.label_SmokingHistory);
            this.Controls.Add(this.label_MotherAAD);
            this.Controls.Add(this.label_FatherAAD);
            this.Controls.Add(this.label_PolicyholderDOB);
            this.Controls.Add(this.label_AddressZip);
            this.Controls.Add(this.label_AddressState);
            this.Controls.Add(this.label_AddressCity);
            this.Controls.Add(this.label_AddressStreet);
            this.Controls.Add(this.label_PolicyholderLastName);
            this.Controls.Add(this.label_PolicyholderFirstName);
            this.Controls.Add(this.label_PolicyNumber);
            this.Name = "AddPolicy";
            this.Text = "Add Policy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_BeneficiaryLastName;
        private Label label_BeneficiaryFirstName;
        private Label label_MonthlyPremium;
        private Label label_PayoffAmount;
        private Label label_AgentLastName;
        private Label label_AgentFirstName;
        private Label label_AgentNumber;
        private Label label_PolicyEndDate;
        private Label label_PolicyStartDate;
        private Label label_DangerousActivities;
        private Label label_Hospitalized;
        private Label label_Cancer;
        private Label label_HeartDisease;
        private Label label_AverageFatPerDay;
        private Label label_SystolicBloodPressure;
        private Label label_CigPerDay;
        private Label label_SmokingHistory;
        private Label label_MotherAAD;
        private Label label_FatherAAD;
        private Label label_PolicyholderDOB;
        private Label label_AddressZip;
        private Label label_AddressState;
        private Label label_AddressCity;
        private Label label_AddressStreet;
        private Label label_PolicyholderLastName;
        private Label label_PolicyholderFirstName;
        private Label label_PolicyNumber;
        private TextBox textBox_ShowPolicyholderFirstName;
        private TextBox textBox_ShowPolicyholderLastName;
        private TextBox textBox_ShowAddressStreet;
        private TextBox textBox_AddressCity;
        private TextBox textBox_AddressZip;
        private TextBox textBox_BeneficiaryFirstName;
        private TextBox textBox_BeneficiaryLastName;
        private ComboBox comboBox_AddressState;
        private Label label_AddPolicy;
        private Label label_ShowPolicyNumber;
        private Label label_ShowPolicyholderDOB;
        private Label label_ShowFatherAAD;
        private Label label_ShowMotherAAD;
        private Label label_ShowSmokingHistory;
        private Label label_ShowCigPerDay;
        private Label label_ShowSystolicBloodPressure;
        private Label label_ShowAverageFatPerDay;
        private Label label_ShowHeartDisease;
        private Label label_ShowCancer;
        private Label label_ShowHospitalized;
        private Label label_ShowDangerousActivities;
        private Label label_ShowPolicyStartDate;
        private Label label_ShowPolicyEndDate;
        private Label label_ShowAgentNumber;
        private Label label_ShowAgentFirstName;
        private Label label_ShowAgentLastName;
        private Label label_ShowPayoffAmount;
        private Label label_ShowMonthlyPremium;
        private Button button_Submit;
        private Button button_Cancel;
        private Agent usingAgent;
        private Policy inPolicy;
        private PricePolicy previousPage;
    }
}