using System.Windows.Forms;
namespace _340GUI
{
    partial class ManagerSearch
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
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Policyholder_Last_Name_textBox = new System.Windows.Forms.TextBox();
            this.Policyholder_First_Name_textBox = new System.Windows.Forms.TextBox();
            this.Agent_Last_Name_textBox = new System.Windows.Forms.TextBox();
            this.Agent_First_Name_textBox = new System.Windows.Forms.TextBox();
            this.Policy_Number_textBox = new System.Windows.Forms.TextBox();
            this.Policyholder_Last_Name_Label = new System.Windows.Forms.Label();
            this.Policyholder_First_Name_Label = new System.Windows.Forms.Label();
            this.Agent_Last_Name_Label = new System.Windows.Forms.Label();
            this.Agent_First_Name_Label = new System.Windows.Forms.Label();
            this.Policy_Number_Label = new System.Windows.Forms.Label();
            this.SearchBy_Label = new System.Windows.Forms.Label();
            this.Log_Out = new System.Windows.Forms.LinkLabel();
            this.Delinquent_Accounts = new System.Windows.Forms.LinkLabel();
            this.Create_A_Policy = new System.Windows.Forms.LinkLabel();
            this.Search = new System.Windows.Forms.LinkLabel();
            this.Home = new System.Windows.Forms.LinkLabel();
            this.Add_New_Agent = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Submit_Button
            // 
            this.Submit_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Submit_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Submit_Button.Location = new System.Drawing.Point(486, 193);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(75, 23);
            this.Submit_Button.TabIndex = 33;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = false;
            this.Submit_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Policyholder_Last_Name_textBox
            // 
            this.Policyholder_Last_Name_textBox.Location = new System.Drawing.Point(323, 167);
            this.Policyholder_Last_Name_textBox.Name = "Policyholder_Last_Name_textBox";
            this.Policyholder_Last_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policyholder_Last_Name_textBox.TabIndex = 32;
            this.Policyholder_Last_Name_textBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Policyholder_First_Name_textBox
            // 
            this.Policyholder_First_Name_textBox.Location = new System.Drawing.Point(323, 141);
            this.Policyholder_First_Name_textBox.Name = "Policyholder_First_Name_textBox";
            this.Policyholder_First_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policyholder_First_Name_textBox.TabIndex = 31;
            this.Policyholder_First_Name_textBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Agent_Last_Name_textBox
            // 
            this.Agent_Last_Name_textBox.Location = new System.Drawing.Point(323, 115);
            this.Agent_Last_Name_textBox.Name = "Agent_Last_Name_textBox";
            this.Agent_Last_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Agent_Last_Name_textBox.TabIndex = 30;
            this.Agent_Last_Name_textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Agent_First_Name_textBox
            // 
            this.Agent_First_Name_textBox.Location = new System.Drawing.Point(323, 89);
            this.Agent_First_Name_textBox.Name = "Agent_First_Name_textBox";
            this.Agent_First_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Agent_First_Name_textBox.TabIndex = 29;
            this.Agent_First_Name_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Policy_Number_textBox
            // 
            this.Policy_Number_textBox.Location = new System.Drawing.Point(323, 63);
            this.Policy_Number_textBox.Name = "Policy_Number_textBox";
            this.Policy_Number_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policy_Number_textBox.TabIndex = 28;
            this.Policy_Number_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Policyholder_Last_Name_Label
            // 
            this.Policyholder_Last_Name_Label.AutoSize = true;
            this.Policyholder_Last_Name_Label.Location = new System.Drawing.Point(200, 170);
            this.Policyholder_Last_Name_Label.Name = "Policyholder_Last_Name_Label";
            this.Policyholder_Last_Name_Label.Size = new System.Drawing.Size(118, 13);
            this.Policyholder_Last_Name_Label.TabIndex = 27;
            this.Policyholder_Last_Name_Label.Text = "Policyholder Last Name";
            this.Policyholder_Last_Name_Label.Click += new System.EventHandler(this.label6_Click);
            // 
            // Policyholder_First_Name_Label
            // 
            this.Policyholder_First_Name_Label.AutoSize = true;
            this.Policyholder_First_Name_Label.Location = new System.Drawing.Point(200, 144);
            this.Policyholder_First_Name_Label.Name = "Policyholder_First_Name_Label";
            this.Policyholder_First_Name_Label.Size = new System.Drawing.Size(117, 13);
            this.Policyholder_First_Name_Label.TabIndex = 26;
            this.Policyholder_First_Name_Label.Text = "Policyholder First Name";
            this.Policyholder_First_Name_Label.Click += new System.EventHandler(this.label5_Click);
            // 
            // Agent_Last_Name_Label
            // 
            this.Agent_Last_Name_Label.AutoSize = true;
            this.Agent_Last_Name_Label.Location = new System.Drawing.Point(200, 118);
            this.Agent_Last_Name_Label.Name = "Agent_Last_Name_Label";
            this.Agent_Last_Name_Label.Size = new System.Drawing.Size(89, 13);
            this.Agent_Last_Name_Label.TabIndex = 25;
            this.Agent_Last_Name_Label.Text = "Agent Last Name";
            this.Agent_Last_Name_Label.Click += new System.EventHandler(this.label4_Click);
            // 
            // Agent_First_Name_Label
            // 
            this.Agent_First_Name_Label.AutoSize = true;
            this.Agent_First_Name_Label.Location = new System.Drawing.Point(200, 92);
            this.Agent_First_Name_Label.Name = "Agent_First_Name_Label";
            this.Agent_First_Name_Label.Size = new System.Drawing.Size(88, 13);
            this.Agent_First_Name_Label.TabIndex = 24;
            this.Agent_First_Name_Label.Text = "Agent First Name";
            this.Agent_First_Name_Label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Policy_Number_Label
            // 
            this.Policy_Number_Label.AutoSize = true;
            this.Policy_Number_Label.Location = new System.Drawing.Point(200, 66);
            this.Policy_Number_Label.Name = "Policy_Number_Label";
            this.Policy_Number_Label.Size = new System.Drawing.Size(75, 13);
            this.Policy_Number_Label.TabIndex = 23;
            this.Policy_Number_Label.Text = "Policy Number";
            this.Policy_Number_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // SearchBy_Label
            // 
            this.SearchBy_Label.AutoSize = true;
            this.SearchBy_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBy_Label.Location = new System.Drawing.Point(200, 40);
            this.SearchBy_Label.Name = "SearchBy_Label";
            this.SearchBy_Label.Size = new System.Drawing.Size(64, 13);
            this.SearchBy_Label.TabIndex = 22;
            this.SearchBy_Label.Text = "Search by";
            this.SearchBy_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Log_Out
            // 
            this.Log_Out.AutoSize = true;
            this.Log_Out.Location = new System.Drawing.Point(12, 170);
            this.Log_Out.Name = "Log_Out";
            this.Log_Out.Size = new System.Drawing.Size(43, 13);
            this.Log_Out.TabIndex = 21;
            this.Log_Out.TabStop = true;
            this.Log_Out.Text = "Log out";
            this.Log_Out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // Delinquent_Accounts
            // 
            this.Delinquent_Accounts.AutoSize = true;
            this.Delinquent_Accounts.Location = new System.Drawing.Point(12, 118);
            this.Delinquent_Accounts.Name = "Delinquent_Accounts";
            this.Delinquent_Accounts.Size = new System.Drawing.Size(106, 13);
            this.Delinquent_Accounts.TabIndex = 20;
            this.Delinquent_Accounts.TabStop = true;
            this.Delinquent_Accounts.Text = "Delinquent Accounts";
            this.Delinquent_Accounts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // Create_A_Policy
            // 
            this.Create_A_Policy.AutoSize = true;
            this.Create_A_Policy.Location = new System.Drawing.Point(12, 92);
            this.Create_A_Policy.Name = "Create_A_Policy";
            this.Create_A_Policy.Size = new System.Drawing.Size(78, 13);
            this.Create_A_Policy.TabIndex = 19;
            this.Create_A_Policy.TabStop = true;
            this.Create_A_Policy.Text = "Create a Policy";
            this.Create_A_Policy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(12, 66);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 18;
            this.Search.TabStop = true;
            this.Search.Text = "Search";
            this.Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Location = new System.Drawing.Point(12, 40);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(35, 13);
            this.Home.TabIndex = 17;
            this.Home.TabStop = true;
            this.Home.Text = "Home";
            this.Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Add_New_Agent
            // 
            this.Add_New_Agent.AutoSize = true;
            this.Add_New_Agent.Location = new System.Drawing.Point(12, 144);
            this.Add_New_Agent.Name = "Add_New_Agent";
            this.Add_New_Agent.Size = new System.Drawing.Size(82, 13);
            this.Add_New_Agent.TabIndex = 34;
            this.Add_New_Agent.TabStop = true;
            this.Add_New_Agent.Text = "Add New Agent";
            // 
            // ManagerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.Add_New_Agent);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Policyholder_Last_Name_textBox);
            this.Controls.Add(this.Policyholder_First_Name_textBox);
            this.Controls.Add(this.Agent_Last_Name_textBox);
            this.Controls.Add(this.Agent_First_Name_textBox);
            this.Controls.Add(this.Policy_Number_textBox);
            this.Controls.Add(this.Policyholder_Last_Name_Label);
            this.Controls.Add(this.Policyholder_First_Name_Label);
            this.Controls.Add(this.Agent_Last_Name_Label);
            this.Controls.Add(this.Agent_First_Name_Label);
            this.Controls.Add(this.Policy_Number_Label);
            this.Controls.Add(this.SearchBy_Label);
            this.Controls.Add(this.Log_Out);
            this.Controls.Add(this.Delinquent_Accounts);
            this.Controls.Add(this.Create_A_Policy);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Home);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ManagerSearch";
            this.Text = "Manager Search Page";
            this.Load += new System.EventHandler(this.ManagerSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Submit_Button;
        private TextBox Policyholder_Last_Name_textBox;
        private TextBox Policyholder_First_Name_textBox;
        private TextBox Agent_Last_Name_textBox;
        private TextBox Agent_First_Name_textBox;
        private TextBox Policy_Number_textBox;
        private Label Policyholder_Last_Name_Label;
        private Label Policyholder_First_Name_Label;
        private Label Agent_Last_Name_Label;
        private Label Agent_First_Name_Label;
        private Label Policy_Number_Label;
        private Label SearchBy_Label;
        private LinkLabel Log_Out;
        private LinkLabel Delinquent_Accounts;
        private LinkLabel Create_A_Policy;
        private LinkLabel Search;
        private LinkLabel Home;
        private LinkLabel Add_New_Agent;
    }
}