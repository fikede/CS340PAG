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
    partial class Delinquent
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
            this.linkLabel_AddNewAgent = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Logout = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DelinquentAccounts = new System.Windows.Forms.LinkLabel();
            this.linkLabel_CreatePolicy = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Search = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Home = new System.Windows.Forms.LinkLabel();
            this.comboBox_State = new System.Windows.Forms.ComboBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.textBox_AmountOverdue = new System.Windows.Forms.TextBox();
            this.label_AmountOverdue = new System.Windows.Forms.Label();
            this.label_AgentLastName = new System.Windows.Forms.Label();
            this.label_AgentFirstName = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.label_DelinquentAccount = new System.Windows.Forms.Label();
            this.textBox_AgentLastName = new System.Windows.Forms.TextBox();
            this.textBox_AgentFirstName = new System.Windows.Forms.TextBox();
            this.label_ShowAgentFirstName = new System.Windows.Forms.Label();
            this.label_ShowAgentLastName = new System.Windows.Forms.Label();
            this.listBox_DelinquentList = new System.Windows.Forms.ListBox();
            this.textBox_Categories = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel_AddNewAgent
            // 
            this.linkLabel_AddNewAgent.AutoSize = true;
            this.linkLabel_AddNewAgent.Location = new System.Drawing.Point(12, 144);
            this.linkLabel_AddNewAgent.Name = "linkLabel_AddNewAgent";
            this.linkLabel_AddNewAgent.Size = new System.Drawing.Size(82, 13);
            this.linkLabel_AddNewAgent.TabIndex = 57;
            this.linkLabel_AddNewAgent.TabStop = true;
            this.linkLabel_AddNewAgent.Text = "Add New Agent";
            this.linkLabel_AddNewAgent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AddNewAgent_LinkClicked);
            // 
            // linkLabel_Logout
            // 
            this.linkLabel_Logout.AutoSize = true;
            this.linkLabel_Logout.Location = new System.Drawing.Point(12, 170);
            this.linkLabel_Logout.Name = "linkLabel_Logout";
            this.linkLabel_Logout.Size = new System.Drawing.Size(43, 13);
            this.linkLabel_Logout.TabIndex = 58;
            this.linkLabel_Logout.TabStop = true;
            this.linkLabel_Logout.Text = "Log out";
            this.linkLabel_Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Logout_LinkClicked);
            // 
            // linkLabel_DelinquentAccounts
            // 
            this.linkLabel_DelinquentAccounts.AutoSize = true;
            this.linkLabel_DelinquentAccounts.Location = new System.Drawing.Point(12, 118);
            this.linkLabel_DelinquentAccounts.Name = "linkLabel_DelinquentAccounts";
            this.linkLabel_DelinquentAccounts.Size = new System.Drawing.Size(106, 13);
            this.linkLabel_DelinquentAccounts.TabIndex = 56;
            this.linkLabel_DelinquentAccounts.TabStop = true;
            this.linkLabel_DelinquentAccounts.Text = "Delinquent Accounts";
            this.linkLabel_DelinquentAccounts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DelinquentAccounts_LinkClicked);
            // 
            // linkLabel_CreatePolicy
            // 
            this.linkLabel_CreatePolicy.AutoSize = true;
            this.linkLabel_CreatePolicy.Location = new System.Drawing.Point(12, 92);
            this.linkLabel_CreatePolicy.Name = "linkLabel_CreatePolicy";
            this.linkLabel_CreatePolicy.Size = new System.Drawing.Size(78, 13);
            this.linkLabel_CreatePolicy.TabIndex = 55;
            this.linkLabel_CreatePolicy.TabStop = true;
            this.linkLabel_CreatePolicy.Text = "Create a Policy";
            this.linkLabel_CreatePolicy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_CreatePolicy_LinkClicked);
            // 
            // linkLabel_Search
            // 
            this.linkLabel_Search.AutoSize = true;
            this.linkLabel_Search.Location = new System.Drawing.Point(12, 66);
            this.linkLabel_Search.Name = "linkLabel_Search";
            this.linkLabel_Search.Size = new System.Drawing.Size(41, 13);
            this.linkLabel_Search.TabIndex = 54;
            this.linkLabel_Search.TabStop = true;
            this.linkLabel_Search.Text = "Search";
            this.linkLabel_Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Search_LinkClicked);
            // 
            // linkLabel_Home
            // 
            this.linkLabel_Home.AutoSize = true;
            this.linkLabel_Home.Location = new System.Drawing.Point(12, 40);
            this.linkLabel_Home.Name = "linkLabel_Home";
            this.linkLabel_Home.Size = new System.Drawing.Size(35, 13);
            this.linkLabel_Home.TabIndex = 53;
            this.linkLabel_Home.TabStop = true;
            this.linkLabel_Home.Text = "Home";
            this.linkLabel_Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Home_LinkClicked);
            // 
            // comboBox_State
            // 
            this.comboBox_State.DisplayMember = "Select";
            this.comboBox_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_State.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox_State.FormattingEnabled = true;
            this.comboBox_State.Items.AddRange(new object[] {
            "No State Specified",
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
            this.comboBox_State.Location = new System.Drawing.Point(338, 63);
            this.comboBox_State.Name = "comboBox_State";
            this.comboBox_State.Size = new System.Drawing.Size(223, 21);
            this.comboBox_State.TabIndex = 66;
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Submit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Submit.Location = new System.Drawing.Point(486, 167);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 70;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // textBox_AmountOverdue
            // 
            this.textBox_AmountOverdue.Location = new System.Drawing.Point(338, 141);
            this.textBox_AmountOverdue.Name = "textBox_AmountOverdue";
            this.textBox_AmountOverdue.Size = new System.Drawing.Size(223, 20);
            this.textBox_AmountOverdue.TabIndex = 69;
            // 
            // label_AmountOverdue
            // 
            this.label_AmountOverdue.AutoSize = true;
            this.label_AmountOverdue.Location = new System.Drawing.Point(200, 144);
            this.label_AmountOverdue.Name = "label_AmountOverdue";
            this.label_AmountOverdue.Size = new System.Drawing.Size(134, 13);
            this.label_AmountOverdue.TabIndex = 63;
            this.label_AmountOverdue.Text = "Amount Overdue is at least";
            // 
            // label_AgentLastName
            // 
            this.label_AgentLastName.AutoSize = true;
            this.label_AgentLastName.Location = new System.Drawing.Point(200, 118);
            this.label_AgentLastName.Name = "label_AgentLastName";
            this.label_AgentLastName.Size = new System.Drawing.Size(89, 13);
            this.label_AgentLastName.TabIndex = 62;
            this.label_AgentLastName.Text = "Agent Last Name";
            // 
            // label_AgentFirstName
            // 
            this.label_AgentFirstName.AutoSize = true;
            this.label_AgentFirstName.Location = new System.Drawing.Point(200, 92);
            this.label_AgentFirstName.Name = "label_AgentFirstName";
            this.label_AgentFirstName.Size = new System.Drawing.Size(88, 13);
            this.label_AgentFirstName.TabIndex = 61;
            this.label_AgentFirstName.Text = "Agent First Name";
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(200, 66);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(32, 13);
            this.label_State.TabIndex = 60;
            this.label_State.Text = "State";
            // 
            // label_DelinquentAccount
            // 
            this.label_DelinquentAccount.AutoSize = true;
            this.label_DelinquentAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DelinquentAccount.Location = new System.Drawing.Point(200, 40);
            this.label_DelinquentAccount.Name = "label_DelinquentAccount";
            this.label_DelinquentAccount.Size = new System.Drawing.Size(119, 13);
            this.label_DelinquentAccount.TabIndex = 59;
            this.label_DelinquentAccount.Text = "Delinquent Account";
            // 
            // textBox_AgentLastName
            // 
            this.textBox_AgentLastName.Location = new System.Drawing.Point(338, 115);
            this.textBox_AgentLastName.Name = "textBox_AgentLastName";
            this.textBox_AgentLastName.Size = new System.Drawing.Size(223, 20);
            this.textBox_AgentLastName.TabIndex = 68;
            // 
            // textBox_AgentFirstName
            // 
            this.textBox_AgentFirstName.Location = new System.Drawing.Point(338, 89);
            this.textBox_AgentFirstName.Name = "textBox_AgentFirstName";
            this.textBox_AgentFirstName.Size = new System.Drawing.Size(223, 20);
            this.textBox_AgentFirstName.TabIndex = 67;
            // 
            // label_ShowAgentFirstName
            // 
            this.label_ShowAgentFirstName.AutoSize = true;
            this.label_ShowAgentFirstName.Location = new System.Drawing.Point(341, 92);
            this.label_ShowAgentFirstName.Name = "label_ShowAgentFirstName";
            this.label_ShowAgentFirstName.Size = new System.Drawing.Size(35, 13);
            this.label_ShowAgentFirstName.TabIndex = 69;
            this.label_ShowAgentFirstName.Text = "label1";
            // 
            // label_ShowAgentLastName
            // 
            this.label_ShowAgentLastName.AutoSize = true;
            this.label_ShowAgentLastName.Location = new System.Drawing.Point(341, 118);
            this.label_ShowAgentLastName.Name = "label_ShowAgentLastName";
            this.label_ShowAgentLastName.Size = new System.Drawing.Size(35, 13);
            this.label_ShowAgentLastName.TabIndex = 70;
            this.label_ShowAgentLastName.Text = "label1";
            // 
            // listBox_DelinquentList
            // 
            this.listBox_DelinquentList.FormattingEnabled = true;
            this.listBox_DelinquentList.Location = new System.Drawing.Point(197, 215);
            this.listBox_DelinquentList.Name = "listBox_DelinquentList";
            this.listBox_DelinquentList.Size = new System.Drawing.Size(535, 160);
            this.listBox_DelinquentList.TabIndex = 71;
            // 
            // textBox_Categories
            // 
            this.textBox_Categories.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_Categories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Categories.Location = new System.Drawing.Point(197, 196);
            this.textBox_Categories.Name = "textBox_Categories";
            this.textBox_Categories.ReadOnly = true;
            this.textBox_Categories.Size = new System.Drawing.Size(535, 20);
            this.textBox_Categories.TabIndex = 74;
            this.textBox_Categories.Text = "  Policy Number                 Policyholder\'s Name                Agent\'s Name  " +
    "                   Amount Overdue";
            // 
            // Delinquent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.textBox_Categories);
            this.Controls.Add(this.listBox_DelinquentList);
            this.Controls.Add(this.label_ShowAgentLastName);
            this.Controls.Add(this.label_ShowAgentFirstName);
            this.Controls.Add(this.textBox_AgentFirstName);
            this.Controls.Add(this.textBox_AgentLastName);
            this.Controls.Add(this.comboBox_State);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_AmountOverdue);
            this.Controls.Add(this.label_AmountOverdue);
            this.Controls.Add(this.label_AgentLastName);
            this.Controls.Add(this.label_AgentFirstName);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.label_DelinquentAccount);
            this.Controls.Add(this.linkLabel_AddNewAgent);
            this.Controls.Add(this.linkLabel_Logout);
            this.Controls.Add(this.linkLabel_DelinquentAccounts);
            this.Controls.Add(this.linkLabel_CreatePolicy);
            this.Controls.Add(this.linkLabel_Search);
            this.Controls.Add(this.linkLabel_Home);
            this.Name = "Delinquent";
            this.Text = "Delinquent Account Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel_AddNewAgent;
        private LinkLabel linkLabel_Logout;
        private LinkLabel linkLabel_DelinquentAccounts;
        private LinkLabel linkLabel_CreatePolicy;
        private LinkLabel linkLabel_Search;
        private LinkLabel linkLabel_Home;
        private ComboBox comboBox_State;
        private Button button_Submit;
        private TextBox textBox_AmountOverdue;
        private Label label_AmountOverdue;
        private Label label_AgentLastName;
        private Label label_AgentFirstName;
        private Label label_State;
        private Label label_DelinquentAccount;
        private TextBox textBox_AgentLastName;
        private TextBox textBox_AgentFirstName;
        private Agent usingAgent;
        private Label label_ShowAgentFirstName;
        private Label label_ShowAgentLastName;
        private ListBox listBox_DelinquentList;
        private TextBox textBox_Categories;
    }
}