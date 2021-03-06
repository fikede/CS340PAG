﻿using System;
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
    partial class PolicyPage
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
            this.label_PolicyNumber = new System.Windows.Forms.Label();
            this.label_PolicyholderFirstName = new System.Windows.Forms.Label();
            this.label_PolicyholderLastName = new System.Windows.Forms.Label();
            this.label_AddressStreet = new System.Windows.Forms.Label();
            this.label_AddressCity = new System.Windows.Forms.Label();
            this.label_AddressState = new System.Windows.Forms.Label();
            this.label_AddressZip = new System.Windows.Forms.Label();
            this.label_PolicyholderDOB = new System.Windows.Forms.Label();
            this.label_FatherAAD = new System.Windows.Forms.Label();
            this.label_MotherAAD = new System.Windows.Forms.Label();
            this.label_SmokingHistory = new System.Windows.Forms.Label();
            this.label_CigPerDay = new System.Windows.Forms.Label();
            this.label_SystolicBloodPressure = new System.Windows.Forms.Label();
            this.label_AverageFatPerDay = new System.Windows.Forms.Label();
            this.label_HeartDisease = new System.Windows.Forms.Label();
            this.label_Cancer = new System.Windows.Forms.Label();
            this.label_Hospitalized = new System.Windows.Forms.Label();
            this.label_DangerousActivity = new System.Windows.Forms.Label();
            this.label_PolicyStartDate = new System.Windows.Forms.Label();
            this.label_PolicyEndDate = new System.Windows.Forms.Label();
            this.label_AgentNumber = new System.Windows.Forms.Label();
            this.label_AgentFirstName = new System.Windows.Forms.Label();
            this.label_AgentLastName = new System.Windows.Forms.Label();
            this.label_PayoffAmount = new System.Windows.Forms.Label();
            this.label_MonthlyPremium = new System.Windows.Forms.Label();
            this.label_BenficiaryFirstName = new System.Windows.Forms.Label();
            this.linkLabel_CancelPolicy = new System.Windows.Forms.LinkLabel();
            this.linkLabel_UpdatePolicy = new System.Windows.Forms.LinkLabel();
            this.linkLabel_MakeClaim = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ViewPaymentHistory = new System.Windows.Forms.LinkLabel();
            this.label_ShowPolicyNumber = new System.Windows.Forms.Label();
            this.label_ShowPolicyholderFirstName = new System.Windows.Forms.Label();
            this.label_ShowPolicyholderLastName = new System.Windows.Forms.Label();
            this.label_ShowAddressStreet = new System.Windows.Forms.Label();
            this.label_ShowAddressCity = new System.Windows.Forms.Label();
            this.label_ShowAddressState = new System.Windows.Forms.Label();
            this.label_ShowAddressZip = new System.Windows.Forms.Label();
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
            this.label_ShowDangerousActivity = new System.Windows.Forms.Label();
            this.label_ShowPolicyStartDate = new System.Windows.Forms.Label();
            this.label_ShowPolicyEndDate = new System.Windows.Forms.Label();
            this.label_ShowAgentNumber = new System.Windows.Forms.Label();
            this.label_ShowAgentFirstName = new System.Windows.Forms.Label();
            this.label_ShowAgentLastName = new System.Windows.Forms.Label();
            this.label_ShowPayoffAmount = new System.Windows.Forms.Label();
            this.label_ShowMonthlyPremium = new System.Windows.Forms.Label();
            this.linkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.listBox_BeneficiaryName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_PolicyNumber
            // 
            this.label_PolicyNumber.AutoSize = true;
            this.label_PolicyNumber.Location = new System.Drawing.Point(227, 39);
            this.label_PolicyNumber.Name = "label_PolicyNumber";
            this.label_PolicyNumber.Size = new System.Drawing.Size(78, 13);
            this.label_PolicyNumber.TabIndex = 0;
            this.label_PolicyNumber.Text = "Policy Number:";
            // 
            // label_PolicyholderFirstName
            // 
            this.label_PolicyholderFirstName.AutoSize = true;
            this.label_PolicyholderFirstName.Location = new System.Drawing.Point(185, 63);
            this.label_PolicyholderFirstName.Name = "label_PolicyholderFirstName";
            this.label_PolicyholderFirstName.Size = new System.Drawing.Size(120, 13);
            this.label_PolicyholderFirstName.TabIndex = 1;
            this.label_PolicyholderFirstName.Text = "Policyholder First Name:";
            // 
            // label_PolicyholderLastName
            // 
            this.label_PolicyholderLastName.Location = new System.Drawing.Point(184, 87);
            this.label_PolicyholderLastName.Name = "label_PolicyholderLastName";
            this.label_PolicyholderLastName.Size = new System.Drawing.Size(121, 13);
            this.label_PolicyholderLastName.TabIndex = 2;
            this.label_PolicyholderLastName.Text = "Policyholder Last Name:";
            // 
            // label_AddressStreet
            // 
            this.label_AddressStreet.AutoSize = true;
            this.label_AddressStreet.Location = new System.Drawing.Point(226, 111);
            this.label_AddressStreet.Name = "label_AddressStreet";
            this.label_AddressStreet.Size = new System.Drawing.Size(79, 13);
            this.label_AddressStreet.TabIndex = 3;
            this.label_AddressStreet.Text = "Address Street:";
            // 
            // label_AddressCity
            // 
            this.label_AddressCity.AutoSize = true;
            this.label_AddressCity.Location = new System.Drawing.Point(237, 135);
            this.label_AddressCity.Name = "label_AddressCity";
            this.label_AddressCity.Size = new System.Drawing.Size(68, 13);
            this.label_AddressCity.TabIndex = 4;
            this.label_AddressCity.Text = "Address City:";
            // 
            // label_AddressState
            // 
            this.label_AddressState.AutoSize = true;
            this.label_AddressState.Location = new System.Drawing.Point(229, 159);
            this.label_AddressState.Name = "label_AddressState";
            this.label_AddressState.Size = new System.Drawing.Size(76, 13);
            this.label_AddressState.TabIndex = 5;
            this.label_AddressState.Text = "Address State:\r\n";
            // 
            // label_AddressZip
            // 
            this.label_AddressZip.AutoSize = true;
            this.label_AddressZip.Location = new System.Drawing.Point(239, 183);
            this.label_AddressZip.Name = "label_AddressZip";
            this.label_AddressZip.Size = new System.Drawing.Size(66, 13);
            this.label_AddressZip.TabIndex = 6;
            this.label_AddressZip.Text = "Address Zip:";
            // 
            // label_PolicyholderDOB
            // 
            this.label_PolicyholderDOB.AutoSize = true;
            this.label_PolicyholderDOB.Location = new System.Drawing.Point(169, 207);
            this.label_PolicyholderDOB.Name = "label_PolicyholderDOB";
            this.label_PolicyholderDOB.Size = new System.Drawing.Size(136, 13);
            this.label_PolicyholderDOB.TabIndex = 7;
            this.label_PolicyholderDOB.Text = "Policyholder\'s Date of Birth:";
            // 
            // label_FatherAAD
            // 
            this.label_FatherAAD.AutoSize = true;
            this.label_FatherAAD.Location = new System.Drawing.Point(192, 231);
            this.label_FatherAAD.Name = "label_FatherAAD";
            this.label_FatherAAD.Size = new System.Drawing.Size(113, 13);
            this.label_FatherAAD.TabIndex = 8;
            this.label_FatherAAD.Text = "Father\'s Age at Death:";
            // 
            // label_MotherAAD
            // 
            this.label_MotherAAD.AutoSize = true;
            this.label_MotherAAD.Location = new System.Drawing.Point(189, 255);
            this.label_MotherAAD.Name = "label_MotherAAD";
            this.label_MotherAAD.Size = new System.Drawing.Size(116, 13);
            this.label_MotherAAD.TabIndex = 9;
            this.label_MotherAAD.Text = "Mother\'s Age at Death:";
            // 
            // label_SmokingHistory
            // 
            this.label_SmokingHistory.AutoSize = true;
            this.label_SmokingHistory.Location = new System.Drawing.Point(219, 279);
            this.label_SmokingHistory.Name = "label_SmokingHistory";
            this.label_SmokingHistory.Size = new System.Drawing.Size(86, 13);
            this.label_SmokingHistory.TabIndex = 10;
            this.label_SmokingHistory.Text = "Smoking History:";
            // 
            // label_CigPerDay
            // 
            this.label_CigPerDay.AutoSize = true;
            this.label_CigPerDay.Location = new System.Drawing.Point(235, 303);
            this.label_CigPerDay.Name = "label_CigPerDay";
            this.label_CigPerDay.Size = new System.Drawing.Size(70, 13);
            this.label_CigPerDay.TabIndex = 11;
            this.label_CigPerDay.Text = "Cigs per Day:";
            // 
            // label_SystolicBloodPressure
            // 
            this.label_SystolicBloodPressure.AutoSize = true;
            this.label_SystolicBloodPressure.Location = new System.Drawing.Point(185, 327);
            this.label_SystolicBloodPressure.Name = "label_SystolicBloodPressure";
            this.label_SystolicBloodPressure.Size = new System.Drawing.Size(120, 13);
            this.label_SystolicBloodPressure.TabIndex = 12;
            this.label_SystolicBloodPressure.Text = "Systolic Blood Pressure:";
            // 
            // label_AverageFatPerDay
            // 
            this.label_AverageFatPerDay.AutoSize = true;
            this.label_AverageFatPerDay.Location = new System.Drawing.Point(164, 351);
            this.label_AverageFatPerDay.Name = "label_AverageFatPerDay";
            this.label_AverageFatPerDay.Size = new System.Drawing.Size(141, 13);
            this.label_AverageFatPerDay.TabIndex = 13;
            this.label_AverageFatPerDay.Text = "Average Grams Fat per Day:";
            // 
            // label_HeartDisease
            // 
            this.label_HeartDisease.AutoSize = true;
            this.label_HeartDisease.Location = new System.Drawing.Point(228, 375);
            this.label_HeartDisease.Name = "label_HeartDisease";
            this.label_HeartDisease.Size = new System.Drawing.Size(77, 13);
            this.label_HeartDisease.TabIndex = 14;
            this.label_HeartDisease.Text = "Heart Disease:";
            // 
            // label_Cancer
            // 
            this.label_Cancer.AutoSize = true;
            this.label_Cancer.Location = new System.Drawing.Point(261, 399);
            this.label_Cancer.Name = "label_Cancer";
            this.label_Cancer.Size = new System.Drawing.Size(44, 13);
            this.label_Cancer.TabIndex = 15;
            this.label_Cancer.Text = "Cancer:";
            // 
            // label_Hospitalized
            // 
            this.label_Hospitalized.AutoSize = true;
            this.label_Hospitalized.Location = new System.Drawing.Point(238, 423);
            this.label_Hospitalized.Name = "label_Hospitalized";
            this.label_Hospitalized.Size = new System.Drawing.Size(67, 13);
            this.label_Hospitalized.TabIndex = 16;
            this.label_Hospitalized.Text = "Hospitalized:";
            // 
            // label_DangerousActivity
            // 
            this.label_DangerousActivity.AutoSize = true;
            this.label_DangerousActivity.Location = new System.Drawing.Point(198, 447);
            this.label_DangerousActivity.Name = "label_DangerousActivity";
            this.label_DangerousActivity.Size = new System.Drawing.Size(107, 13);
            this.label_DangerousActivity.TabIndex = 17;
            this.label_DangerousActivity.Text = "Dangerous Activities:";
            // 
            // label_PolicyStartDate
            // 
            this.label_PolicyStartDate.AutoSize = true;
            this.label_PolicyStartDate.Location = new System.Drawing.Point(216, 470);
            this.label_PolicyStartDate.Name = "label_PolicyStartDate";
            this.label_PolicyStartDate.Size = new System.Drawing.Size(89, 13);
            this.label_PolicyStartDate.TabIndex = 19;
            this.label_PolicyStartDate.Text = "Policy Start Date:";
            // 
            // label_PolicyEndDate
            // 
            this.label_PolicyEndDate.AutoSize = true;
            this.label_PolicyEndDate.Location = new System.Drawing.Point(219, 494);
            this.label_PolicyEndDate.Name = "label_PolicyEndDate";
            this.label_PolicyEndDate.Size = new System.Drawing.Size(86, 13);
            this.label_PolicyEndDate.TabIndex = 20;
            this.label_PolicyEndDate.Text = "Policy End Date:";
            // 
            // label_AgentNumber
            // 
            this.label_AgentNumber.AutoSize = true;
            this.label_AgentNumber.Location = new System.Drawing.Point(227, 518);
            this.label_AgentNumber.Name = "label_AgentNumber";
            this.label_AgentNumber.Size = new System.Drawing.Size(78, 13);
            this.label_AgentNumber.TabIndex = 21;
            this.label_AgentNumber.Text = "Agent Number:";
            // 
            // label_AgentFirstName
            // 
            this.label_AgentFirstName.AutoSize = true;
            this.label_AgentFirstName.Location = new System.Drawing.Point(214, 542);
            this.label_AgentFirstName.Name = "label_AgentFirstName";
            this.label_AgentFirstName.Size = new System.Drawing.Size(91, 13);
            this.label_AgentFirstName.TabIndex = 22;
            this.label_AgentFirstName.Text = "Agent First Name:";
            // 
            // label_AgentLastName
            // 
            this.label_AgentLastName.AutoSize = true;
            this.label_AgentLastName.Location = new System.Drawing.Point(213, 566);
            this.label_AgentLastName.Name = "label_AgentLastName";
            this.label_AgentLastName.Size = new System.Drawing.Size(92, 13);
            this.label_AgentLastName.TabIndex = 23;
            this.label_AgentLastName.Text = "Agent Last Name:";
            // 
            // label_PayoffAmount
            // 
            this.label_PayoffAmount.AutoSize = true;
            this.label_PayoffAmount.Location = new System.Drawing.Point(226, 590);
            this.label_PayoffAmount.Name = "label_PayoffAmount";
            this.label_PayoffAmount.Size = new System.Drawing.Size(79, 13);
            this.label_PayoffAmount.TabIndex = 24;
            this.label_PayoffAmount.Text = "Payoff Amount:";
            // 
            // label_MonthlyPremium
            // 
            this.label_MonthlyPremium.AutoSize = true;
            this.label_MonthlyPremium.Location = new System.Drawing.Point(215, 614);
            this.label_MonthlyPremium.Name = "label_MonthlyPremium";
            this.label_MonthlyPremium.Size = new System.Drawing.Size(90, 13);
            this.label_MonthlyPremium.TabIndex = 25;
            this.label_MonthlyPremium.Text = "Monthly Premium:";
            // 
            // label_BenficiaryFirstName
            // 
            this.label_BenficiaryFirstName.AutoSize = true;
            this.label_BenficiaryFirstName.Location = new System.Drawing.Point(212, 638);
            this.label_BenficiaryFirstName.Name = "label_BenficiaryFirstName";
            this.label_BenficiaryFirstName.Size = new System.Drawing.Size(93, 13);
            this.label_BenficiaryFirstName.TabIndex = 26;
            this.label_BenficiaryFirstName.Text = "Beneficiary Name:";
            // 
            // linkLabel_CancelPolicy
            // 
            this.linkLabel_CancelPolicy.AutoSize = true;
            this.linkLabel_CancelPolicy.Location = new System.Drawing.Point(102, 748);
            this.linkLabel_CancelPolicy.Name = "linkLabel_CancelPolicy";
            this.linkLabel_CancelPolicy.Size = new System.Drawing.Size(71, 13);
            this.linkLabel_CancelPolicy.TabIndex = 3;
            this.linkLabel_CancelPolicy.TabStop = true;
            this.linkLabel_CancelPolicy.Text = "Cancel Policy";
            this.linkLabel_CancelPolicy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_CancelPolicy_LinkClicked);
            // 
            // linkLabel_UpdatePolicy
            // 
            this.linkLabel_UpdatePolicy.AutoSize = true;
            this.linkLabel_UpdatePolicy.Location = new System.Drawing.Point(260, 748);
            this.linkLabel_UpdatePolicy.Name = "linkLabel_UpdatePolicy";
            this.linkLabel_UpdatePolicy.Size = new System.Drawing.Size(73, 13);
            this.linkLabel_UpdatePolicy.TabIndex = 4;
            this.linkLabel_UpdatePolicy.TabStop = true;
            this.linkLabel_UpdatePolicy.Text = "Update Policy";
            this.linkLabel_UpdatePolicy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_UpdatePolicy_LinkClicked);
            // 
            // linkLabel_MakeClaim
            // 
            this.linkLabel_MakeClaim.AutoSize = true;
            this.linkLabel_MakeClaim.Location = new System.Drawing.Point(413, 748);
            this.linkLabel_MakeClaim.Name = "linkLabel_MakeClaim";
            this.linkLabel_MakeClaim.Size = new System.Drawing.Size(71, 13);
            this.linkLabel_MakeClaim.TabIndex = 5;
            this.linkLabel_MakeClaim.TabStop = true;
            this.linkLabel_MakeClaim.Text = "Make a Claim";
            this.linkLabel_MakeClaim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_MakeClaim_LinkClicked);
            // 
            // linkLabel_ViewPaymentHistory
            // 
            this.linkLabel_ViewPaymentHistory.AutoSize = true;
            this.linkLabel_ViewPaymentHistory.Location = new System.Drawing.Point(560, 748);
            this.linkLabel_ViewPaymentHistory.Name = "linkLabel_ViewPaymentHistory";
            this.linkLabel_ViewPaymentHistory.Size = new System.Drawing.Size(109, 13);
            this.linkLabel_ViewPaymentHistory.TabIndex = 6;
            this.linkLabel_ViewPaymentHistory.TabStop = true;
            this.linkLabel_ViewPaymentHistory.Text = "View Payment History";
            this.linkLabel_ViewPaymentHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ViewPaymentHistory_LinkClicked);
            // 
            // label_ShowPolicyNumber
            // 
            this.label_ShowPolicyNumber.AutoSize = true;
            this.label_ShowPolicyNumber.Location = new System.Drawing.Point(311, 39);
            this.label_ShowPolicyNumber.Name = "label_ShowPolicyNumber";
            this.label_ShowPolicyNumber.Size = new System.Drawing.Size(41, 13);
            this.label_ShowPolicyNumber.TabIndex = 32;
            this.label_ShowPolicyNumber.Text = "label29";
            // 
            // label_ShowPolicyholderFirstName
            // 
            this.label_ShowPolicyholderFirstName.AutoSize = true;
            this.label_ShowPolicyholderFirstName.Location = new System.Drawing.Point(311, 63);
            this.label_ShowPolicyholderFirstName.Name = "label_ShowPolicyholderFirstName";
            this.label_ShowPolicyholderFirstName.Size = new System.Drawing.Size(41, 13);
            this.label_ShowPolicyholderFirstName.TabIndex = 33;
            this.label_ShowPolicyholderFirstName.Text = "label30";
            // 
            // label_ShowPolicyholderLastName
            // 
            this.label_ShowPolicyholderLastName.AutoSize = true;
            this.label_ShowPolicyholderLastName.Location = new System.Drawing.Point(311, 87);
            this.label_ShowPolicyholderLastName.Name = "label_ShowPolicyholderLastName";
            this.label_ShowPolicyholderLastName.Size = new System.Drawing.Size(41, 13);
            this.label_ShowPolicyholderLastName.TabIndex = 34;
            this.label_ShowPolicyholderLastName.Text = "label31";
            // 
            // label_ShowAddressStreet
            // 
            this.label_ShowAddressStreet.AutoSize = true;
            this.label_ShowAddressStreet.Location = new System.Drawing.Point(311, 111);
            this.label_ShowAddressStreet.Name = "label_ShowAddressStreet";
            this.label_ShowAddressStreet.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAddressStreet.TabIndex = 35;
            this.label_ShowAddressStreet.Text = "label32";
            // 
            // label_ShowAddressCity
            // 
            this.label_ShowAddressCity.AutoSize = true;
            this.label_ShowAddressCity.Location = new System.Drawing.Point(311, 135);
            this.label_ShowAddressCity.Name = "label_ShowAddressCity";
            this.label_ShowAddressCity.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAddressCity.TabIndex = 36;
            this.label_ShowAddressCity.Text = "label33";
            // 
            // label_ShowAddressState
            // 
            this.label_ShowAddressState.AutoSize = true;
            this.label_ShowAddressState.Location = new System.Drawing.Point(311, 159);
            this.label_ShowAddressState.Name = "label_ShowAddressState";
            this.label_ShowAddressState.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAddressState.TabIndex = 37;
            this.label_ShowAddressState.Text = "label34";
            // 
            // label_ShowAddressZip
            // 
            this.label_ShowAddressZip.AutoSize = true;
            this.label_ShowAddressZip.Location = new System.Drawing.Point(311, 183);
            this.label_ShowAddressZip.Name = "label_ShowAddressZip";
            this.label_ShowAddressZip.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAddressZip.TabIndex = 38;
            this.label_ShowAddressZip.Text = "label35";
            // 
            // label_ShowPolicyholderDOB
            // 
            this.label_ShowPolicyholderDOB.AutoSize = true;
            this.label_ShowPolicyholderDOB.Location = new System.Drawing.Point(311, 207);
            this.label_ShowPolicyholderDOB.Name = "label_ShowPolicyholderDOB";
            this.label_ShowPolicyholderDOB.Size = new System.Drawing.Size(41, 13);
            this.label_ShowPolicyholderDOB.TabIndex = 39;
            this.label_ShowPolicyholderDOB.Text = "label36";
            // 
            // label_ShowFatherAAD
            // 
            this.label_ShowFatherAAD.AutoSize = true;
            this.label_ShowFatherAAD.Location = new System.Drawing.Point(311, 231);
            this.label_ShowFatherAAD.Name = "label_ShowFatherAAD";
            this.label_ShowFatherAAD.Size = new System.Drawing.Size(27, 13);
            this.label_ShowFatherAAD.TabIndex = 40;
            this.label_ShowFatherAAD.Text = "N/A";
            // 
            // label_ShowMotherAAD
            // 
            this.label_ShowMotherAAD.AutoSize = true;
            this.label_ShowMotherAAD.Location = new System.Drawing.Point(311, 255);
            this.label_ShowMotherAAD.Name = "label_ShowMotherAAD";
            this.label_ShowMotherAAD.Size = new System.Drawing.Size(27, 13);
            this.label_ShowMotherAAD.TabIndex = 41;
            this.label_ShowMotherAAD.Text = "N/A";
            // 
            // label_ShowSmokingHistory
            // 
            this.label_ShowSmokingHistory.AutoSize = true;
            this.label_ShowSmokingHistory.Location = new System.Drawing.Point(311, 279);
            this.label_ShowSmokingHistory.Name = "label_ShowSmokingHistory";
            this.label_ShowSmokingHistory.Size = new System.Drawing.Size(41, 13);
            this.label_ShowSmokingHistory.TabIndex = 42;
            this.label_ShowSmokingHistory.Text = "label39";
            // 
            // label_ShowCigPerDay
            // 
            this.label_ShowCigPerDay.AutoSize = true;
            this.label_ShowCigPerDay.Location = new System.Drawing.Point(311, 303);
            this.label_ShowCigPerDay.Name = "label_ShowCigPerDay";
            this.label_ShowCigPerDay.Size = new System.Drawing.Size(41, 13);
            this.label_ShowCigPerDay.TabIndex = 43;
            this.label_ShowCigPerDay.Text = "label40";
            // 
            // label_ShowSystolicBloodPressure
            // 
            this.label_ShowSystolicBloodPressure.AutoSize = true;
            this.label_ShowSystolicBloodPressure.Location = new System.Drawing.Point(311, 327);
            this.label_ShowSystolicBloodPressure.Name = "label_ShowSystolicBloodPressure";
            this.label_ShowSystolicBloodPressure.Size = new System.Drawing.Size(41, 13);
            this.label_ShowSystolicBloodPressure.TabIndex = 44;
            this.label_ShowSystolicBloodPressure.Text = "label41";
            // 
            // label_ShowAverageFatPerDay
            // 
            this.label_ShowAverageFatPerDay.AutoSize = true;
            this.label_ShowAverageFatPerDay.Location = new System.Drawing.Point(311, 351);
            this.label_ShowAverageFatPerDay.Name = "label_ShowAverageFatPerDay";
            this.label_ShowAverageFatPerDay.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAverageFatPerDay.TabIndex = 45;
            this.label_ShowAverageFatPerDay.Text = "label42";
            // 
            // label_ShowHeartDisease
            // 
            this.label_ShowHeartDisease.AutoSize = true;
            this.label_ShowHeartDisease.Location = new System.Drawing.Point(311, 375);
            this.label_ShowHeartDisease.Name = "label_ShowHeartDisease";
            this.label_ShowHeartDisease.Size = new System.Drawing.Size(41, 13);
            this.label_ShowHeartDisease.TabIndex = 46;
            this.label_ShowHeartDisease.Text = "label43";
            // 
            // label_ShowCancer
            // 
            this.label_ShowCancer.AutoSize = true;
            this.label_ShowCancer.Location = new System.Drawing.Point(311, 399);
            this.label_ShowCancer.Name = "label_ShowCancer";
            this.label_ShowCancer.Size = new System.Drawing.Size(41, 13);
            this.label_ShowCancer.TabIndex = 47;
            this.label_ShowCancer.Text = "label44";
            // 
            // label_ShowHospitalized
            // 
            this.label_ShowHospitalized.AutoSize = true;
            this.label_ShowHospitalized.Location = new System.Drawing.Point(311, 423);
            this.label_ShowHospitalized.Name = "label_ShowHospitalized";
            this.label_ShowHospitalized.Size = new System.Drawing.Size(41, 13);
            this.label_ShowHospitalized.TabIndex = 48;
            this.label_ShowHospitalized.Text = "label45";
            // 
            // label_ShowDangerousActivity
            // 
            this.label_ShowDangerousActivity.AutoSize = true;
            this.label_ShowDangerousActivity.Location = new System.Drawing.Point(311, 447);
            this.label_ShowDangerousActivity.Name = "label_ShowDangerousActivity";
            this.label_ShowDangerousActivity.Size = new System.Drawing.Size(27, 13);
            this.label_ShowDangerousActivity.TabIndex = 49;
            this.label_ShowDangerousActivity.Text = "N/A";
            // 
            // label_ShowPolicyStartDate
            // 
            this.label_ShowPolicyStartDate.AutoSize = true;
            this.label_ShowPolicyStartDate.Location = new System.Drawing.Point(311, 470);
            this.label_ShowPolicyStartDate.Name = "label_ShowPolicyStartDate";
            this.label_ShowPolicyStartDate.Size = new System.Drawing.Size(41, 13);
            this.label_ShowPolicyStartDate.TabIndex = 51;
            this.label_ShowPolicyStartDate.Text = "label48";
            // 
            // label_ShowPolicyEndDate
            // 
            this.label_ShowPolicyEndDate.AutoSize = true;
            this.label_ShowPolicyEndDate.Location = new System.Drawing.Point(311, 494);
            this.label_ShowPolicyEndDate.Name = "label_ShowPolicyEndDate";
            this.label_ShowPolicyEndDate.Size = new System.Drawing.Size(27, 13);
            this.label_ShowPolicyEndDate.TabIndex = 52;
            this.label_ShowPolicyEndDate.Text = "N/A";
            // 
            // label_ShowAgentNumber
            // 
            this.label_ShowAgentNumber.AutoSize = true;
            this.label_ShowAgentNumber.Location = new System.Drawing.Point(311, 518);
            this.label_ShowAgentNumber.Name = "label_ShowAgentNumber";
            this.label_ShowAgentNumber.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAgentNumber.TabIndex = 53;
            this.label_ShowAgentNumber.Text = "label50";
            // 
            // label_ShowAgentFirstName
            // 
            this.label_ShowAgentFirstName.AutoSize = true;
            this.label_ShowAgentFirstName.Location = new System.Drawing.Point(311, 542);
            this.label_ShowAgentFirstName.Name = "label_ShowAgentFirstName";
            this.label_ShowAgentFirstName.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAgentFirstName.TabIndex = 54;
            this.label_ShowAgentFirstName.Text = "label51";
            // 
            // label_ShowAgentLastName
            // 
            this.label_ShowAgentLastName.AutoSize = true;
            this.label_ShowAgentLastName.Location = new System.Drawing.Point(311, 566);
            this.label_ShowAgentLastName.Name = "label_ShowAgentLastName";
            this.label_ShowAgentLastName.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAgentLastName.TabIndex = 55;
            this.label_ShowAgentLastName.Text = "label52";
            // 
            // label_ShowPayoffAmount
            // 
            this.label_ShowPayoffAmount.AutoSize = true;
            this.label_ShowPayoffAmount.Location = new System.Drawing.Point(311, 590);
            this.label_ShowPayoffAmount.Name = "label_ShowPayoffAmount";
            this.label_ShowPayoffAmount.Size = new System.Drawing.Size(41, 13);
            this.label_ShowPayoffAmount.TabIndex = 56;
            this.label_ShowPayoffAmount.Text = "label53";
            // 
            // label_ShowMonthlyPremium
            // 
            this.label_ShowMonthlyPremium.AutoSize = true;
            this.label_ShowMonthlyPremium.Location = new System.Drawing.Point(311, 614);
            this.label_ShowMonthlyPremium.Name = "label_ShowMonthlyPremium";
            this.label_ShowMonthlyPremium.Size = new System.Drawing.Size(41, 13);
            this.label_ShowMonthlyPremium.TabIndex = 57;
            this.label_ShowMonthlyPremium.Text = "label54";
            // 
            // linkLabel_Back
            // 
            this.linkLabel_Back.AutoSize = true;
            this.linkLabel_Back.Location = new System.Drawing.Point(12, 21);
            this.linkLabel_Back.Name = "linkLabel_Back";
            this.linkLabel_Back.Size = new System.Drawing.Size(32, 13);
            this.linkLabel_Back.TabIndex = 1;
            this.linkLabel_Back.TabStop = true;
            this.linkLabel_Back.Text = "Back";
            this.linkLabel_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Back_LinkClicked);
            // 
            // listBox_BeneficiaryName
            // 
            this.listBox_BeneficiaryName.FormattingEnabled = true;
            this.listBox_BeneficiaryName.HorizontalScrollbar = true;
            this.listBox_BeneficiaryName.Location = new System.Drawing.Point(310, 634);
            this.listBox_BeneficiaryName.Name = "listBox_BeneficiaryName";
            this.listBox_BeneficiaryName.Size = new System.Drawing.Size(238, 43);
            this.listBox_BeneficiaryName.TabIndex = 2;
            // 
            // PolicyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 791);
            this.Controls.Add(this.listBox_BeneficiaryName);
            this.Controls.Add(this.linkLabel_Back);
            this.Controls.Add(this.label_ShowMonthlyPremium);
            this.Controls.Add(this.label_ShowPayoffAmount);
            this.Controls.Add(this.label_ShowAgentLastName);
            this.Controls.Add(this.label_ShowAgentFirstName);
            this.Controls.Add(this.label_ShowAgentNumber);
            this.Controls.Add(this.label_ShowPolicyEndDate);
            this.Controls.Add(this.label_ShowPolicyStartDate);
            this.Controls.Add(this.label_ShowDangerousActivity);
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
            this.Controls.Add(this.label_ShowAddressZip);
            this.Controls.Add(this.label_ShowAddressState);
            this.Controls.Add(this.label_ShowAddressCity);
            this.Controls.Add(this.label_ShowAddressStreet);
            this.Controls.Add(this.label_ShowPolicyholderLastName);
            this.Controls.Add(this.label_ShowPolicyholderFirstName);
            this.Controls.Add(this.label_ShowPolicyNumber);
            this.Controls.Add(this.linkLabel_ViewPaymentHistory);
            this.Controls.Add(this.linkLabel_MakeClaim);
            this.Controls.Add(this.linkLabel_UpdatePolicy);
            this.Controls.Add(this.linkLabel_CancelPolicy);
            this.Controls.Add(this.label_BenficiaryFirstName);
            this.Controls.Add(this.label_MonthlyPremium);
            this.Controls.Add(this.label_PayoffAmount);
            this.Controls.Add(this.label_AgentLastName);
            this.Controls.Add(this.label_AgentFirstName);
            this.Controls.Add(this.label_AgentNumber);
            this.Controls.Add(this.label_PolicyEndDate);
            this.Controls.Add(this.label_PolicyStartDate);
            this.Controls.Add(this.label_DangerousActivity);
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
            this.Name = "PolicyPage";
            this.Text = "Policy Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_PolicyNumber;
        private Label label_PolicyholderFirstName;
        private Label label_PolicyholderLastName;
        private Label label_AddressStreet;
        private Label label_AddressCity;
        private Label label_AddressState;
        private Label label_AddressZip;
        private Label label_PolicyholderDOB;
        private Label label_FatherAAD;
        private Label label_MotherAAD;
        private Label label_SmokingHistory;
        private Label label_CigPerDay;
        private Label label_SystolicBloodPressure;
        private Label label_AverageFatPerDay;
        private Label label_HeartDisease;
        private Label label_Cancer;
        private Label label_Hospitalized;
        private Label label_DangerousActivity;
        private Label label_PolicyStartDate;
        private Label label_PolicyEndDate;
        private Label label_AgentNumber;
        private Label label_AgentFirstName;
        private Label label_AgentLastName;
        private Label label_PayoffAmount;
        private Label label_MonthlyPremium;
        private Label label_BenficiaryFirstName;
        private LinkLabel linkLabel_CancelPolicy;
        private LinkLabel linkLabel_UpdatePolicy;
        private LinkLabel linkLabel_MakeClaim;
        private LinkLabel linkLabel_ViewPaymentHistory;
        private Label label_ShowPolicyNumber;
        private Label label_ShowPolicyholderFirstName;
        private Label label_ShowPolicyholderLastName;
        private Label label_ShowAddressStreet;
        private Label label_ShowAddressCity;
        private Label label_ShowAddressState;
        private Label label_ShowAddressZip;
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
        private Label label_ShowDangerousActivity;
        private Label label_ShowPolicyStartDate;
        private Label label_ShowPolicyEndDate;
        private Label label_ShowAgentNumber;
        private Label label_ShowAgentFirstName;
        private Label label_ShowAgentLastName;
        private Label label_ShowPayoffAmount;
        private Label label_ShowMonthlyPremium;
        private LinkLabel linkLabel_Back;
        private Agent usingAgent;
        private Search previousPage;
        private Policy inPolicy;
        private ListBox listBox_BeneficiaryName;
    }
}