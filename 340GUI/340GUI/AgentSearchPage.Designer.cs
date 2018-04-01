using System.Windows.Forms;
namespace _340GUI
{
    partial class AgentSearchPage
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
            this.Home_Label = new System.Windows.Forms.LinkLabel();
            this.Search_Label = new System.Windows.Forms.LinkLabel();
            this.Create_A_Policy_Label = new System.Windows.Forms.LinkLabel();
            this.Delinquent_Accounts_Label = new System.Windows.Forms.LinkLabel();
            this.Log_Out_Label = new System.Windows.Forms.LinkLabel();
            this.SearchBy_Label = new System.Windows.Forms.Label();
            this.Policy_Number_Label = new System.Windows.Forms.Label();
            this.Agent_First_Name_Label = new System.Windows.Forms.Label();
            this.Agent_Last_Name_Label = new System.Windows.Forms.Label();
            this.Policyholder_First_Name_Label = new System.Windows.Forms.Label();
            this.Policyholder_Last_Name_Label = new System.Windows.Forms.Label();
            this.Policy_Number_textBox = new System.Windows.Forms.TextBox();
            this.Policyholder_First_Name_textBox = new System.Windows.Forms.TextBox();
            this.Policyholder_Last_Name_textBox = new System.Windows.Forms.TextBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Home_Label
            // 
            this.Home_Label.AutoSize = true;
            this.Home_Label.Location = new System.Drawing.Point(12, 40);
            this.Home_Label.Name = "Home_Label";
            this.Home_Label.Size = new System.Drawing.Size(35, 13);
            this.Home_Label.TabIndex = 0;
            this.Home_Label.TabStop = true;
            this.Home_Label.Text = "Home";
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Location = new System.Drawing.Point(12, 66);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(41, 13);
            this.Search_Label.TabIndex = 1;
            this.Search_Label.TabStop = true;
            this.Search_Label.Text = "Search";
            // 
            // Create_A_Policy_Label
            // 
            this.Create_A_Policy_Label.AutoSize = true;
            this.Create_A_Policy_Label.Location = new System.Drawing.Point(12, 92);
            this.Create_A_Policy_Label.Name = "Create_A_Policy_Label";
            this.Create_A_Policy_Label.Size = new System.Drawing.Size(78, 13);
            this.Create_A_Policy_Label.TabIndex = 2;
            this.Create_A_Policy_Label.TabStop = true;
            this.Create_A_Policy_Label.Text = "Create a Policy";
            // 
            // Delinquent_Accounts_Label
            // 
            this.Delinquent_Accounts_Label.AutoSize = true;
            this.Delinquent_Accounts_Label.Location = new System.Drawing.Point(12, 118);
            this.Delinquent_Accounts_Label.Name = "Delinquent_Accounts_Label";
            this.Delinquent_Accounts_Label.Size = new System.Drawing.Size(106, 13);
            this.Delinquent_Accounts_Label.TabIndex = 3;
            this.Delinquent_Accounts_Label.TabStop = true;
            this.Delinquent_Accounts_Label.Text = "Delinquent Accounts";
            // 
            // Log_Out_Label
            // 
            this.Log_Out_Label.AutoSize = true;
            this.Log_Out_Label.Location = new System.Drawing.Point(12, 144);
            this.Log_Out_Label.Name = "Log_Out_Label";
            this.Log_Out_Label.Size = new System.Drawing.Size(43, 13);
            this.Log_Out_Label.TabIndex = 4;
            this.Log_Out_Label.TabStop = true;
            this.Log_Out_Label.Text = "Log out";
            // 
            // SearchBy_Label
            // 
            this.SearchBy_Label.AutoSize = true;
            this.SearchBy_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBy_Label.Location = new System.Drawing.Point(200, 40);
            this.SearchBy_Label.Name = "SearchBy_Label";
            this.SearchBy_Label.Size = new System.Drawing.Size(64, 13);
            this.SearchBy_Label.TabIndex = 5;
            this.SearchBy_Label.Text = "Search by";
            // 
            // Policy_Number_Label
            // 
            this.Policy_Number_Label.AutoSize = true;
            this.Policy_Number_Label.Location = new System.Drawing.Point(200, 66);
            this.Policy_Number_Label.Name = "Policy_Number_Label";
            this.Policy_Number_Label.Size = new System.Drawing.Size(75, 13);
            this.Policy_Number_Label.TabIndex = 6;
            this.Policy_Number_Label.Text = "Policy Number";
            // 
            // Agent_First_Name_Label
            // 
            this.Agent_First_Name_Label.AutoSize = true;
            this.Agent_First_Name_Label.Location = new System.Drawing.Point(200, 92);
            this.Agent_First_Name_Label.Name = "Agent_First_Name_Label";
            this.Agent_First_Name_Label.Size = new System.Drawing.Size(88, 13);
            this.Agent_First_Name_Label.TabIndex = 7;
            this.Agent_First_Name_Label.Text = "Agent First Name";
            this.Agent_First_Name_Label.Click += new System.EventHandler(this.Agent_First_Name_Label_Click);
            // 
            // Agent_Last_Name_Label
            // 
            this.Agent_Last_Name_Label.AutoSize = true;
            this.Agent_Last_Name_Label.Location = new System.Drawing.Point(200, 118);
            this.Agent_Last_Name_Label.Name = "Agent_Last_Name_Label";
            this.Agent_Last_Name_Label.Size = new System.Drawing.Size(89, 13);
            this.Agent_Last_Name_Label.TabIndex = 8;
            this.Agent_Last_Name_Label.Text = "Agent Last Name";
            // 
            // Policyholder_First_Name_Label
            // 
            this.Policyholder_First_Name_Label.AutoSize = true;
            this.Policyholder_First_Name_Label.Location = new System.Drawing.Point(200, 144);
            this.Policyholder_First_Name_Label.Name = "Policyholder_First_Name_Label";
            this.Policyholder_First_Name_Label.Size = new System.Drawing.Size(117, 13);
            this.Policyholder_First_Name_Label.TabIndex = 9;
            this.Policyholder_First_Name_Label.Text = "Policyholder First Name";
            // 
            // Policyholder_Last_Name_Label
            // 
            this.Policyholder_Last_Name_Label.AutoSize = true;
            this.Policyholder_Last_Name_Label.Location = new System.Drawing.Point(200, 170);
            this.Policyholder_Last_Name_Label.Name = "Policyholder_Last_Name_Label";
            this.Policyholder_Last_Name_Label.Size = new System.Drawing.Size(118, 13);
            this.Policyholder_Last_Name_Label.TabIndex = 10;
            this.Policyholder_Last_Name_Label.Text = "Policyholder Last Name";
            // 
            // Policy_Number_textBox
            // 
            this.Policy_Number_textBox.Location = new System.Drawing.Point(323, 63);
            this.Policy_Number_textBox.Name = "Policy_Number_textBox";
            this.Policy_Number_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policy_Number_textBox.TabIndex = 11;
            // 
            // Policyholder_First_Name_textBox
            // 
            this.Policyholder_First_Name_textBox.Location = new System.Drawing.Point(323, 141);
            this.Policyholder_First_Name_textBox.Name = "Policyholder_First_Name_textBox";
            this.Policyholder_First_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policyholder_First_Name_textBox.TabIndex = 14;
            // 
            // Policyholder_Last_Name_textBox
            // 
            this.Policyholder_Last_Name_textBox.Location = new System.Drawing.Point(323, 167);
            this.Policyholder_Last_Name_textBox.Name = "Policyholder_Last_Name_textBox";
            this.Policyholder_Last_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policyholder_Last_Name_textBox.TabIndex = 15;
            // 
            // Submit_Button
            // 
            this.Submit_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Submit_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Submit_Button.Location = new System.Drawing.Point(486, 193);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(75, 23);
            this.Submit_Button.TabIndex = 16;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = false;
            // 
            // AgentSearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Policyholder_Last_Name_textBox);
            this.Controls.Add(this.Policyholder_First_Name_textBox);
            this.Controls.Add(this.Policy_Number_textBox);
            this.Controls.Add(this.Policyholder_Last_Name_Label);
            this.Controls.Add(this.Policyholder_First_Name_Label);
            this.Controls.Add(this.Agent_Last_Name_Label);
            this.Controls.Add(this.Agent_First_Name_Label);
            this.Controls.Add(this.Policy_Number_Label);
            this.Controls.Add(this.SearchBy_Label);
            this.Controls.Add(this.Log_Out_Label);
            this.Controls.Add(this.Delinquent_Accounts_Label);
            this.Controls.Add(this.Create_A_Policy_Label);
            this.Controls.Add(this.Search_Label);
            this.Controls.Add(this.Home_Label);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AgentSearchPage";
            this.Text = "Agent Search Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel Home_Label;
        private LinkLabel Search_Label;
        private LinkLabel Create_A_Policy_Label;
        private LinkLabel Delinquent_Accounts_Label;
        private LinkLabel Log_Out_Label;
        private Label SearchBy_Label;
        private Label Policy_Number_Label;
        private Label Agent_First_Name_Label;
        private Label Agent_Last_Name_Label;
        private Label Policyholder_First_Name_Label;
        private Label Policyholder_Last_Name_Label;
        private TextBox Policy_Number_textBox;
        private TextBox Policyholder_First_Name_textBox;
        private TextBox Policyholder_Last_Name_textBox;
        private Button Submit_Button;
    }
}