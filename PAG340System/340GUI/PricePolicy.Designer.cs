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
    partial class PricePolicy
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
            this.label_TotalAmountOfPayment = new System.Windows.Forms.Label();
            this.label_PayoffAmount = new System.Windows.Forms.Label();
            this.label_DangerousActivity = new System.Windows.Forms.Label();
            this.label_Hopitalized = new System.Windows.Forms.Label();
            this.label_Cancer = new System.Windows.Forms.Label();
            this.label_HeartDisease = new System.Windows.Forms.Label();
            this.label_AverageFatPerDay = new System.Windows.Forms.Label();
            this.label_SystolicBloodPressure = new System.Windows.Forms.Label();
            this.label_CigPerDay = new System.Windows.Forms.Label();
            this.label_SmokingHistory = new System.Windows.Forms.Label();
            this.label_MotherAAD = new System.Windows.Forms.Label();
            this.label_FatherAAD = new System.Windows.Forms.Label();
            this.label_PolicyholderDOB = new System.Windows.Forms.Label();
            this.textBox_PolicyholderDOB = new System.Windows.Forms.TextBox();
            this.textBox_FatherAAD = new System.Windows.Forms.TextBox();
            this.textBox_MotherAAD = new System.Windows.Forms.TextBox();
            this.textBox_SmokingHistory = new System.Windows.Forms.TextBox();
            this.textBox_CigPerDay = new System.Windows.Forms.TextBox();
            this.textBox_SystolicBloodPressure = new System.Windows.Forms.TextBox();
            this.textBox_AverageFatPerDay = new System.Windows.Forms.TextBox();
            this.textBox_DangerousActivity = new System.Windows.Forms.TextBox();
            this.radioButton_YesHeartDisease = new System.Windows.Forms.RadioButton();
            this.radioButton_NoHeartDisease = new System.Windows.Forms.RadioButton();
            this.label_PricePolicy = new System.Windows.Forms.Label();
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_ShowTotalAmountOfPayment = new System.Windows.Forms.Label();
            this.button_Price = new System.Windows.Forms.Button();
            this.panel_HeartDisease = new System.Windows.Forms.Panel();
            this.panel_Cancer = new System.Windows.Forms.Panel();
            this.radioButton_YesCancer = new System.Windows.Forms.RadioButton();
            this.radioButton_NoCancer = new System.Windows.Forms.RadioButton();
            this.panel_Hospitalized = new System.Windows.Forms.Panel();
            this.radioButton_YesHospitalized = new System.Windows.Forms.RadioButton();
            this.radioButton_NoHospitalized = new System.Windows.Forms.RadioButton();
            this.textBox_PayOffAmount = new System.Windows.Forms.TextBox();
            this.label_WarningDOB = new System.Windows.Forms.Label();
            this.label_WarningFAD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_HeartDisease.SuspendLayout();
            this.panel_Cancer.SuspendLayout();
            this.panel_Hospitalized.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_TotalAmountOfPayment
            // 
            this.label_TotalAmountOfPayment.AutoSize = true;
            this.label_TotalAmountOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalAmountOfPayment.Location = new System.Drawing.Point(131, 321);
            this.label_TotalAmountOfPayment.Name = "label_TotalAmountOfPayment";
            this.label_TotalAmountOfPayment.Size = new System.Drawing.Size(225, 13);
            this.label_TotalAmountOfPayment.TabIndex = 48;
            this.label_TotalAmountOfPayment.Text = "Total Amount of Payment per Month: $";
            // 
            // label_PayoffAmount
            // 
            this.label_PayoffAmount.AutoSize = true;
            this.label_PayoffAmount.Location = new System.Drawing.Point(277, 298);
            this.label_PayoffAmount.Name = "label_PayoffAmount";
            this.label_PayoffAmount.Size = new System.Drawing.Size(79, 13);
            this.label_PayoffAmount.TabIndex = 47;
            this.label_PayoffAmount.Text = "Payoff Amount:";
            // 
            // label_DangerousActivity
            // 
            this.label_DangerousActivity.AutoSize = true;
            this.label_DangerousActivity.Location = new System.Drawing.Point(249, 276);
            this.label_DangerousActivity.Name = "label_DangerousActivity";
            this.label_DangerousActivity.Size = new System.Drawing.Size(107, 13);
            this.label_DangerousActivity.TabIndex = 45;
            this.label_DangerousActivity.Text = "Dangerous Activities:";
            // 
            // label_Hopitalized
            // 
            this.label_Hopitalized.AutoSize = true;
            this.label_Hopitalized.Location = new System.Drawing.Point(289, 254);
            this.label_Hopitalized.Name = "label_Hopitalized";
            this.label_Hopitalized.Size = new System.Drawing.Size(67, 13);
            this.label_Hopitalized.TabIndex = 44;
            this.label_Hopitalized.Text = "Hospitalized:";
            // 
            // label_Cancer
            // 
            this.label_Cancer.AutoSize = true;
            this.label_Cancer.Location = new System.Drawing.Point(312, 232);
            this.label_Cancer.Name = "label_Cancer";
            this.label_Cancer.Size = new System.Drawing.Size(44, 13);
            this.label_Cancer.TabIndex = 43;
            this.label_Cancer.Text = "Cancer:";
            // 
            // label_HeartDisease
            // 
            this.label_HeartDisease.AutoSize = true;
            this.label_HeartDisease.Location = new System.Drawing.Point(279, 210);
            this.label_HeartDisease.Name = "label_HeartDisease";
            this.label_HeartDisease.Size = new System.Drawing.Size(77, 13);
            this.label_HeartDisease.TabIndex = 42;
            this.label_HeartDisease.Text = "Heart Disease:";
            // 
            // label_AverageFatPerDay
            // 
            this.label_AverageFatPerDay.AutoSize = true;
            this.label_AverageFatPerDay.Location = new System.Drawing.Point(215, 188);
            this.label_AverageFatPerDay.Name = "label_AverageFatPerDay";
            this.label_AverageFatPerDay.Size = new System.Drawing.Size(141, 13);
            this.label_AverageFatPerDay.TabIndex = 41;
            this.label_AverageFatPerDay.Text = "Average Grams Fat per Day:";
            // 
            // label_SystolicBloodPressure
            // 
            this.label_SystolicBloodPressure.AutoSize = true;
            this.label_SystolicBloodPressure.Location = new System.Drawing.Point(236, 166);
            this.label_SystolicBloodPressure.Name = "label_SystolicBloodPressure";
            this.label_SystolicBloodPressure.Size = new System.Drawing.Size(120, 13);
            this.label_SystolicBloodPressure.TabIndex = 40;
            this.label_SystolicBloodPressure.Text = "Systolic Blood Pressure:";
            // 
            // label_CigPerDay
            // 
            this.label_CigPerDay.AutoSize = true;
            this.label_CigPerDay.Location = new System.Drawing.Point(286, 144);
            this.label_CigPerDay.Name = "label_CigPerDay";
            this.label_CigPerDay.Size = new System.Drawing.Size(70, 13);
            this.label_CigPerDay.TabIndex = 39;
            this.label_CigPerDay.Text = "Cigs per Day:";
            // 
            // label_SmokingHistory
            // 
            this.label_SmokingHistory.AutoSize = true;
            this.label_SmokingHistory.Location = new System.Drawing.Point(270, 122);
            this.label_SmokingHistory.Name = "label_SmokingHistory";
            this.label_SmokingHistory.Size = new System.Drawing.Size(86, 13);
            this.label_SmokingHistory.TabIndex = 38;
            this.label_SmokingHistory.Text = "Smoking History:";
            // 
            // label_MotherAAD
            // 
            this.label_MotherAAD.AutoSize = true;
            this.label_MotherAAD.Location = new System.Drawing.Point(240, 100);
            this.label_MotherAAD.Name = "label_MotherAAD";
            this.label_MotherAAD.Size = new System.Drawing.Size(116, 13);
            this.label_MotherAAD.TabIndex = 37;
            this.label_MotherAAD.Text = "Mother\'s Age at Death:";
            // 
            // label_FatherAAD
            // 
            this.label_FatherAAD.AutoSize = true;
            this.label_FatherAAD.Location = new System.Drawing.Point(243, 78);
            this.label_FatherAAD.Name = "label_FatherAAD";
            this.label_FatherAAD.Size = new System.Drawing.Size(113, 13);
            this.label_FatherAAD.TabIndex = 36;
            this.label_FatherAAD.Text = "Father\'s Age at Death:";
            // 
            // label_PolicyholderDOB
            // 
            this.label_PolicyholderDOB.AutoSize = true;
            this.label_PolicyholderDOB.Location = new System.Drawing.Point(220, 56);
            this.label_PolicyholderDOB.Name = "label_PolicyholderDOB";
            this.label_PolicyholderDOB.Size = new System.Drawing.Size(136, 13);
            this.label_PolicyholderDOB.TabIndex = 35;
            this.label_PolicyholderDOB.Text = "Policyholder\'s Date of Birth:";
            // 
            // textBox_PolicyholderDOB
            // 
            this.textBox_PolicyholderDOB.ForeColor = System.Drawing.Color.Black;
            this.textBox_PolicyholderDOB.Location = new System.Drawing.Point(362, 53);
            this.textBox_PolicyholderDOB.MaxLength = 10;
            this.textBox_PolicyholderDOB.Name = "textBox_PolicyholderDOB";
            this.textBox_PolicyholderDOB.Size = new System.Drawing.Size(239, 20);
            this.textBox_PolicyholderDOB.TabIndex = 49;
            this.textBox_PolicyholderDOB.Text = "yyyy/mm/dd";
            // 
            // textBox_FatherAAD
            // 
            this.textBox_FatherAAD.ForeColor = System.Drawing.Color.Black;
            this.textBox_FatherAAD.Location = new System.Drawing.Point(362, 75);
            this.textBox_FatherAAD.MaxLength = 5;
            this.textBox_FatherAAD.Name = "textBox_FatherAAD";
            this.textBox_FatherAAD.Size = new System.Drawing.Size(239, 20);
            this.textBox_FatherAAD.TabIndex = 50;
            // 
            // textBox_MotherAAD
            // 
            this.textBox_MotherAAD.ForeColor = System.Drawing.Color.Black;
            this.textBox_MotherAAD.Location = new System.Drawing.Point(362, 97);
            this.textBox_MotherAAD.MaxLength = 5;
            this.textBox_MotherAAD.Name = "textBox_MotherAAD";
            this.textBox_MotherAAD.Size = new System.Drawing.Size(239, 20);
            this.textBox_MotherAAD.TabIndex = 51;
            // 
            // textBox_SmokingHistory
            // 
            this.textBox_SmokingHistory.ForeColor = System.Drawing.Color.Black;
            this.textBox_SmokingHistory.Location = new System.Drawing.Point(362, 119);
            this.textBox_SmokingHistory.MaxLength = 5;
            this.textBox_SmokingHistory.Name = "textBox_SmokingHistory";
            this.textBox_SmokingHistory.Size = new System.Drawing.Size(239, 20);
            this.textBox_SmokingHistory.TabIndex = 52;
            // 
            // textBox_CigPerDay
            // 
            this.textBox_CigPerDay.ForeColor = System.Drawing.Color.Black;
            this.textBox_CigPerDay.Location = new System.Drawing.Point(362, 141);
            this.textBox_CigPerDay.Name = "textBox_CigPerDay";
            this.textBox_CigPerDay.Size = new System.Drawing.Size(239, 20);
            this.textBox_CigPerDay.TabIndex = 53;
            // 
            // textBox_SystolicBloodPressure
            // 
            this.textBox_SystolicBloodPressure.ForeColor = System.Drawing.Color.Black;
            this.textBox_SystolicBloodPressure.Location = new System.Drawing.Point(362, 163);
            this.textBox_SystolicBloodPressure.Name = "textBox_SystolicBloodPressure";
            this.textBox_SystolicBloodPressure.Size = new System.Drawing.Size(239, 20);
            this.textBox_SystolicBloodPressure.TabIndex = 54;
            // 
            // textBox_AverageFatPerDay
            // 
            this.textBox_AverageFatPerDay.ForeColor = System.Drawing.Color.Black;
            this.textBox_AverageFatPerDay.Location = new System.Drawing.Point(362, 185);
            this.textBox_AverageFatPerDay.Name = "textBox_AverageFatPerDay";
            this.textBox_AverageFatPerDay.Size = new System.Drawing.Size(239, 20);
            this.textBox_AverageFatPerDay.TabIndex = 55;
            // 
            // textBox_DangerousActivity
            // 
            this.textBox_DangerousActivity.ForeColor = System.Drawing.Color.Black;
            this.textBox_DangerousActivity.Location = new System.Drawing.Point(362, 273);
            this.textBox_DangerousActivity.MaxLength = 255;
            this.textBox_DangerousActivity.Name = "textBox_DangerousActivity";
            this.textBox_DangerousActivity.Size = new System.Drawing.Size(239, 20);
            this.textBox_DangerousActivity.TabIndex = 62;
            // 
            // radioButton_YesHeartDisease
            // 
            this.radioButton_YesHeartDisease.AutoSize = true;
            this.radioButton_YesHeartDisease.Location = new System.Drawing.Point(3, 3);
            this.radioButton_YesHeartDisease.Name = "radioButton_YesHeartDisease";
            this.radioButton_YesHeartDisease.Size = new System.Drawing.Size(43, 17);
            this.radioButton_YesHeartDisease.TabIndex = 56;
            this.radioButton_YesHeartDisease.TabStop = true;
            this.radioButton_YesHeartDisease.Text = "Yes";
            this.radioButton_YesHeartDisease.UseVisualStyleBackColor = true;
            // 
            // radioButton_NoHeartDisease
            // 
            this.radioButton_NoHeartDisease.AutoSize = true;
            this.radioButton_NoHeartDisease.Location = new System.Drawing.Point(65, 3);
            this.radioButton_NoHeartDisease.Name = "radioButton_NoHeartDisease";
            this.radioButton_NoHeartDisease.Size = new System.Drawing.Size(39, 17);
            this.radioButton_NoHeartDisease.TabIndex = 57;
            this.radioButton_NoHeartDisease.TabStop = true;
            this.radioButton_NoHeartDisease.Text = "No";
            this.radioButton_NoHeartDisease.UseVisualStyleBackColor = true;
            // 
            // label_PricePolicy
            // 
            this.label_PricePolicy.AutoSize = true;
            this.label_PricePolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PricePolicy.Location = new System.Drawing.Point(328, 25);
            this.label_PricePolicy.Name = "label_PricePolicy";
            this.label_PricePolicy.Size = new System.Drawing.Size(85, 13);
            this.label_PricePolicy.TabIndex = 67;
            this.label_PricePolicy.Text = "Price a Policy";
            // 
            // button_Accept
            // 
            this.button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Accept.Location = new System.Drawing.Point(246, 350);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(75, 23);
            this.button_Accept.TabIndex = 66;
            this.button_Accept.Text = "Accept";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.Location = new System.Drawing.Point(464, 350);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 67;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_ShowTotalAmountOfPayment
            // 
            this.label_ShowTotalAmountOfPayment.AutoSize = true;
            this.label_ShowTotalAmountOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowTotalAmountOfPayment.Location = new System.Drawing.Point(367, 321);
            this.label_ShowTotalAmountOfPayment.Name = "label_ShowTotalAmountOfPayment";
            this.label_ShowTotalAmountOfPayment.Size = new System.Drawing.Size(41, 13);
            this.label_ShowTotalAmountOfPayment.TabIndex = 71;
            this.label_ShowTotalAmountOfPayment.Text = "label3";
            // 
            // button_Price
            // 
            this.button_Price.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Price.Location = new System.Drawing.Point(546, 316);
            this.button_Price.Name = "button_Price";
            this.button_Price.Size = new System.Drawing.Size(55, 23);
            this.button_Price.TabIndex = 65;
            this.button_Price.Text = "Price";
            this.button_Price.UseVisualStyleBackColor = false;
            this.button_Price.Click += new System.EventHandler(this.button_Price_Click);
            // 
            // panel_HeartDisease
            // 
            this.panel_HeartDisease.Controls.Add(this.radioButton_YesHeartDisease);
            this.panel_HeartDisease.Controls.Add(this.radioButton_NoHeartDisease);
            this.panel_HeartDisease.Location = new System.Drawing.Point(367, 205);
            this.panel_HeartDisease.Name = "panel_HeartDisease";
            this.panel_HeartDisease.Size = new System.Drawing.Size(164, 21);
            this.panel_HeartDisease.TabIndex = 56;
            // 
            // panel_Cancer
            // 
            this.panel_Cancer.Controls.Add(this.radioButton_YesCancer);
            this.panel_Cancer.Controls.Add(this.radioButton_NoCancer);
            this.panel_Cancer.Location = new System.Drawing.Point(367, 228);
            this.panel_Cancer.Name = "panel_Cancer";
            this.panel_Cancer.Size = new System.Drawing.Size(164, 21);
            this.panel_Cancer.TabIndex = 58;
            // 
            // radioButton_YesCancer
            // 
            this.radioButton_YesCancer.AutoSize = true;
            this.radioButton_YesCancer.Location = new System.Drawing.Point(3, 3);
            this.radioButton_YesCancer.Name = "radioButton_YesCancer";
            this.radioButton_YesCancer.Size = new System.Drawing.Size(43, 17);
            this.radioButton_YesCancer.TabIndex = 58;
            this.radioButton_YesCancer.TabStop = true;
            this.radioButton_YesCancer.Text = "Yes";
            this.radioButton_YesCancer.UseVisualStyleBackColor = true;
            // 
            // radioButton_NoCancer
            // 
            this.radioButton_NoCancer.AutoSize = true;
            this.radioButton_NoCancer.Location = new System.Drawing.Point(65, 3);
            this.radioButton_NoCancer.Name = "radioButton_NoCancer";
            this.radioButton_NoCancer.Size = new System.Drawing.Size(39, 17);
            this.radioButton_NoCancer.TabIndex = 59;
            this.radioButton_NoCancer.TabStop = true;
            this.radioButton_NoCancer.Text = "No";
            this.radioButton_NoCancer.UseVisualStyleBackColor = true;
            // 
            // panel_Hospitalized
            // 
            this.panel_Hospitalized.Controls.Add(this.radioButton_YesHospitalized);
            this.panel_Hospitalized.Controls.Add(this.radioButton_NoHospitalized);
            this.panel_Hospitalized.Location = new System.Drawing.Point(367, 252);
            this.panel_Hospitalized.Name = "panel_Hospitalized";
            this.panel_Hospitalized.Size = new System.Drawing.Size(164, 21);
            this.panel_Hospitalized.TabIndex = 60;
            // 
            // radioButton_YesHospitalized
            // 
            this.radioButton_YesHospitalized.AutoSize = true;
            this.radioButton_YesHospitalized.Location = new System.Drawing.Point(3, 3);
            this.radioButton_YesHospitalized.Name = "radioButton_YesHospitalized";
            this.radioButton_YesHospitalized.Size = new System.Drawing.Size(43, 17);
            this.radioButton_YesHospitalized.TabIndex = 60;
            this.radioButton_YesHospitalized.TabStop = true;
            this.radioButton_YesHospitalized.Text = "Yes";
            this.radioButton_YesHospitalized.UseVisualStyleBackColor = true;
            // 
            // radioButton_NoHospitalized
            // 
            this.radioButton_NoHospitalized.AutoSize = true;
            this.radioButton_NoHospitalized.Location = new System.Drawing.Point(65, 3);
            this.radioButton_NoHospitalized.Name = "radioButton_NoHospitalized";
            this.radioButton_NoHospitalized.Size = new System.Drawing.Size(39, 17);
            this.radioButton_NoHospitalized.TabIndex = 61;
            this.radioButton_NoHospitalized.TabStop = true;
            this.radioButton_NoHospitalized.Text = "No";
            this.radioButton_NoHospitalized.UseVisualStyleBackColor = true;
            // 
            // textBox_PayOffAmount
            // 
            this.textBox_PayOffAmount.ForeColor = System.Drawing.Color.Black;
            this.textBox_PayOffAmount.Location = new System.Drawing.Point(362, 295);
            this.textBox_PayOffAmount.MaxLength = 10;
            this.textBox_PayOffAmount.Name = "textBox_PayOffAmount";
            this.textBox_PayOffAmount.Size = new System.Drawing.Size(239, 20);
            this.textBox_PayOffAmount.TabIndex = 64;
            // 
            // label_WarningDOB
            // 
            this.label_WarningDOB.AutoSize = true;
            this.label_WarningDOB.ForeColor = System.Drawing.Color.DarkRed;
            this.label_WarningDOB.Location = new System.Drawing.Point(607, 56);
            this.label_WarningDOB.Name = "label_WarningDOB";
            this.label_WarningDOB.Size = new System.Drawing.Size(35, 13);
            this.label_WarningDOB.TabIndex = 72;
            this.label_WarningDOB.Text = "label1";
            // 
            // label_WarningFAD
            // 
            this.label_WarningFAD.AutoSize = true;
            this.label_WarningFAD.ForeColor = System.Drawing.Color.DarkRed;
            this.label_WarningFAD.Location = new System.Drawing.Point(607, 78);
            this.label_WarningFAD.Name = "label_WarningFAD";
            this.label_WarningFAD.Size = new System.Drawing.Size(35, 13);
            this.label_WarningFAD.TabIndex = 73;
            this.label_WarningFAD.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(607, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(607, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(607, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(607, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(607, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "label1";
            // 
            // PricePolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_WarningFAD);
            this.Controls.Add(this.label_WarningDOB);
            this.Controls.Add(this.textBox_PayOffAmount);
            this.Controls.Add(this.panel_Hospitalized);
            this.Controls.Add(this.panel_Cancer);
            this.Controls.Add(this.panel_HeartDisease);
            this.Controls.Add(this.button_Price);
            this.Controls.Add(this.label_ShowTotalAmountOfPayment);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.label_PricePolicy);
            this.Controls.Add(this.textBox_DangerousActivity);
            this.Controls.Add(this.textBox_AverageFatPerDay);
            this.Controls.Add(this.textBox_SystolicBloodPressure);
            this.Controls.Add(this.textBox_CigPerDay);
            this.Controls.Add(this.textBox_SmokingHistory);
            this.Controls.Add(this.textBox_MotherAAD);
            this.Controls.Add(this.textBox_FatherAAD);
            this.Controls.Add(this.textBox_PolicyholderDOB);
            this.Controls.Add(this.label_TotalAmountOfPayment);
            this.Controls.Add(this.label_PayoffAmount);
            this.Controls.Add(this.label_DangerousActivity);
            this.Controls.Add(this.label_Hopitalized);
            this.Controls.Add(this.label_Cancer);
            this.Controls.Add(this.label_HeartDisease);
            this.Controls.Add(this.label_AverageFatPerDay);
            this.Controls.Add(this.label_SystolicBloodPressure);
            this.Controls.Add(this.label_CigPerDay);
            this.Controls.Add(this.label_SmokingHistory);
            this.Controls.Add(this.label_MotherAAD);
            this.Controls.Add(this.label_FatherAAD);
            this.Controls.Add(this.label_PolicyholderDOB);
            this.Name = "PricePolicy";
            this.Text = "Price a Policy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDown);
            this.panel_HeartDisease.ResumeLayout(false);
            this.panel_HeartDisease.PerformLayout();
            this.panel_Cancer.ResumeLayout(false);
            this.panel_Cancer.PerformLayout();
            this.panel_Hospitalized.ResumeLayout(false);
            this.panel_Hospitalized.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_TotalAmountOfPayment;
        private Label label_PayoffAmount;
        private Label label_DangerousActivity;
        private Label label_Hopitalized;
        private Label label_Cancer;
        private Label label_HeartDisease;
        private Label label_AverageFatPerDay;
        private Label label_SystolicBloodPressure;
        private Label label_CigPerDay;
        private Label label_SmokingHistory;
        private Label label_MotherAAD;
        private Label label_FatherAAD;
        private Label label_PolicyholderDOB;
        private TextBox textBox_PolicyholderDOB;
        private TextBox textBox_FatherAAD;
        private TextBox textBox_MotherAAD;
        private TextBox textBox_SmokingHistory;
        private TextBox textBox_CigPerDay;
        private TextBox textBox_SystolicBloodPressure;
        private TextBox textBox_AverageFatPerDay;
        private TextBox textBox_DangerousActivity;
        private RadioButton radioButton_YesHeartDisease;
        private RadioButton radioButton_NoHeartDisease;
        private Label label_PricePolicy;
        private Button button_Accept;
        private Button button_Cancel;
        private Label label_ShowTotalAmountOfPayment;
        private Agent usingAgent;
        private Button button_Price;
        private Panel panel_HeartDisease;
        private Panel panel_Cancer;
        private RadioButton radioButton_YesCancer;
        private RadioButton radioButton_NoCancer;
        private Panel panel_Hospitalized;
        private RadioButton radioButton_YesHospitalized;
        private RadioButton radioButton_NoHospitalized;
        private Policy pricingPolicy;
        private TextBox textBox_PayOffAmount;
        private Label label_WarningDOB;
        private Label label_WarningFAD;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}