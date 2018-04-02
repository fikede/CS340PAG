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
            this.Beneficiary_Last_Name = new System.Windows.Forms.Label();
            this.Beneficiary_First_Name = new System.Windows.Forms.Label();
            this.Monthly_Premium = new System.Windows.Forms.Label();
            this.Payoff_Amount = new System.Windows.Forms.Label();
            this.Agent_Last_Name = new System.Windows.Forms.Label();
            this.Agent_First_Name = new System.Windows.Forms.Label();
            this.Agent_Number = new System.Windows.Forms.Label();
            this.Policy_End_Date = new System.Windows.Forms.Label();
            this.Policy_Start_Date = new System.Windows.Forms.Label();
            this.Hours_of_Exercise_per_Week = new System.Windows.Forms.Label();
            this.Dangerous_Activities = new System.Windows.Forms.Label();
            this.Hospitalized = new System.Windows.Forms.Label();
            this.Cancer = new System.Windows.Forms.Label();
            this.Heart_Disease = new System.Windows.Forms.Label();
            this.Average_Grams_Fat_Per_Day = new System.Windows.Forms.Label();
            this.Systolic_Blood_Pressure = new System.Windows.Forms.Label();
            this.Cigs_per_Day = new System.Windows.Forms.Label();
            this.Smoking_History = new System.Windows.Forms.Label();
            this.Mother_Age_at_Death = new System.Windows.Forms.Label();
            this.Father_Age_at_Death = new System.Windows.Forms.Label();
            this.Policyholder_DOB = new System.Windows.Forms.Label();
            this.Address_Zip = new System.Windows.Forms.Label();
            this.Address_State = new System.Windows.Forms.Label();
            this.Address_City = new System.Windows.Forms.Label();
            this.Address_Street = new System.Windows.Forms.Label();
            this.Policyholder_Last_Name = new System.Windows.Forms.Label();
            this.Policyholder_First_Name = new System.Windows.Forms.Label();
            this.Policy_Number = new System.Windows.Forms.Label();
            this.Policyholder_First_Name_textBox = new System.Windows.Forms.TextBox();
            this.Policyholder_Last_Name_textBox = new System.Windows.Forms.TextBox();
            this.Address_Street_textBox = new System.Windows.Forms.TextBox();
            this.Address_City_textBox = new System.Windows.Forms.TextBox();
            this.Address_Zip_textBox = new System.Windows.Forms.TextBox();
            this.Beneficiary_First_Name_textBox = new System.Windows.Forms.TextBox();
            this.Beneficiary_Last_Name_textBox = new System.Windows.Forms.TextBox();
            this.Policyholder_Number = new System.Windows.Forms.Label();
            this.Address_State_dropDown_Menu = new System.Windows.Forms.ComboBox();
            this.Add_Policy_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Beneficiary_Last_Name
            // 
            this.Beneficiary_Last_Name.AutoSize = true;
            this.Beneficiary_Last_Name.Location = new System.Drawing.Point(199, 688);
            this.Beneficiary_Last_Name.Name = "Beneficiary_Last_Name";
            this.Beneficiary_Last_Name.Size = new System.Drawing.Size(116, 13);
            this.Beneficiary_Last_Name.TabIndex = 55;
            this.Beneficiary_Last_Name.Text = "Beneficiary Last Name:";
            // 
            // Beneficiary_First_Name
            // 
            this.Beneficiary_First_Name.AutoSize = true;
            this.Beneficiary_First_Name.Location = new System.Drawing.Point(200, 665);
            this.Beneficiary_First_Name.Name = "Beneficiary_First_Name";
            this.Beneficiary_First_Name.Size = new System.Drawing.Size(115, 13);
            this.Beneficiary_First_Name.TabIndex = 54;
            this.Beneficiary_First_Name.Text = "Beneficiary First Name:";
            // 
            // Monthly_Premium
            // 
            this.Monthly_Premium.AutoSize = true;
            this.Monthly_Premium.Location = new System.Drawing.Point(225, 642);
            this.Monthly_Premium.Name = "Monthly_Premium";
            this.Monthly_Premium.Size = new System.Drawing.Size(90, 13);
            this.Monthly_Premium.TabIndex = 53;
            this.Monthly_Premium.Text = "Monthly Premium:";
            // 
            // Payoff_Amount
            // 
            this.Payoff_Amount.AutoSize = true;
            this.Payoff_Amount.Location = new System.Drawing.Point(236, 619);
            this.Payoff_Amount.Name = "Payoff_Amount";
            this.Payoff_Amount.Size = new System.Drawing.Size(79, 13);
            this.Payoff_Amount.TabIndex = 52;
            this.Payoff_Amount.Text = "Payoff Amount:";
            // 
            // Agent_Last_Name
            // 
            this.Agent_Last_Name.AutoSize = true;
            this.Agent_Last_Name.Location = new System.Drawing.Point(223, 596);
            this.Agent_Last_Name.Name = "Agent_Last_Name";
            this.Agent_Last_Name.Size = new System.Drawing.Size(92, 13);
            this.Agent_Last_Name.TabIndex = 51;
            this.Agent_Last_Name.Text = "Agent Last Name:";
            // 
            // Agent_First_Name
            // 
            this.Agent_First_Name.AutoSize = true;
            this.Agent_First_Name.Location = new System.Drawing.Point(224, 573);
            this.Agent_First_Name.Name = "Agent_First_Name";
            this.Agent_First_Name.Size = new System.Drawing.Size(91, 13);
            this.Agent_First_Name.TabIndex = 50;
            this.Agent_First_Name.Text = "Agent First Name:";
            // 
            // Agent_Number
            // 
            this.Agent_Number.AutoSize = true;
            this.Agent_Number.Location = new System.Drawing.Point(237, 550);
            this.Agent_Number.Name = "Agent_Number";
            this.Agent_Number.Size = new System.Drawing.Size(78, 13);
            this.Agent_Number.TabIndex = 49;
            this.Agent_Number.Text = "Agent Number:";
            // 
            // Policy_End_Date
            // 
            this.Policy_End_Date.AutoSize = true;
            this.Policy_End_Date.Location = new System.Drawing.Point(229, 527);
            this.Policy_End_Date.Name = "Policy_End_Date";
            this.Policy_End_Date.Size = new System.Drawing.Size(86, 13);
            this.Policy_End_Date.TabIndex = 48;
            this.Policy_End_Date.Text = "Policy End Date:";
            // 
            // Policy_Start_Date
            // 
            this.Policy_Start_Date.AutoSize = true;
            this.Policy_Start_Date.Location = new System.Drawing.Point(226, 504);
            this.Policy_Start_Date.Name = "Policy_Start_Date";
            this.Policy_Start_Date.Size = new System.Drawing.Size(89, 13);
            this.Policy_Start_Date.TabIndex = 47;
            this.Policy_Start_Date.Text = "Policy Start Date:";
            // 
            // Hours_of_Exercise_per_Week
            // 
            this.Hours_of_Exercise_per_Week.AutoSize = true;
            this.Hours_of_Exercise_per_Week.Location = new System.Drawing.Point(172, 481);
            this.Hours_of_Exercise_per_Week.Name = "Hours_of_Exercise_per_Week";
            this.Hours_of_Exercise_per_Week.Size = new System.Drawing.Size(143, 13);
            this.Hours_of_Exercise_per_Week.TabIndex = 46;
            this.Hours_of_Exercise_per_Week.Text = "Hours of Exercise per Week:";
            // 
            // Dangerous_Activities
            // 
            this.Dangerous_Activities.AutoSize = true;
            this.Dangerous_Activities.Location = new System.Drawing.Point(208, 458);
            this.Dangerous_Activities.Name = "Dangerous_Activities";
            this.Dangerous_Activities.Size = new System.Drawing.Size(107, 13);
            this.Dangerous_Activities.TabIndex = 45;
            this.Dangerous_Activities.Text = "Dangerous Activities:";
            // 
            // Hospitalized
            // 
            this.Hospitalized.AutoSize = true;
            this.Hospitalized.Location = new System.Drawing.Point(248, 435);
            this.Hospitalized.Name = "Hospitalized";
            this.Hospitalized.Size = new System.Drawing.Size(67, 13);
            this.Hospitalized.TabIndex = 44;
            this.Hospitalized.Text = "Hospitalized:";
            // 
            // Cancer
            // 
            this.Cancer.AutoSize = true;
            this.Cancer.Location = new System.Drawing.Point(271, 412);
            this.Cancer.Name = "Cancer";
            this.Cancer.Size = new System.Drawing.Size(44, 13);
            this.Cancer.TabIndex = 43;
            this.Cancer.Text = "Cancer:";
            // 
            // Heart_Disease
            // 
            this.Heart_Disease.AutoSize = true;
            this.Heart_Disease.Location = new System.Drawing.Point(238, 389);
            this.Heart_Disease.Name = "Heart_Disease";
            this.Heart_Disease.Size = new System.Drawing.Size(77, 13);
            this.Heart_Disease.TabIndex = 42;
            this.Heart_Disease.Text = "Heart Disease:";
            // 
            // Average_Grams_Fat_Per_Day
            // 
            this.Average_Grams_Fat_Per_Day.AutoSize = true;
            this.Average_Grams_Fat_Per_Day.Location = new System.Drawing.Point(174, 366);
            this.Average_Grams_Fat_Per_Day.Name = "Average_Grams_Fat_Per_Day";
            this.Average_Grams_Fat_Per_Day.Size = new System.Drawing.Size(141, 13);
            this.Average_Grams_Fat_Per_Day.TabIndex = 41;
            this.Average_Grams_Fat_Per_Day.Text = "Average Grams Fat per Day:";
            // 
            // Systolic_Blood_Pressure
            // 
            this.Systolic_Blood_Pressure.AutoSize = true;
            this.Systolic_Blood_Pressure.Location = new System.Drawing.Point(195, 343);
            this.Systolic_Blood_Pressure.Name = "Systolic_Blood_Pressure";
            this.Systolic_Blood_Pressure.Size = new System.Drawing.Size(120, 13);
            this.Systolic_Blood_Pressure.TabIndex = 40;
            this.Systolic_Blood_Pressure.Text = "Systolic Blood Pressure:";
            // 
            // Cigs_per_Day
            // 
            this.Cigs_per_Day.AutoSize = true;
            this.Cigs_per_Day.Location = new System.Drawing.Point(245, 320);
            this.Cigs_per_Day.Name = "Cigs_per_Day";
            this.Cigs_per_Day.Size = new System.Drawing.Size(70, 13);
            this.Cigs_per_Day.TabIndex = 39;
            this.Cigs_per_Day.Text = "Cigs per Day:";
            // 
            // Smoking_History
            // 
            this.Smoking_History.AutoSize = true;
            this.Smoking_History.Location = new System.Drawing.Point(229, 297);
            this.Smoking_History.Name = "Smoking_History";
            this.Smoking_History.Size = new System.Drawing.Size(86, 13);
            this.Smoking_History.TabIndex = 38;
            this.Smoking_History.Text = "Smoking History:";
            // 
            // Mother_Age_at_Death
            // 
            this.Mother_Age_at_Death.AutoSize = true;
            this.Mother_Age_at_Death.Location = new System.Drawing.Point(199, 274);
            this.Mother_Age_at_Death.Name = "Mother_Age_at_Death";
            this.Mother_Age_at_Death.Size = new System.Drawing.Size(116, 13);
            this.Mother_Age_at_Death.TabIndex = 37;
            this.Mother_Age_at_Death.Text = "Mother\'s Age at Death:";
            // 
            // Father_Age_at_Death
            // 
            this.Father_Age_at_Death.AutoSize = true;
            this.Father_Age_at_Death.Location = new System.Drawing.Point(202, 251);
            this.Father_Age_at_Death.Name = "Father_Age_at_Death";
            this.Father_Age_at_Death.Size = new System.Drawing.Size(113, 13);
            this.Father_Age_at_Death.TabIndex = 36;
            this.Father_Age_at_Death.Text = "Father\'s Age at Death:";
            // 
            // Policyholder_DOB
            // 
            this.Policyholder_DOB.AutoSize = true;
            this.Policyholder_DOB.Location = new System.Drawing.Point(179, 228);
            this.Policyholder_DOB.Name = "Policyholder_DOB";
            this.Policyholder_DOB.Size = new System.Drawing.Size(136, 13);
            this.Policyholder_DOB.TabIndex = 35;
            this.Policyholder_DOB.Text = "Policyholder\'s Date of Birth:";
            // 
            // Address_Zip
            // 
            this.Address_Zip.AutoSize = true;
            this.Address_Zip.Location = new System.Drawing.Point(249, 205);
            this.Address_Zip.Name = "Address_Zip";
            this.Address_Zip.Size = new System.Drawing.Size(66, 13);
            this.Address_Zip.TabIndex = 34;
            this.Address_Zip.Text = "Address Zip:";
            // 
            // Address_State
            // 
            this.Address_State.AutoSize = true;
            this.Address_State.Location = new System.Drawing.Point(239, 182);
            this.Address_State.Name = "Address_State";
            this.Address_State.Size = new System.Drawing.Size(76, 13);
            this.Address_State.TabIndex = 33;
            this.Address_State.Text = "Address State:\r\n";
            // 
            // Address_City
            // 
            this.Address_City.AutoSize = true;
            this.Address_City.Location = new System.Drawing.Point(247, 159);
            this.Address_City.Name = "Address_City";
            this.Address_City.Size = new System.Drawing.Size(68, 13);
            this.Address_City.TabIndex = 32;
            this.Address_City.Text = "Address City:";
            // 
            // Address_Street
            // 
            this.Address_Street.AutoSize = true;
            this.Address_Street.Location = new System.Drawing.Point(236, 136);
            this.Address_Street.Name = "Address_Street";
            this.Address_Street.Size = new System.Drawing.Size(79, 13);
            this.Address_Street.TabIndex = 31;
            this.Address_Street.Text = "Address Street:";
            // 
            // Policyholder_Last_Name
            // 
            this.Policyholder_Last_Name.AutoSize = true;
            this.Policyholder_Last_Name.Location = new System.Drawing.Point(194, 90);
            this.Policyholder_Last_Name.Name = "Policyholder_Last_Name";
            this.Policyholder_Last_Name.Size = new System.Drawing.Size(121, 13);
            this.Policyholder_Last_Name.TabIndex = 30;
            this.Policyholder_Last_Name.Text = "Policyholder Last Name:";
            // 
            // Policyholder_First_Name
            // 
            this.Policyholder_First_Name.AutoSize = true;
            this.Policyholder_First_Name.Location = new System.Drawing.Point(195, 67);
            this.Policyholder_First_Name.Name = "Policyholder_First_Name";
            this.Policyholder_First_Name.Size = new System.Drawing.Size(120, 13);
            this.Policyholder_First_Name.TabIndex = 29;
            this.Policyholder_First_Name.Text = "Policyholder First Name:";
            this.Policyholder_First_Name.Click += new System.EventHandler(this.Policyholder_First_Name_Click);
            // 
            // Policy_Number
            // 
            this.Policy_Number.AutoSize = true;
            this.Policy_Number.Location = new System.Drawing.Point(237, 44);
            this.Policy_Number.Name = "Policy_Number";
            this.Policy_Number.Size = new System.Drawing.Size(78, 13);
            this.Policy_Number.TabIndex = 28;
            this.Policy_Number.Text = "Policy Number:";
            // 
            // Policyholder_First_Name_textBox
            // 
            this.Policyholder_First_Name_textBox.Location = new System.Drawing.Point(321, 64);
            this.Policyholder_First_Name_textBox.Name = "Policyholder_First_Name_textBox";
            this.Policyholder_First_Name_textBox.Size = new System.Drawing.Size(293, 20);
            this.Policyholder_First_Name_textBox.TabIndex = 56;
            this.Policyholder_First_Name_textBox.TextChanged += new System.EventHandler(this.Policyholder_First_Name_textBox_TextChanged);
            // 
            // Policyholder_Last_Name_textBox
            // 
            this.Policyholder_Last_Name_textBox.Location = new System.Drawing.Point(321, 87);
            this.Policyholder_Last_Name_textBox.Name = "Policyholder_Last_Name_textBox";
            this.Policyholder_Last_Name_textBox.Size = new System.Drawing.Size(293, 20);
            this.Policyholder_Last_Name_textBox.TabIndex = 57;
            // 
            // Address_Street_textBox
            // 
            this.Address_Street_textBox.Location = new System.Drawing.Point(321, 133);
            this.Address_Street_textBox.Name = "Address_Street_textBox";
            this.Address_Street_textBox.Size = new System.Drawing.Size(293, 20);
            this.Address_Street_textBox.TabIndex = 58;
            // 
            // Address_City_textBox
            // 
            this.Address_City_textBox.Location = new System.Drawing.Point(321, 156);
            this.Address_City_textBox.Name = "Address_City_textBox";
            this.Address_City_textBox.Size = new System.Drawing.Size(293, 20);
            this.Address_City_textBox.TabIndex = 59;
            // 
            // Address_Zip_textBox
            // 
            this.Address_Zip_textBox.Location = new System.Drawing.Point(321, 202);
            this.Address_Zip_textBox.Name = "Address_Zip_textBox";
            this.Address_Zip_textBox.Size = new System.Drawing.Size(293, 20);
            this.Address_Zip_textBox.TabIndex = 60;
            // 
            // Beneficiary_First_Name_textBox
            // 
            this.Beneficiary_First_Name_textBox.Location = new System.Drawing.Point(321, 662);
            this.Beneficiary_First_Name_textBox.Name = "Beneficiary_First_Name_textBox";
            this.Beneficiary_First_Name_textBox.Size = new System.Drawing.Size(293, 20);
            this.Beneficiary_First_Name_textBox.TabIndex = 61;
            // 
            // Beneficiary_Last_Name_textBox
            // 
            this.Beneficiary_Last_Name_textBox.Location = new System.Drawing.Point(321, 685);
            this.Beneficiary_Last_Name_textBox.Name = "Beneficiary_Last_Name_textBox";
            this.Beneficiary_Last_Name_textBox.Size = new System.Drawing.Size(293, 20);
            this.Beneficiary_Last_Name_textBox.TabIndex = 62;
            // 
            // Policyholder_Number
            // 
            this.Policyholder_Number.AutoSize = true;
            this.Policyholder_Number.Location = new System.Drawing.Point(208, 113);
            this.Policyholder_Number.Name = "Policyholder_Number";
            this.Policyholder_Number.Size = new System.Drawing.Size(107, 13);
            this.Policyholder_Number.TabIndex = 63;
            this.Policyholder_Number.Text = "Policyholder Number:";
            // 
            // Address_State_dropDown_Menu
            // 
            this.Address_State_dropDown_Menu.FormattingEnabled = true;
            this.Address_State_dropDown_Menu.Location = new System.Drawing.Point(321, 179);
            this.Address_State_dropDown_Menu.Name = "Address_State_dropDown_Menu";
            this.Address_State_dropDown_Menu.Size = new System.Drawing.Size(293, 21);
            this.Address_State_dropDown_Menu.TabIndex = 64;
            // 
            // Add_Policy_Label
            // 
            this.Add_Policy_Label.AutoSize = true;
            this.Add_Policy_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Policy_Label.Location = new System.Drawing.Point(303, 20);
            this.Add_Policy_Label.Name = "Add_Policy_Label";
            this.Add_Policy_Label.Size = new System.Drawing.Size(67, 13);
            this.Add_Policy_Label.TabIndex = 65;
            this.Add_Policy_Label.Text = "Add Policy";
            this.Add_Policy_Label.Click += new System.EventHandler(this.label30_Click);
            // 
            // AddPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 784);
            this.Controls.Add(this.Add_Policy_Label);
            this.Controls.Add(this.Address_State_dropDown_Menu);
            this.Controls.Add(this.Policyholder_Number);
            this.Controls.Add(this.Beneficiary_Last_Name_textBox);
            this.Controls.Add(this.Beneficiary_First_Name_textBox);
            this.Controls.Add(this.Address_Zip_textBox);
            this.Controls.Add(this.Address_City_textBox);
            this.Controls.Add(this.Address_Street_textBox);
            this.Controls.Add(this.Policyholder_Last_Name_textBox);
            this.Controls.Add(this.Policyholder_First_Name_textBox);
            this.Controls.Add(this.Beneficiary_Last_Name);
            this.Controls.Add(this.Beneficiary_First_Name);
            this.Controls.Add(this.Monthly_Premium);
            this.Controls.Add(this.Payoff_Amount);
            this.Controls.Add(this.Agent_Last_Name);
            this.Controls.Add(this.Agent_First_Name);
            this.Controls.Add(this.Agent_Number);
            this.Controls.Add(this.Policy_End_Date);
            this.Controls.Add(this.Policy_Start_Date);
            this.Controls.Add(this.Hours_of_Exercise_per_Week);
            this.Controls.Add(this.Dangerous_Activities);
            this.Controls.Add(this.Hospitalized);
            this.Controls.Add(this.Cancer);
            this.Controls.Add(this.Heart_Disease);
            this.Controls.Add(this.Average_Grams_Fat_Per_Day);
            this.Controls.Add(this.Systolic_Blood_Pressure);
            this.Controls.Add(this.Cigs_per_Day);
            this.Controls.Add(this.Smoking_History);
            this.Controls.Add(this.Mother_Age_at_Death);
            this.Controls.Add(this.Father_Age_at_Death);
            this.Controls.Add(this.Policyholder_DOB);
            this.Controls.Add(this.Address_Zip);
            this.Controls.Add(this.Address_State);
            this.Controls.Add(this.Address_City);
            this.Controls.Add(this.Address_Street);
            this.Controls.Add(this.Policyholder_Last_Name);
            this.Controls.Add(this.Policyholder_First_Name);
            this.Controls.Add(this.Policy_Number);
            this.Name = "AddPolicy";
            this.Text = "AddPolicy";
            this.Load += new System.EventHandler(this.AddPolicy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Beneficiary_Last_Name;
        private Label Beneficiary_First_Name;
        private Label Monthly_Premium;
        private Label Payoff_Amount;
        private Label Agent_Last_Name;
        private Label Agent_First_Name;
        private Label Agent_Number;
        private Label Policy_End_Date;
        private Label Policy_Start_Date;
        private Label Hours_of_Exercise_per_Week;
        private Label Dangerous_Activities;
        private Label Hospitalized;
        private Label Cancer;
        private Label Heart_Disease;
        private Label Average_Grams_Fat_Per_Day;
        private Label Systolic_Blood_Pressure;
        private Label Cigs_per_Day;
        private Label Smoking_History;
        private Label Mother_Age_at_Death;
        private Label Father_Age_at_Death;
        private Label Policyholder_DOB;
        private Label Address_Zip;
        private Label Address_State;
        private Label Address_City;
        private Label Address_Street;
        private Label Policyholder_Last_Name;
        private Label Policyholder_First_Name;
        private Label Policy_Number;
        private TextBox Policyholder_First_Name_textBox;
        private TextBox Policyholder_Last_Name_textBox;
        private TextBox Address_Street_textBox;
        private TextBox Address_City_textBox;
        private TextBox Address_Zip_textBox;
        private TextBox Beneficiary_First_Name_textBox;
        private TextBox Beneficiary_Last_Name_textBox;
        private Label Policyholder_Number;
        private ComboBox Address_State_dropDown_Menu;
        private Label Add_Policy_Label;
    }
}