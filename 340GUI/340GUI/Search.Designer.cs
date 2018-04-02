using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _340GUI
{
    partial class Search
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
            this.button_Submit = new System.Windows.Forms.Button();
            this.textBox_PolicyholderLastName = new System.Windows.Forms.TextBox();
            this.textBox_PolicyholderFirstName = new System.Windows.Forms.TextBox();
            this.textBox_AgentLastName = new System.Windows.Forms.TextBox();
            this.textBox_AgentFirstName = new System.Windows.Forms.TextBox();
            this.textBox_PolicyNumber = new System.Windows.Forms.TextBox();
            this.label_PolicyholderLastName = new System.Windows.Forms.Label();
            this.label_PolicyholderFirstName = new System.Windows.Forms.Label();
            this.label_AgentLastName = new System.Windows.Forms.Label();
            this.label_AgentFirstName = new System.Windows.Forms.Label();
            this.label_PolicyNumber = new System.Windows.Forms.Label();
            this.label_SearchBy = new System.Windows.Forms.Label();
            this.linkLabel_Logout = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DelinquentAccounts = new System.Windows.Forms.LinkLabel();
            this.linkLabel_CreatePolicy = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Search = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Home = new System.Windows.Forms.LinkLabel();
            this.linkLabel_AddNewAgent = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Submit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Submit.Location = new System.Drawing.Point(486, 193);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 33;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_PolicyholderLastName
            // 
            this.textBox_PolicyholderLastName.Location = new System.Drawing.Point(323, 167);
            this.textBox_PolicyholderLastName.Name = "textBox_PolicyholderLastName";
            this.textBox_PolicyholderLastName.Size = new System.Drawing.Size(238, 20);
            this.textBox_PolicyholderLastName.TabIndex = 32;
            this.textBox_PolicyholderLastName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox_PolicyholderFirstName
            // 
            this.textBox_PolicyholderFirstName.Location = new System.Drawing.Point(323, 141);
            this.textBox_PolicyholderFirstName.Name = "textBox_PolicyholderFirstName";
            this.textBox_PolicyholderFirstName.Size = new System.Drawing.Size(238, 20);
            this.textBox_PolicyholderFirstName.TabIndex = 31;
            this.textBox_PolicyholderFirstName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox_AgentLastName
            // 
            this.textBox_AgentLastName.Location = new System.Drawing.Point(323, 115);
            this.textBox_AgentLastName.Name = "textBox_AgentLastName";
            this.textBox_AgentLastName.Size = new System.Drawing.Size(238, 20);
            this.textBox_AgentLastName.TabIndex = 30;
            this.textBox_AgentLastName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_AgentFirstName
            // 
            this.textBox_AgentFirstName.Location = new System.Drawing.Point(323, 89);
            this.textBox_AgentFirstName.Name = "textBox_AgentFirstName";
            this.textBox_AgentFirstName.Size = new System.Drawing.Size(238, 20);
            this.textBox_AgentFirstName.TabIndex = 29;
            this.textBox_AgentFirstName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_PolicyNumber
            // 
            this.textBox_PolicyNumber.Location = new System.Drawing.Point(323, 63);
            this.textBox_PolicyNumber.Name = "textBox_PolicyNumber";
            this.textBox_PolicyNumber.Size = new System.Drawing.Size(238, 20);
            this.textBox_PolicyNumber.TabIndex = 28;
            this.textBox_PolicyNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_PolicyholderLastName
            // 
            this.label_PolicyholderLastName.AutoSize = true;
            this.label_PolicyholderLastName.Location = new System.Drawing.Point(200, 170);
            this.label_PolicyholderLastName.Name = "label_PolicyholderLastName";
            this.label_PolicyholderLastName.Size = new System.Drawing.Size(118, 13);
            this.label_PolicyholderLastName.TabIndex = 27;
            this.label_PolicyholderLastName.Text = "Policyholder Last Name";
            this.label_PolicyholderLastName.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_PolicyholderFirstName
            // 
            this.label_PolicyholderFirstName.AutoSize = true;
            this.label_PolicyholderFirstName.Location = new System.Drawing.Point(200, 144);
            this.label_PolicyholderFirstName.Name = "label_PolicyholderFirstName";
            this.label_PolicyholderFirstName.Size = new System.Drawing.Size(117, 13);
            this.label_PolicyholderFirstName.TabIndex = 26;
            this.label_PolicyholderFirstName.Text = "Policyholder First Name";
            this.label_PolicyholderFirstName.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_AgentLastName
            // 
            this.label_AgentLastName.AutoSize = true;
            this.label_AgentLastName.Location = new System.Drawing.Point(200, 118);
            this.label_AgentLastName.Name = "label_AgentLastName";
            this.label_AgentLastName.Size = new System.Drawing.Size(89, 13);
            this.label_AgentLastName.TabIndex = 25;
            this.label_AgentLastName.Text = "Agent Last Name";
            this.label_AgentLastName.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_AgentFirstName
            // 
            this.label_AgentFirstName.AutoSize = true;
            this.label_AgentFirstName.Location = new System.Drawing.Point(200, 92);
            this.label_AgentFirstName.Name = "label_AgentFirstName";
            this.label_AgentFirstName.Size = new System.Drawing.Size(88, 13);
            this.label_AgentFirstName.TabIndex = 24;
            this.label_AgentFirstName.Text = "Agent First Name";
            this.label_AgentFirstName.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_PolicyNumber
            // 
            this.label_PolicyNumber.AutoSize = true;
            this.label_PolicyNumber.Location = new System.Drawing.Point(200, 66);
            this.label_PolicyNumber.Name = "label_PolicyNumber";
            this.label_PolicyNumber.Size = new System.Drawing.Size(75, 13);
            this.label_PolicyNumber.TabIndex = 23;
            this.label_PolicyNumber.Text = "Policy Number";
            this.label_PolicyNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_SearchBy
            // 
            this.label_SearchBy.AutoSize = true;
            this.label_SearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SearchBy.Location = new System.Drawing.Point(200, 40);
            this.label_SearchBy.Name = "label_SearchBy";
            this.label_SearchBy.Size = new System.Drawing.Size(64, 13);
            this.label_SearchBy.TabIndex = 22;
            this.label_SearchBy.Text = "Search by";
            this.label_SearchBy.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel_Logout
            // 
            this.linkLabel_Logout.AutoSize = true;
            this.linkLabel_Logout.Location = new System.Drawing.Point(12, 170);
            this.linkLabel_Logout.Name = "linkLabel_Logout";
            this.linkLabel_Logout.Size = new System.Drawing.Size(43, 13);
            this.linkLabel_Logout.TabIndex = 21;
            this.linkLabel_Logout.TabStop = true;
            this.linkLabel_Logout.Text = "Log out";
            this.linkLabel_Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel_DelinquentAccounts
            // 
            this.linkLabel_DelinquentAccounts.AutoSize = true;
            this.linkLabel_DelinquentAccounts.Location = new System.Drawing.Point(12, 118);
            this.linkLabel_DelinquentAccounts.Name = "linkLabel_DelinquentAccounts";
            this.linkLabel_DelinquentAccounts.Size = new System.Drawing.Size(106, 13);
            this.linkLabel_DelinquentAccounts.TabIndex = 20;
            this.linkLabel_DelinquentAccounts.TabStop = true;
            this.linkLabel_DelinquentAccounts.Text = "Delinquent Accounts";
            this.linkLabel_DelinquentAccounts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel_CreatePolicy
            // 
            this.linkLabel_CreatePolicy.AutoSize = true;
            this.linkLabel_CreatePolicy.Location = new System.Drawing.Point(12, 92);
            this.linkLabel_CreatePolicy.Name = "linkLabel_CreatePolicy";
            this.linkLabel_CreatePolicy.Size = new System.Drawing.Size(78, 13);
            this.linkLabel_CreatePolicy.TabIndex = 19;
            this.linkLabel_CreatePolicy.TabStop = true;
            this.linkLabel_CreatePolicy.Text = "Create a Policy";
            this.linkLabel_CreatePolicy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel_Search
            // 
            this.linkLabel_Search.AutoSize = true;
            this.linkLabel_Search.Location = new System.Drawing.Point(12, 66);
            this.linkLabel_Search.Name = "linkLabel_Search";
            this.linkLabel_Search.Size = new System.Drawing.Size(41, 13);
            this.linkLabel_Search.TabIndex = 18;
            this.linkLabel_Search.TabStop = true;
            this.linkLabel_Search.Text = "Search";
            this.linkLabel_Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel_Home
            // 
            this.linkLabel_Home.AutoSize = true;
            this.linkLabel_Home.Location = new System.Drawing.Point(12, 40);
            this.linkLabel_Home.Name = "linkLabel_Home";
            this.linkLabel_Home.Size = new System.Drawing.Size(35, 13);
            this.linkLabel_Home.TabIndex = 17;
            this.linkLabel_Home.TabStop = true;
            this.linkLabel_Home.Text = "Home";
            this.linkLabel_Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel_AddNewAgent
            // 
            this.linkLabel_AddNewAgent.AutoSize = true;
            this.linkLabel_AddNewAgent.Location = new System.Drawing.Point(12, 144);
            this.linkLabel_AddNewAgent.Name = "linkLabel_AddNewAgent";
            this.linkLabel_AddNewAgent.Size = new System.Drawing.Size(82, 13);
            this.linkLabel_AddNewAgent.TabIndex = 34;
            this.linkLabel_AddNewAgent.TabStop = true;
            this.linkLabel_AddNewAgent.Text = "Add New Agent";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.linkLabel_AddNewAgent);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_PolicyholderLastName);
            this.Controls.Add(this.textBox_PolicyholderFirstName);
            this.Controls.Add(this.textBox_AgentLastName);
            this.Controls.Add(this.textBox_AgentFirstName);
            this.Controls.Add(this.textBox_PolicyNumber);
            this.Controls.Add(this.label_PolicyholderLastName);
            this.Controls.Add(this.label_PolicyholderFirstName);
            this.Controls.Add(this.label_AgentLastName);
            this.Controls.Add(this.label_AgentFirstName);
            this.Controls.Add(this.label_PolicyNumber);
            this.Controls.Add(this.label_SearchBy);
            this.Controls.Add(this.linkLabel_Logout);
            this.Controls.Add(this.linkLabel_DelinquentAccounts);
            this.Controls.Add(this.linkLabel_CreatePolicy);
            this.Controls.Add(this.linkLabel_Search);
            this.Controls.Add(this.linkLabel_Home);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Search";
            this.Text = "Search Page";
            this.Load += new System.EventHandler(this.ManagerSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Submit;
        private TextBox textBox_PolicyholderLastName;
        private TextBox textBox_PolicyholderFirstName;
        private TextBox textBox_AgentLastName;
        private TextBox textBox_AgentFirstName;
        private TextBox textBox_PolicyNumber;
        private Label label_PolicyholderLastName;
        private Label label_PolicyholderFirstName;
        private Label label_AgentLastName;
        private Label label_AgentFirstName;
        private Label label_PolicyNumber;
        private Label label_SearchBy;
        private LinkLabel linkLabel_Logout;
        private LinkLabel linkLabel_DelinquentAccounts;
        private LinkLabel linkLabel_CreatePolicy;
        private LinkLabel linkLabel_Search;
        private LinkLabel linkLabel_Home;
        private LinkLabel linkLabel_AddNewAgent;
        //private Agent usingAgent;
    }
}