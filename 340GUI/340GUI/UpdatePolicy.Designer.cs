using System.Windows.Forms;
using PAG340MiddleWare;

namespace _340GUI
{
    partial class UpdatePolicy
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
            this.Beneficiary_Last_Name_Label = new System.Windows.Forms.Label();
            this.Beneficiary_First_Name_Label = new System.Windows.Forms.Label();
            this.Monthly_Premium_Label = new System.Windows.Forms.Label();
            this.Payoff_Amount_Label = new System.Windows.Forms.Label();
            this.Agent_Last_Name_Label = new System.Windows.Forms.Label();
            this.Agent_First_Name_Label = new System.Windows.Forms.Label();
            this.Agent_Number_Label = new System.Windows.Forms.Label();
            this.Policy_End_Date_Label = new System.Windows.Forms.Label();
            this.Policy_Start_Date_Label = new System.Windows.Forms.Label();
            this.Hours_Of_Exercise_Per_Week_Label = new System.Windows.Forms.Label();
            this.Dangerous_Activities_Label = new System.Windows.Forms.Label();
            this.Hospitalized_Label = new System.Windows.Forms.Label();
            this.Cancer_Label = new System.Windows.Forms.Label();
            this.Heart_Disease_Label = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.Systolic_Blood_Pressure_Label = new System.Windows.Forms.Label();
            this.Cigs_Per_Day_Label = new System.Windows.Forms.Label();
            this.Smoking_History_Label = new System.Windows.Forms.Label();
            this.Mother_Age_At_Death_Label = new System.Windows.Forms.Label();
            this.Father_Age_At_Death_Label = new System.Windows.Forms.Label();
            this.Policyholder_DOB_Label = new System.Windows.Forms.Label();
            this.Address_Zip_Label = new System.Windows.Forms.Label();
            this.Address_State_Label = new System.Windows.Forms.Label();
            this.Address_City_Label = new System.Windows.Forms.Label();
            this.Address_Street_Label = new System.Windows.Forms.Label();
            this.Policyholder_Last_Name_Label = new System.Windows.Forms.Label();
            this.Policyholder_First_Name_Label = new System.Windows.Forms.Label();
            this.Policy_Number_Label = new System.Windows.Forms.Label();
            this.Update_Policy_Label = new System.Windows.Forms.Label();
            this.Policyholder_First_Name_textBox = new System.Windows.Forms.TextBox();
            this.Policyholder_Last_Name_textBox = new System.Windows.Forms.TextBox();
            this.Address_Street_textBox = new System.Windows.Forms.TextBox();
            this.Address_City_textBox = new System.Windows.Forms.TextBox();
            this.Address_Zip_textBox = new System.Windows.Forms.TextBox();
            this.Beneficiary_First_Name_textBox = new System.Windows.Forms.TextBox();
            this.Beneficiary_Last_Name_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Address_State_dropDown_Menu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Beneficiary_Last_Name_Label
            // 
            this.Beneficiary_Last_Name_Label.AutoSize = true;
            this.Beneficiary_Last_Name_Label.Location = new System.Drawing.Point(183, 733);
            this.Beneficiary_Last_Name_Label.Name = "Beneficiary_Last_Name_Label";
            this.Beneficiary_Last_Name_Label.Size = new System.Drawing.Size(116, 13);
            this.Beneficiary_Last_Name_Label.TabIndex = 55;
            this.Beneficiary_Last_Name_Label.Text = "Beneficiary Last Name:";
            // 
            // Beneficiary_First_Name_Label
            // 
            this.Beneficiary_First_Name_Label.AutoSize = true;
            this.Beneficiary_First_Name_Label.Location = new System.Drawing.Point(183, 708);
            this.Beneficiary_First_Name_Label.Name = "Beneficiary_First_Name_Label";
            this.Beneficiary_First_Name_Label.Size = new System.Drawing.Size(115, 13);
            this.Beneficiary_First_Name_Label.TabIndex = 54;
            this.Beneficiary_First_Name_Label.Text = "Beneficiary First Name:";
            // 
            // Monthly_Premium_Label
            // 
            this.Monthly_Premium_Label.AutoSize = true;
            this.Monthly_Premium_Label.Location = new System.Drawing.Point(208, 685);
            this.Monthly_Premium_Label.Name = "Monthly_Premium_Label";
            this.Monthly_Premium_Label.Size = new System.Drawing.Size(90, 13);
            this.Monthly_Premium_Label.TabIndex = 53;
            this.Monthly_Premium_Label.Text = "Monthly Premium:";
            // 
            // Payoff_Amount_Label
            // 
            this.Payoff_Amount_Label.AutoSize = true;
            this.Payoff_Amount_Label.Location = new System.Drawing.Point(219, 663);
            this.Payoff_Amount_Label.Name = "Payoff_Amount_Label";
            this.Payoff_Amount_Label.Size = new System.Drawing.Size(79, 13);
            this.Payoff_Amount_Label.TabIndex = 52;
            this.Payoff_Amount_Label.Text = "Payoff Amount:";
            // 
            // Agent_Last_Name_Label
            // 
            this.Agent_Last_Name_Label.AutoSize = true;
            this.Agent_Last_Name_Label.Location = new System.Drawing.Point(207, 641);
            this.Agent_Last_Name_Label.Name = "Agent_Last_Name_Label";
            this.Agent_Last_Name_Label.Size = new System.Drawing.Size(92, 13);
            this.Agent_Last_Name_Label.TabIndex = 51;
            this.Agent_Last_Name_Label.Text = "Agent Last Name:";
            // 
            // Agent_First_Name_Label
            // 
            this.Agent_First_Name_Label.AutoSize = true;
            this.Agent_First_Name_Label.Location = new System.Drawing.Point(207, 617);
            this.Agent_First_Name_Label.Name = "Agent_First_Name_Label";
            this.Agent_First_Name_Label.Size = new System.Drawing.Size(91, 13);
            this.Agent_First_Name_Label.TabIndex = 50;
            this.Agent_First_Name_Label.Text = "Agent First Name:";
            // 
            // Agent_Number_Label
            // 
            this.Agent_Number_Label.AutoSize = true;
            this.Agent_Number_Label.Location = new System.Drawing.Point(221, 592);
            this.Agent_Number_Label.Name = "Agent_Number_Label";
            this.Agent_Number_Label.Size = new System.Drawing.Size(78, 13);
            this.Agent_Number_Label.TabIndex = 49;
            this.Agent_Number_Label.Text = "Agent Number:";
            // 
            // Policy_End_Date_Label
            // 
            this.Policy_End_Date_Label.AutoSize = true;
            this.Policy_End_Date_Label.Location = new System.Drawing.Point(212, 568);
            this.Policy_End_Date_Label.Name = "Policy_End_Date_Label";
            this.Policy_End_Date_Label.Size = new System.Drawing.Size(86, 13);
            this.Policy_End_Date_Label.TabIndex = 48;
            this.Policy_End_Date_Label.Text = "Policy End Date:";
            // 
            // Policy_Start_Date_Label
            // 
            this.Policy_Start_Date_Label.AutoSize = true;
            this.Policy_Start_Date_Label.Location = new System.Drawing.Point(209, 543);
            this.Policy_Start_Date_Label.Name = "Policy_Start_Date_Label";
            this.Policy_Start_Date_Label.Size = new System.Drawing.Size(89, 13);
            this.Policy_Start_Date_Label.TabIndex = 47;
            this.Policy_Start_Date_Label.Text = "Policy Start Date:";
            // 
            // Hours_Of_Exercise_Per_Week_Label
            // 
            this.Hours_Of_Exercise_Per_Week_Label.AutoSize = true;
            this.Hours_Of_Exercise_Per_Week_Label.Location = new System.Drawing.Point(155, 517);
            this.Hours_Of_Exercise_Per_Week_Label.Name = "Hours_Of_Exercise_Per_Week_Label";
            this.Hours_Of_Exercise_Per_Week_Label.Size = new System.Drawing.Size(143, 13);
            this.Hours_Of_Exercise_Per_Week_Label.TabIndex = 46;
            this.Hours_Of_Exercise_Per_Week_Label.Text = "Hours of Exercise per Week:";
            // 
            // Dangerous_Activities_Label
            // 
            this.Dangerous_Activities_Label.AutoSize = true;
            this.Dangerous_Activities_Label.Location = new System.Drawing.Point(192, 491);
            this.Dangerous_Activities_Label.Name = "Dangerous_Activities_Label";
            this.Dangerous_Activities_Label.Size = new System.Drawing.Size(107, 13);
            this.Dangerous_Activities_Label.TabIndex = 45;
            this.Dangerous_Activities_Label.Text = "Dangerous Activities:";
            // 
            // Hospitalized_Label
            // 
            this.Hospitalized_Label.AutoSize = true;
            this.Hospitalized_Label.Location = new System.Drawing.Point(231, 465);
            this.Hospitalized_Label.Name = "Hospitalized_Label";
            this.Hospitalized_Label.Size = new System.Drawing.Size(67, 13);
            this.Hospitalized_Label.TabIndex = 44;
            this.Hospitalized_Label.Text = "Hospitalized:";
            // 
            // Cancer_Label
            // 
            this.Cancer_Label.AutoSize = true;
            this.Cancer_Label.Location = new System.Drawing.Point(254, 441);
            this.Cancer_Label.Name = "Cancer_Label";
            this.Cancer_Label.Size = new System.Drawing.Size(44, 13);
            this.Cancer_Label.TabIndex = 43;
            this.Cancer_Label.Text = "Cancer:";
            // 
            // Heart_Disease_Label
            // 
            this.Heart_Disease_Label.AutoSize = true;
            this.Heart_Disease_Label.Location = new System.Drawing.Point(221, 416);
            this.Heart_Disease_Label.Name = "Heart_Disease_Label";
            this.Heart_Disease_Label.Size = new System.Drawing.Size(77, 13);
            this.Heart_Disease_Label.TabIndex = 42;
            this.Heart_Disease_Label.Text = "Heart Disease:";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(157, 389);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(141, 13);
            this.s.TabIndex = 41;
            this.s.Text = "Average Grams Fat per Day:";
            // 
            // Systolic_Blood_Pressure_Label
            // 
            this.Systolic_Blood_Pressure_Label.AutoSize = true;
            this.Systolic_Blood_Pressure_Label.Location = new System.Drawing.Point(178, 363);
            this.Systolic_Blood_Pressure_Label.Name = "Systolic_Blood_Pressure_Label";
            this.Systolic_Blood_Pressure_Label.Size = new System.Drawing.Size(120, 13);
            this.Systolic_Blood_Pressure_Label.TabIndex = 40;
            this.Systolic_Blood_Pressure_Label.Text = "Systolic Blood Pressure:";
            // 
            // Cigs_Per_Day_Label
            // 
            this.Cigs_Per_Day_Label.AutoSize = true;
            this.Cigs_Per_Day_Label.Location = new System.Drawing.Point(228, 337);
            this.Cigs_Per_Day_Label.Name = "Cigs_Per_Day_Label";
            this.Cigs_Per_Day_Label.Size = new System.Drawing.Size(70, 13);
            this.Cigs_Per_Day_Label.TabIndex = 39;
            this.Cigs_Per_Day_Label.Text = "Cigs per Day:";
            // 
            // Smoking_History_Label
            // 
            this.Smoking_History_Label.AutoSize = true;
            this.Smoking_History_Label.Location = new System.Drawing.Point(212, 313);
            this.Smoking_History_Label.Name = "Smoking_History_Label";
            this.Smoking_History_Label.Size = new System.Drawing.Size(86, 13);
            this.Smoking_History_Label.TabIndex = 38;
            this.Smoking_History_Label.Text = "Smoking History:";
            // 
            // Mother_Age_At_Death_Label
            // 
            this.Mother_Age_At_Death_Label.AutoSize = true;
            this.Mother_Age_At_Death_Label.Location = new System.Drawing.Point(182, 288);
            this.Mother_Age_At_Death_Label.Name = "Mother_Age_At_Death_Label";
            this.Mother_Age_At_Death_Label.Size = new System.Drawing.Size(116, 13);
            this.Mother_Age_At_Death_Label.TabIndex = 37;
            this.Mother_Age_At_Death_Label.Text = "Mother\'s Age at Death:";
            // 
            // Father_Age_At_Death_Label
            // 
            this.Father_Age_At_Death_Label.AutoSize = true;
            this.Father_Age_At_Death_Label.Location = new System.Drawing.Point(186, 261);
            this.Father_Age_At_Death_Label.Name = "Father_Age_At_Death_Label";
            this.Father_Age_At_Death_Label.Size = new System.Drawing.Size(113, 13);
            this.Father_Age_At_Death_Label.TabIndex = 36;
            this.Father_Age_At_Death_Label.Text = "Father\'s Age at Death:";
            // 
            // Policyholder_DOB_Label
            // 
            this.Policyholder_DOB_Label.AutoSize = true;
            this.Policyholder_DOB_Label.Location = new System.Drawing.Point(163, 236);
            this.Policyholder_DOB_Label.Name = "Policyholder_DOB_Label";
            this.Policyholder_DOB_Label.Size = new System.Drawing.Size(136, 13);
            this.Policyholder_DOB_Label.TabIndex = 35;
            this.Policyholder_DOB_Label.Text = "Policyholder\'s Date of Birth:";
            // 
            // Address_Zip_Label
            // 
            this.Address_Zip_Label.AutoSize = true;
            this.Address_Zip_Label.Location = new System.Drawing.Point(233, 213);
            this.Address_Zip_Label.Name = "Address_Zip_Label";
            this.Address_Zip_Label.Size = new System.Drawing.Size(66, 13);
            this.Address_Zip_Label.TabIndex = 34;
            this.Address_Zip_Label.Text = "Address Zip:";
            // 
            // Address_State_Label
            // 
            this.Address_State_Label.AutoSize = true;
            this.Address_State_Label.Location = new System.Drawing.Point(223, 188);
            this.Address_State_Label.Name = "Address_State_Label";
            this.Address_State_Label.Size = new System.Drawing.Size(76, 13);
            this.Address_State_Label.TabIndex = 33;
            this.Address_State_Label.Text = "Address State:\r\n";
            // 
            // Address_City_Label
            // 
            this.Address_City_Label.AutoSize = true;
            this.Address_City_Label.Location = new System.Drawing.Point(230, 166);
            this.Address_City_Label.Name = "Address_City_Label";
            this.Address_City_Label.Size = new System.Drawing.Size(68, 13);
            this.Address_City_Label.TabIndex = 32;
            this.Address_City_Label.Text = "Address City:";
            // 
            // Address_Street_Label
            // 
            this.Address_Street_Label.AutoSize = true;
            this.Address_Street_Label.Location = new System.Drawing.Point(219, 143);
            this.Address_Street_Label.Name = "Address_Street_Label";
            this.Address_Street_Label.Size = new System.Drawing.Size(79, 13);
            this.Address_Street_Label.TabIndex = 31;
            this.Address_Street_Label.Text = "Address Street:";
            // 
            // Policyholder_Last_Name_Label
            // 
            this.Policyholder_Last_Name_Label.AutoSize = true;
            this.Policyholder_Last_Name_Label.Location = new System.Drawing.Point(178, 118);
            this.Policyholder_Last_Name_Label.Name = "Policyholder_Last_Name_Label";
            this.Policyholder_Last_Name_Label.Size = new System.Drawing.Size(121, 13);
            this.Policyholder_Last_Name_Label.TabIndex = 30;
            this.Policyholder_Last_Name_Label.Text = "Policyholder Last Name:";
            // 
            // Policyholder_First_Name_Label
            // 
            this.Policyholder_First_Name_Label.AutoSize = true;
            this.Policyholder_First_Name_Label.Location = new System.Drawing.Point(179, 92);
            this.Policyholder_First_Name_Label.Name = "Policyholder_First_Name_Label";
            this.Policyholder_First_Name_Label.Size = new System.Drawing.Size(120, 13);
            this.Policyholder_First_Name_Label.TabIndex = 29;
            this.Policyholder_First_Name_Label.Text = "Policyholder First Name:";
            // 
            // Policy_Number_Label
            // 
            this.Policy_Number_Label.AutoSize = true;
            this.Policy_Number_Label.Location = new System.Drawing.Point(221, 69);
            this.Policy_Number_Label.Name = "Policy_Number_Label";
            this.Policy_Number_Label.Size = new System.Drawing.Size(78, 13);
            this.Policy_Number_Label.TabIndex = 28;
            this.Policy_Number_Label.Text = "Policy Number:";
            // 
            // Update_Policy_Label
            // 
            this.Update_Policy_Label.AutoSize = true;
            this.Update_Policy_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Policy_Label.Location = new System.Drawing.Point(331, 39);
            this.Update_Policy_Label.Name = "Update_Policy_Label";
            this.Update_Policy_Label.Size = new System.Drawing.Size(86, 13);
            this.Update_Policy_Label.TabIndex = 56;
            this.Update_Policy_Label.Text = "Update Policy";
            // 
            // Policyholder_First_Name_textBox
            // 
            this.Policyholder_First_Name_textBox.Location = new System.Drawing.Point(305, 89);
            this.Policyholder_First_Name_textBox.Name = "Policyholder_First_Name_textBox";
            this.Policyholder_First_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policyholder_First_Name_textBox.TabIndex = 57;
            // 
            // Policyholder_Last_Name_textBox
            // 
            this.Policyholder_Last_Name_textBox.Location = new System.Drawing.Point(305, 114);
            this.Policyholder_Last_Name_textBox.Name = "Policyholder_Last_Name_textBox";
            this.Policyholder_Last_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policyholder_Last_Name_textBox.TabIndex = 58;
            // 
            // Address_Street_textBox
            // 
            this.Address_Street_textBox.Location = new System.Drawing.Point(305, 137);
            this.Address_Street_textBox.Name = "Address_Street_textBox";
            this.Address_Street_textBox.Size = new System.Drawing.Size(238, 20);
            this.Address_Street_textBox.TabIndex = 59;
            // 
            // Address_City_textBox
            // 
            this.Address_City_textBox.Location = new System.Drawing.Point(304, 162);
            this.Address_City_textBox.Name = "Address_City_textBox";
            this.Address_City_textBox.Size = new System.Drawing.Size(238, 20);
            this.Address_City_textBox.TabIndex = 60;
            // 
            // Address_Zip_textBox
            // 
            this.Address_Zip_textBox.Location = new System.Drawing.Point(305, 210);
            this.Address_Zip_textBox.Name = "Address_Zip_textBox";
            this.Address_Zip_textBox.Size = new System.Drawing.Size(238, 20);
            this.Address_Zip_textBox.TabIndex = 62;
            // 
            // Beneficiary_First_Name_textBox
            // 
            this.Beneficiary_First_Name_textBox.Location = new System.Drawing.Point(304, 705);
            this.Beneficiary_First_Name_textBox.Name = "Beneficiary_First_Name_textBox";
            this.Beneficiary_First_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Beneficiary_First_Name_textBox.TabIndex = 63;
            // 
            // Beneficiary_Last_Name_textBox
            // 
            this.Beneficiary_Last_Name_textBox.Location = new System.Drawing.Point(305, 730);
            this.Beneficiary_Last_Name_textBox.Name = "Beneficiary_Last_Name_textBox";
            this.Beneficiary_Last_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Beneficiary_Last_Name_textBox.TabIndex = 64;
            this.Beneficiary_Last_Name_textBox.TextChanged += new System.EventHandler(this.Beneficiary_Last_Name_textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(257, 774);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 65;
            this.button1.Text = "Submit Changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(488, 774);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 66;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Address_State_dropDown_Menu
            // 
            this.Address_State_dropDown_Menu.AllowDrop = true;
            this.Address_State_dropDown_Menu.AutoCompleteCustomSource.AddRange(new string[] {
            "No Region Specified",
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.Address_State_dropDown_Menu.FormattingEnabled = true;
            this.Address_State_dropDown_Menu.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "No Region Specified",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.Address_State_dropDown_Menu.Location = new System.Drawing.Point(304, 185);
            this.Address_State_dropDown_Menu.Name = "Address_State_dropDown_Menu";
            this.Address_State_dropDown_Menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Address_State_dropDown_Menu.Size = new System.Drawing.Size(239, 21);
            this.Address_State_dropDown_Menu.TabIndex = 68;
            // 
            // UpdatePolicy
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(763, 749);
            this.Controls.Add(this.Address_State_dropDown_Menu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Beneficiary_Last_Name_textBox);
            this.Controls.Add(this.Beneficiary_First_Name_textBox);
            this.Controls.Add(this.Address_Zip_textBox);
            this.Controls.Add(this.Address_City_textBox);
            this.Controls.Add(this.Address_Street_textBox);
            this.Controls.Add(this.Policyholder_Last_Name_textBox);
            this.Controls.Add(this.Policyholder_First_Name_textBox);
            this.Controls.Add(this.Update_Policy_Label);
            this.Controls.Add(this.Beneficiary_Last_Name_Label);
            this.Controls.Add(this.Beneficiary_First_Name_Label);
            this.Controls.Add(this.Monthly_Premium_Label);
            this.Controls.Add(this.Payoff_Amount_Label);
            this.Controls.Add(this.Agent_Last_Name_Label);
            this.Controls.Add(this.Agent_First_Name_Label);
            this.Controls.Add(this.Agent_Number_Label);
            this.Controls.Add(this.Policy_End_Date_Label);
            this.Controls.Add(this.Policy_Start_Date_Label);
            this.Controls.Add(this.Hours_Of_Exercise_Per_Week_Label);
            this.Controls.Add(this.Dangerous_Activities_Label);
            this.Controls.Add(this.Hospitalized_Label);
            this.Controls.Add(this.Cancer_Label);
            this.Controls.Add(this.Heart_Disease_Label);
            this.Controls.Add(this.s);
            this.Controls.Add(this.Systolic_Blood_Pressure_Label);
            this.Controls.Add(this.Cigs_Per_Day_Label);
            this.Controls.Add(this.Smoking_History_Label);
            this.Controls.Add(this.Mother_Age_At_Death_Label);
            this.Controls.Add(this.Father_Age_At_Death_Label);
            this.Controls.Add(this.Policyholder_DOB_Label);
            this.Controls.Add(this.Address_Zip_Label);
            this.Controls.Add(this.Address_State_Label);
            this.Controls.Add(this.Address_City_Label);
            this.Controls.Add(this.Address_Street_Label);
            this.Controls.Add(this.Policyholder_Last_Name_Label);
            this.Controls.Add(this.Policyholder_First_Name_Label);
            this.Controls.Add(this.Policy_Number_Label);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "UpdatePolicy";
            this.Text = "UpdatePolicy";
            this.Load += new System.EventHandler(this.UpdatePolicy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Beneficiary_Last_Name_Label;
        private Label Beneficiary_First_Name_Label;
        private Label Monthly_Premium_Label;
        private Label Payoff_Amount_Label;
        private Label Agent_Last_Name_Label;
        private Label Agent_First_Name_Label;
        private Label Agent_Number_Label;
        private Label Policy_End_Date_Label;
        private Label Policy_Start_Date_Label;
        private Label Hours_Of_Exercise_Per_Week_Label;
        private Label Dangerous_Activities_Label;
        private Label Hospitalized_Label;
        private Label Cancer_Label;
        private Label Heart_Disease_Label;
        private Label s;
        private Label Systolic_Blood_Pressure_Label;
        private Label Cigs_Per_Day_Label;
        private Label Smoking_History_Label;
        private Label Mother_Age_At_Death_Label;
        private Label Father_Age_At_Death_Label;
        private Label Policyholder_DOB_Label;
        private Label Address_Zip_Label;
        private Label Address_State_Label;
        private Label Address_City_Label;
        private Label Address_Street_Label;
        private Label Policyholder_Last_Name_Label;
        private Label Policyholder_First_Name_Label;
        private Label Policy_Number_Label;
        private Label Update_Policy_Label;
        private TextBox Policyholder_First_Name_textBox;
        private TextBox Policyholder_Last_Name_textBox;
        private TextBox Address_Street_textBox;
        private TextBox Address_City_textBox;
        private TextBox Address_Zip_textBox;
        private TextBox Beneficiary_First_Name_textBox;
        private TextBox Beneficiary_Last_Name_textBox;
        private Button button1;
        private Button button2;
        private ComboBox Address_State_dropDown_Menu;
    }
}