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
            this.Total_Amount_Of_Payment_Per_Month_Label = new System.Windows.Forms.Label();
            this.Payoff_Amount_Label = new System.Windows.Forms.Label();
            this.Hours_Of_Exercise_Per_Week_Label = new System.Windows.Forms.Label();
            this.Dangerous_Activities_Label = new System.Windows.Forms.Label();
            this.Hospitalized_Label = new System.Windows.Forms.Label();
            this.Cancer_Label = new System.Windows.Forms.Label();
            this.Heart_Disease_Label = new System.Windows.Forms.Label();
            this.Average_Grams_Fat_Per_Day_Label = new System.Windows.Forms.Label();
            this.Systolic_Blood_Pressure_Label = new System.Windows.Forms.Label();
            this.Cigs_Per_Day_Label = new System.Windows.Forms.Label();
            this.Smoking_History_Label = new System.Windows.Forms.Label();
            this.Mothers_Age_At_Death_Label = new System.Windows.Forms.Label();
            this.Fathers_Age_At_Death_Label = new System.Windows.Forms.Label();
            this.Policyholder_DOB_Label = new System.Windows.Forms.Label();
            this.Policyholder_DOB_textBox = new System.Windows.Forms.TextBox();
            this.Fathers_Age_At_Death_textBox = new System.Windows.Forms.TextBox();
            this.Mothers_Age_At_Death_textBox = new System.Windows.Forms.TextBox();
            this.Smoking_History_textBox = new System.Windows.Forms.TextBox();
            this.Cigs_Per_Day_textBox = new System.Windows.Forms.TextBox();
            this.Systolic_Blood_Pressure_textBox = new System.Windows.Forms.TextBox();
            this.Average_Grams_Fat_Per_Day_textBox = new System.Windows.Forms.TextBox();
            this.Dangerous_Activities_textBox = new System.Windows.Forms.TextBox();
            this.Hours_Of_Exercise_Per_Week_textBox = new System.Windows.Forms.TextBox();
            this.Heart_Disease_Yes_radioButton = new System.Windows.Forms.RadioButton();
            this.Heart_Disease_No_radioButton = new System.Windows.Forms.RadioButton();
            this.Cancer_No_radioButton = new System.Windows.Forms.RadioButton();
            this.Cancer_Yes_radioButton = new System.Windows.Forms.RadioButton();
            this.Hospitalized_No_radioButton = new System.Windows.Forms.RadioButton();
            this.Hospitalized_Yes_radioButton = new System.Windows.Forms.RadioButton();
            this.Price_A_Policy_Label = new System.Windows.Forms.Label();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Total_Amount_Of_Payment_Per_Month_Label
            // 
            this.Total_Amount_Of_Payment_Per_Month_Label.AutoSize = true;
            this.Total_Amount_Of_Payment_Per_Month_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Amount_Of_Payment_Per_Month_Label.Location = new System.Drawing.Point(131, 332);
            this.Total_Amount_Of_Payment_Per_Month_Label.Name = "Total_Amount_Of_Payment_Per_Month_Label";
            this.Total_Amount_Of_Payment_Per_Month_Label.Size = new System.Drawing.Size(225, 13);
            this.Total_Amount_Of_Payment_Per_Month_Label.TabIndex = 48;
            this.Total_Amount_Of_Payment_Per_Month_Label.Text = "Total Amount of Payment per Month: $";
            // 
            // Payoff_Amount_Label
            // 
            this.Payoff_Amount_Label.AutoSize = true;
            this.Payoff_Amount_Label.Location = new System.Drawing.Point(277, 309);
            this.Payoff_Amount_Label.Name = "Payoff_Amount_Label";
            this.Payoff_Amount_Label.Size = new System.Drawing.Size(79, 13);
            this.Payoff_Amount_Label.TabIndex = 47;
            this.Payoff_Amount_Label.Text = "Payoff Amount:";
            // 
            // Hours_Of_Exercise_Per_Week_Label
            // 
            this.Hours_Of_Exercise_Per_Week_Label.AutoSize = true;
            this.Hours_Of_Exercise_Per_Week_Label.Location = new System.Drawing.Point(213, 287);
            this.Hours_Of_Exercise_Per_Week_Label.Name = "Hours_Of_Exercise_Per_Week_Label";
            this.Hours_Of_Exercise_Per_Week_Label.Size = new System.Drawing.Size(143, 13);
            this.Hours_Of_Exercise_Per_Week_Label.TabIndex = 46;
            this.Hours_Of_Exercise_Per_Week_Label.Text = "Hours of Exercise per Week:";
            // 
            // Dangerous_Activities_Label
            // 
            this.Dangerous_Activities_Label.AutoSize = true;
            this.Dangerous_Activities_Label.Location = new System.Drawing.Point(249, 265);
            this.Dangerous_Activities_Label.Name = "Dangerous_Activities_Label";
            this.Dangerous_Activities_Label.Size = new System.Drawing.Size(107, 13);
            this.Dangerous_Activities_Label.TabIndex = 45;
            this.Dangerous_Activities_Label.Text = "Dangerous Activities:";
            // 
            // Hospitalized_Label
            // 
            this.Hospitalized_Label.AutoSize = true;
            this.Hospitalized_Label.Location = new System.Drawing.Point(289, 243);
            this.Hospitalized_Label.Name = "Hospitalized_Label";
            this.Hospitalized_Label.Size = new System.Drawing.Size(67, 13);
            this.Hospitalized_Label.TabIndex = 44;
            this.Hospitalized_Label.Text = "Hospitalized:";
            // 
            // Cancer_Label
            // 
            this.Cancer_Label.AutoSize = true;
            this.Cancer_Label.Location = new System.Drawing.Point(312, 221);
            this.Cancer_Label.Name = "Cancer_Label";
            this.Cancer_Label.Size = new System.Drawing.Size(44, 13);
            this.Cancer_Label.TabIndex = 43;
            this.Cancer_Label.Text = "Cancer:";
            // 
            // Heart_Disease_Label
            // 
            this.Heart_Disease_Label.AutoSize = true;
            this.Heart_Disease_Label.Location = new System.Drawing.Point(279, 199);
            this.Heart_Disease_Label.Name = "Heart_Disease_Label";
            this.Heart_Disease_Label.Size = new System.Drawing.Size(77, 13);
            this.Heart_Disease_Label.TabIndex = 42;
            this.Heart_Disease_Label.Text = "Heart Disease:";
            // 
            // Average_Grams_Fat_Per_Day_Label
            // 
            this.Average_Grams_Fat_Per_Day_Label.AutoSize = true;
            this.Average_Grams_Fat_Per_Day_Label.Location = new System.Drawing.Point(215, 177);
            this.Average_Grams_Fat_Per_Day_Label.Name = "Average_Grams_Fat_Per_Day_Label";
            this.Average_Grams_Fat_Per_Day_Label.Size = new System.Drawing.Size(141, 13);
            this.Average_Grams_Fat_Per_Day_Label.TabIndex = 41;
            this.Average_Grams_Fat_Per_Day_Label.Text = "Average Grams Fat per Day:";
            // 
            // Systolic_Blood_Pressure_Label
            // 
            this.Systolic_Blood_Pressure_Label.AutoSize = true;
            this.Systolic_Blood_Pressure_Label.Location = new System.Drawing.Point(236, 155);
            this.Systolic_Blood_Pressure_Label.Name = "Systolic_Blood_Pressure_Label";
            this.Systolic_Blood_Pressure_Label.Size = new System.Drawing.Size(120, 13);
            this.Systolic_Blood_Pressure_Label.TabIndex = 40;
            this.Systolic_Blood_Pressure_Label.Text = "Systolic Blood Pressure:";
            // 
            // Cigs_Per_Day_Label
            // 
            this.Cigs_Per_Day_Label.AutoSize = true;
            this.Cigs_Per_Day_Label.Location = new System.Drawing.Point(286, 133);
            this.Cigs_Per_Day_Label.Name = "Cigs_Per_Day_Label";
            this.Cigs_Per_Day_Label.Size = new System.Drawing.Size(70, 13);
            this.Cigs_Per_Day_Label.TabIndex = 39;
            this.Cigs_Per_Day_Label.Text = "Cigs per Day:";
            // 
            // Smoking_History_Label
            // 
            this.Smoking_History_Label.AutoSize = true;
            this.Smoking_History_Label.Location = new System.Drawing.Point(270, 111);
            this.Smoking_History_Label.Name = "Smoking_History_Label";
            this.Smoking_History_Label.Size = new System.Drawing.Size(86, 13);
            this.Smoking_History_Label.TabIndex = 38;
            this.Smoking_History_Label.Text = "Smoking History:";
            // 
            // Mothers_Age_At_Death_Label
            // 
            this.Mothers_Age_At_Death_Label.AutoSize = true;
            this.Mothers_Age_At_Death_Label.Location = new System.Drawing.Point(240, 89);
            this.Mothers_Age_At_Death_Label.Name = "Mothers_Age_At_Death_Label";
            this.Mothers_Age_At_Death_Label.Size = new System.Drawing.Size(116, 13);
            this.Mothers_Age_At_Death_Label.TabIndex = 37;
            this.Mothers_Age_At_Death_Label.Text = "Mother\'s Age at Death:";
            this.Mothers_Age_At_Death_Label.Click += new System.EventHandler(this.label10_Click);
            // 
            // Fathers_Age_At_Death_Label
            // 
            this.Fathers_Age_At_Death_Label.AutoSize = true;
            this.Fathers_Age_At_Death_Label.Location = new System.Drawing.Point(243, 67);
            this.Fathers_Age_At_Death_Label.Name = "Fathers_Age_At_Death_Label";
            this.Fathers_Age_At_Death_Label.Size = new System.Drawing.Size(113, 13);
            this.Fathers_Age_At_Death_Label.TabIndex = 36;
            this.Fathers_Age_At_Death_Label.Text = "Father\'s Age at Death:";
            // 
            // Policyholder_DOB_Label
            // 
            this.Policyholder_DOB_Label.AutoSize = true;
            this.Policyholder_DOB_Label.Location = new System.Drawing.Point(220, 45);
            this.Policyholder_DOB_Label.Name = "Policyholder_DOB_Label";
            this.Policyholder_DOB_Label.Size = new System.Drawing.Size(136, 13);
            this.Policyholder_DOB_Label.TabIndex = 35;
            this.Policyholder_DOB_Label.Text = "Policyholder\'s Date of Birth:";
            // 
            // Policyholder_DOB_textBox
            // 
            this.Policyholder_DOB_textBox.ForeColor = System.Drawing.Color.Silver;
            this.Policyholder_DOB_textBox.Location = new System.Drawing.Point(362, 42);
            this.Policyholder_DOB_textBox.Name = "Policyholder_DOB_textBox";
            this.Policyholder_DOB_textBox.Size = new System.Drawing.Size(239, 20);
            this.Policyholder_DOB_textBox.TabIndex = 49;
            this.Policyholder_DOB_textBox.Text = "yyyy/mm/dd";
            // 
            // Fathers_Age_At_Death_textBox
            // 
            this.Fathers_Age_At_Death_textBox.ForeColor = System.Drawing.Color.Black;
            this.Fathers_Age_At_Death_textBox.Location = new System.Drawing.Point(362, 64);
            this.Fathers_Age_At_Death_textBox.Name = "Fathers_Age_At_Death_textBox";
            this.Fathers_Age_At_Death_textBox.Size = new System.Drawing.Size(239, 20);
            this.Fathers_Age_At_Death_textBox.TabIndex = 50;
            // 
            // Mothers_Age_At_Death_textBox
            // 
            this.Mothers_Age_At_Death_textBox.ForeColor = System.Drawing.Color.Black;
            this.Mothers_Age_At_Death_textBox.Location = new System.Drawing.Point(362, 86);
            this.Mothers_Age_At_Death_textBox.Name = "Mothers_Age_At_Death_textBox";
            this.Mothers_Age_At_Death_textBox.Size = new System.Drawing.Size(239, 20);
            this.Mothers_Age_At_Death_textBox.TabIndex = 51;
            // 
            // Smoking_History_textBox
            // 
            this.Smoking_History_textBox.ForeColor = System.Drawing.Color.Black;
            this.Smoking_History_textBox.Location = new System.Drawing.Point(362, 108);
            this.Smoking_History_textBox.Name = "Smoking_History_textBox";
            this.Smoking_History_textBox.Size = new System.Drawing.Size(239, 20);
            this.Smoking_History_textBox.TabIndex = 52;
            // 
            // Cigs_Per_Day_textBox
            // 
            this.Cigs_Per_Day_textBox.ForeColor = System.Drawing.Color.Black;
            this.Cigs_Per_Day_textBox.Location = new System.Drawing.Point(362, 130);
            this.Cigs_Per_Day_textBox.Name = "Cigs_Per_Day_textBox";
            this.Cigs_Per_Day_textBox.Size = new System.Drawing.Size(239, 20);
            this.Cigs_Per_Day_textBox.TabIndex = 53;
            // 
            // Systolic_Blood_Pressure_textBox
            // 
            this.Systolic_Blood_Pressure_textBox.ForeColor = System.Drawing.Color.Black;
            this.Systolic_Blood_Pressure_textBox.Location = new System.Drawing.Point(362, 152);
            this.Systolic_Blood_Pressure_textBox.Name = "Systolic_Blood_Pressure_textBox";
            this.Systolic_Blood_Pressure_textBox.Size = new System.Drawing.Size(239, 20);
            this.Systolic_Blood_Pressure_textBox.TabIndex = 54;
            // 
            // Average_Grams_Fat_Per_Day_textBox
            // 
            this.Average_Grams_Fat_Per_Day_textBox.ForeColor = System.Drawing.Color.Black;
            this.Average_Grams_Fat_Per_Day_textBox.Location = new System.Drawing.Point(362, 174);
            this.Average_Grams_Fat_Per_Day_textBox.Name = "Average_Grams_Fat_Per_Day_textBox";
            this.Average_Grams_Fat_Per_Day_textBox.Size = new System.Drawing.Size(239, 20);
            this.Average_Grams_Fat_Per_Day_textBox.TabIndex = 55;
            // 
            // Dangerous_Activities_textBox
            // 
            this.Dangerous_Activities_textBox.ForeColor = System.Drawing.Color.Black;
            this.Dangerous_Activities_textBox.Location = new System.Drawing.Point(362, 262);
            this.Dangerous_Activities_textBox.Name = "Dangerous_Activities_textBox";
            this.Dangerous_Activities_textBox.Size = new System.Drawing.Size(239, 20);
            this.Dangerous_Activities_textBox.TabIndex = 59;
            // 
            // Hours_Of_Exercise_Per_Week_textBox
            // 
            this.Hours_Of_Exercise_Per_Week_textBox.ForeColor = System.Drawing.Color.Black;
            this.Hours_Of_Exercise_Per_Week_textBox.Location = new System.Drawing.Point(362, 284);
            this.Hours_Of_Exercise_Per_Week_textBox.Name = "Hours_Of_Exercise_Per_Week_textBox";
            this.Hours_Of_Exercise_Per_Week_textBox.Size = new System.Drawing.Size(239, 20);
            this.Hours_Of_Exercise_Per_Week_textBox.TabIndex = 60;
            // 
            // Heart_Disease_Yes_radioButton
            // 
            this.Heart_Disease_Yes_radioButton.AutoSize = true;
            this.Heart_Disease_Yes_radioButton.Location = new System.Drawing.Point(370, 197);
            this.Heart_Disease_Yes_radioButton.Name = "Heart_Disease_Yes_radioButton";
            this.Heart_Disease_Yes_radioButton.Size = new System.Drawing.Size(43, 17);
            this.Heart_Disease_Yes_radioButton.TabIndex = 61;
            this.Heart_Disease_Yes_radioButton.TabStop = true;
            this.Heart_Disease_Yes_radioButton.Text = "Yes";
            this.Heart_Disease_Yes_radioButton.UseVisualStyleBackColor = true;
            // 
            // Heart_Disease_No_radioButton
            // 
            this.Heart_Disease_No_radioButton.AutoSize = true;
            this.Heart_Disease_No_radioButton.Location = new System.Drawing.Point(432, 197);
            this.Heart_Disease_No_radioButton.Name = "Heart_Disease_No_radioButton";
            this.Heart_Disease_No_radioButton.Size = new System.Drawing.Size(39, 17);
            this.Heart_Disease_No_radioButton.TabIndex = 62;
            this.Heart_Disease_No_radioButton.TabStop = true;
            this.Heart_Disease_No_radioButton.Text = "No";
            this.Heart_Disease_No_radioButton.UseVisualStyleBackColor = true;
            // 
            // Cancer_No_radioButton
            // 
            this.Cancer_No_radioButton.AutoSize = true;
            this.Cancer_No_radioButton.Location = new System.Drawing.Point(432, 219);
            this.Cancer_No_radioButton.Name = "Cancer_No_radioButton";
            this.Cancer_No_radioButton.Size = new System.Drawing.Size(39, 17);
            this.Cancer_No_radioButton.TabIndex = 64;
            this.Cancer_No_radioButton.TabStop = true;
            this.Cancer_No_radioButton.Text = "No";
            this.Cancer_No_radioButton.UseVisualStyleBackColor = true;
            // 
            // Cancer_Yes_radioButton
            // 
            this.Cancer_Yes_radioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Cancer_Yes_radioButton.AutoSize = true;
            this.Cancer_Yes_radioButton.Location = new System.Drawing.Point(370, 219);
            this.Cancer_Yes_radioButton.Name = "Cancer_Yes_radioButton";
            this.Cancer_Yes_radioButton.Size = new System.Drawing.Size(43, 17);
            this.Cancer_Yes_radioButton.TabIndex = 63;
            this.Cancer_Yes_radioButton.TabStop = true;
            this.Cancer_Yes_radioButton.Text = "Yes";
            this.Cancer_Yes_radioButton.UseVisualStyleBackColor = true;
            // 
            // Hospitalized_No_radioButton
            // 
            this.Hospitalized_No_radioButton.AutoSize = true;
            this.Hospitalized_No_radioButton.Location = new System.Drawing.Point(432, 241);
            this.Hospitalized_No_radioButton.Name = "Hospitalized_No_radioButton";
            this.Hospitalized_No_radioButton.Size = new System.Drawing.Size(39, 17);
            this.Hospitalized_No_radioButton.TabIndex = 66;
            this.Hospitalized_No_radioButton.TabStop = true;
            this.Hospitalized_No_radioButton.Text = "No";
            this.Hospitalized_No_radioButton.UseVisualStyleBackColor = true;
            // 
            // Hospitalized_Yes_radioButton
            // 
            this.Hospitalized_Yes_radioButton.AutoSize = true;
            this.Hospitalized_Yes_radioButton.Location = new System.Drawing.Point(370, 241);
            this.Hospitalized_Yes_radioButton.Name = "Hospitalized_Yes_radioButton";
            this.Hospitalized_Yes_radioButton.Size = new System.Drawing.Size(43, 17);
            this.Hospitalized_Yes_radioButton.TabIndex = 65;
            this.Hospitalized_Yes_radioButton.TabStop = true;
            this.Hospitalized_Yes_radioButton.Text = "Yes";
            this.Hospitalized_Yes_radioButton.UseVisualStyleBackColor = true;
            // 
            // Price_A_Policy_Label
            // 
            this.Price_A_Policy_Label.AutoSize = true;
            this.Price_A_Policy_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_A_Policy_Label.Location = new System.Drawing.Point(328, 16);
            this.Price_A_Policy_Label.Name = "Price_A_Policy_Label";
            this.Price_A_Policy_Label.Size = new System.Drawing.Size(85, 13);
            this.Price_A_Policy_Label.TabIndex = 67;
            this.Price_A_Policy_Label.Text = "Price a Policy";
            this.Price_A_Policy_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Accept_Button
            // 
            this.Accept_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Accept_Button.Location = new System.Drawing.Point(246, 361);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(75, 23);
            this.Accept_Button.TabIndex = 68;
            this.Accept_Button.Text = "Accept";
            this.Accept_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Button.Location = new System.Drawing.Point(464, 361);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 69;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // PricePolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.Price_A_Policy_Label);
            this.Controls.Add(this.Hospitalized_No_radioButton);
            this.Controls.Add(this.Hospitalized_Yes_radioButton);
            this.Controls.Add(this.Cancer_No_radioButton);
            this.Controls.Add(this.Cancer_Yes_radioButton);
            this.Controls.Add(this.Heart_Disease_No_radioButton);
            this.Controls.Add(this.Heart_Disease_Yes_radioButton);
            this.Controls.Add(this.Hours_Of_Exercise_Per_Week_textBox);
            this.Controls.Add(this.Dangerous_Activities_textBox);
            this.Controls.Add(this.Average_Grams_Fat_Per_Day_textBox);
            this.Controls.Add(this.Systolic_Blood_Pressure_textBox);
            this.Controls.Add(this.Cigs_Per_Day_textBox);
            this.Controls.Add(this.Smoking_History_textBox);
            this.Controls.Add(this.Mothers_Age_At_Death_textBox);
            this.Controls.Add(this.Fathers_Age_At_Death_textBox);
            this.Controls.Add(this.Policyholder_DOB_textBox);
            this.Controls.Add(this.Total_Amount_Of_Payment_Per_Month_Label);
            this.Controls.Add(this.Payoff_Amount_Label);
            this.Controls.Add(this.Hours_Of_Exercise_Per_Week_Label);
            this.Controls.Add(this.Dangerous_Activities_Label);
            this.Controls.Add(this.Hospitalized_Label);
            this.Controls.Add(this.Cancer_Label);
            this.Controls.Add(this.Heart_Disease_Label);
            this.Controls.Add(this.Average_Grams_Fat_Per_Day_Label);
            this.Controls.Add(this.Systolic_Blood_Pressure_Label);
            this.Controls.Add(this.Cigs_Per_Day_Label);
            this.Controls.Add(this.Smoking_History_Label);
            this.Controls.Add(this.Mothers_Age_At_Death_Label);
            this.Controls.Add(this.Fathers_Age_At_Death_Label);
            this.Controls.Add(this.Policyholder_DOB_Label);
            this.Name = "PricePolicy";
            this.Text = "PricePolicy";
            this.Load += new System.EventHandler(this.PricePolicy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Total_Amount_Of_Payment_Per_Month_Label;
        private Label Payoff_Amount_Label;
        private Label Hours_Of_Exercise_Per_Week_Label;
        private Label Dangerous_Activities_Label;
        private Label Hospitalized_Label;
        private Label Cancer_Label;
        private Label Heart_Disease_Label;
        private Label Average_Grams_Fat_Per_Day_Label;
        private Label Systolic_Blood_Pressure_Label;
        private Label Cigs_Per_Day_Label;
        private Label Smoking_History_Label;
        private Label Mothers_Age_At_Death_Label;
        private Label Fathers_Age_At_Death_Label;
        private Label Policyholder_DOB_Label;
        private TextBox Policyholder_DOB_textBox;
        private TextBox Fathers_Age_At_Death_textBox;
        private TextBox Mothers_Age_At_Death_textBox;
        private TextBox Smoking_History_textBox;
        private TextBox Cigs_Per_Day_textBox;
        private TextBox Systolic_Blood_Pressure_textBox;
        private TextBox Average_Grams_Fat_Per_Day_textBox;
        private TextBox Dangerous_Activities_textBox;
        private TextBox Hours_Of_Exercise_Per_Week_textBox;
        private RadioButton Heart_Disease_Yes_radioButton;
        private RadioButton Heart_Disease_No_radioButton;
        private RadioButton Cancer_No_radioButton;
        private RadioButton Cancer_Yes_radioButton;
        private RadioButton Hospitalized_No_radioButton;
        private RadioButton Hospitalized_Yes_radioButton;
        private Label Price_A_Policy_Label;
        private Button Accept_Button;
        private Button Cancel_Button;
    }
}