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
            this.linkLabel_Home = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Search = new System.Windows.Forms.LinkLabel();
            this.linkLabel_CreatePolicy = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DelinquentAccounts = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Logout = new System.Windows.Forms.LinkLabel();
            this.label_SearchBy = new System.Windows.Forms.Label();
            this.label_PolicyNumber = new System.Windows.Forms.Label();
            this.label_AgentFirstName = new System.Windows.Forms.Label();
            this.label_AgentLastName = new System.Windows.Forms.Label();
            this.label_PolicyholderFirstName = new System.Windows.Forms.Label();
            this.label_PolicyholderLastName = new System.Windows.Forms.Label();
            this.textBox_PolicyNumber = new System.Windows.Forms.TextBox();
            this.textBox_PolicyholderFirstName = new System.Windows.Forms.TextBox();
            this.textBox_PolicyholderLastName = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.label_ShowAgentFirstName = new System.Windows.Forms.Label();
            this.label_ShowAgentLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel_Home
            // 
            this.linkLabel_Home.AutoSize = true;
            this.linkLabel_Home.Location = new System.Drawing.Point(12, 40);
            this.linkLabel_Home.Name = "linkLabel_Home";
            this.linkLabel_Home.Size = new System.Drawing.Size(35, 13);
            this.linkLabel_Home.TabIndex = 0;
            this.linkLabel_Home.TabStop = true;
            this.linkLabel_Home.Text = "Home";
            // 
            // linkLabel_Search
            // 
            this.linkLabel_Search.AutoSize = true;
            this.linkLabel_Search.Location = new System.Drawing.Point(12, 66);
            this.linkLabel_Search.Name = "linkLabel_Search";
            this.linkLabel_Search.Size = new System.Drawing.Size(41, 13);
            this.linkLabel_Search.TabIndex = 1;
            this.linkLabel_Search.TabStop = true;
            this.linkLabel_Search.Text = "Search";
            // 
            // linkLabel_CreatePolicy
            // 
            this.linkLabel_CreatePolicy.AutoSize = true;
            this.linkLabel_CreatePolicy.Location = new System.Drawing.Point(12, 92);
            this.linkLabel_CreatePolicy.Name = "linkLabel_CreatePolicy";
            this.linkLabel_CreatePolicy.Size = new System.Drawing.Size(78, 13);
            this.linkLabel_CreatePolicy.TabIndex = 2;
            this.linkLabel_CreatePolicy.TabStop = true;
            this.linkLabel_CreatePolicy.Text = "Create a Policy";
            // 
            // linkLabel_DelinquentAccounts
            // 
            this.linkLabel_DelinquentAccounts.AutoSize = true;
            this.linkLabel_DelinquentAccounts.Location = new System.Drawing.Point(12, 118);
            this.linkLabel_DelinquentAccounts.Name = "linkLabel_DelinquentAccounts";
            this.linkLabel_DelinquentAccounts.Size = new System.Drawing.Size(106, 13);
            this.linkLabel_DelinquentAccounts.TabIndex = 3;
            this.linkLabel_DelinquentAccounts.TabStop = true;
            this.linkLabel_DelinquentAccounts.Text = "Delinquent Accounts";
            // 
            // linkLabel_Logout
            // 
            this.linkLabel_Logout.AutoSize = true;
            this.linkLabel_Logout.Location = new System.Drawing.Point(12, 144);
            this.linkLabel_Logout.Name = "linkLabel_Logout";
            this.linkLabel_Logout.Size = new System.Drawing.Size(43, 13);
            this.linkLabel_Logout.TabIndex = 4;
            this.linkLabel_Logout.TabStop = true;
            this.linkLabel_Logout.Text = "Log out";
            // 
            // label_SearchBy
            // 
            this.label_SearchBy.AutoSize = true;
            this.label_SearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SearchBy.Location = new System.Drawing.Point(200, 40);
            this.label_SearchBy.Name = "label_SearchBy";
            this.label_SearchBy.Size = new System.Drawing.Size(64, 13);
            this.label_SearchBy.TabIndex = 5;
            this.label_SearchBy.Text = "Search by";
            // 
            // label_PolicyNumber
            // 
            this.label_PolicyNumber.AutoSize = true;
            this.label_PolicyNumber.Location = new System.Drawing.Point(200, 66);
            this.label_PolicyNumber.Name = "label_PolicyNumber";
            this.label_PolicyNumber.Size = new System.Drawing.Size(75, 13);
            this.label_PolicyNumber.TabIndex = 6;
            this.label_PolicyNumber.Text = "Policy Number";
            // 
            // label_AgentFirstName
            // 
            this.label_AgentFirstName.AutoSize = true;
            this.label_AgentFirstName.Location = new System.Drawing.Point(200, 92);
            this.label_AgentFirstName.Name = "label_AgentFirstName";
            this.label_AgentFirstName.Size = new System.Drawing.Size(88, 13);
            this.label_AgentFirstName.TabIndex = 7;
            this.label_AgentFirstName.Text = "Agent First Name";
            // 
            // label_AgentLastName
            // 
            this.label_AgentLastName.AutoSize = true;
            this.label_AgentLastName.Location = new System.Drawing.Point(200, 118);
            this.label_AgentLastName.Name = "label_AgentLastName";
            this.label_AgentLastName.Size = new System.Drawing.Size(89, 13);
            this.label_AgentLastName.TabIndex = 8;
            this.label_AgentLastName.Text = "Agent Last Name";
            // 
            // label_PolicyholderFirstName
            // 
            this.label_PolicyholderFirstName.AutoSize = true;
            this.label_PolicyholderFirstName.Location = new System.Drawing.Point(200, 144);
            this.label_PolicyholderFirstName.Name = "label_PolicyholderFirstName";
            this.label_PolicyholderFirstName.Size = new System.Drawing.Size(117, 13);
            this.label_PolicyholderFirstName.TabIndex = 9;
            this.label_PolicyholderFirstName.Text = "Policyholder First Name";
            // 
            // label_PolicyholderLastName
            // 
            this.label_PolicyholderLastName.AutoSize = true;
            this.label_PolicyholderLastName.Location = new System.Drawing.Point(200, 170);
            this.label_PolicyholderLastName.Name = "label_PolicyholderLastName";
            this.label_PolicyholderLastName.Size = new System.Drawing.Size(118, 13);
            this.label_PolicyholderLastName.TabIndex = 10;
            this.label_PolicyholderLastName.Text = "Policyholder Last Name";
            // 
            // textBox_PolicyNumber
            // 
            this.textBox_PolicyNumber.Location = new System.Drawing.Point(323, 63);
            this.textBox_PolicyNumber.Name = "textBox_PolicyNumber";
            this.textBox_PolicyNumber.Size = new System.Drawing.Size(238, 20);
            this.textBox_PolicyNumber.TabIndex = 11;
            // 
            // textBox_PolicyholderFirstName
            // 
            this.textBox_PolicyholderFirstName.Location = new System.Drawing.Point(323, 141);
            this.textBox_PolicyholderFirstName.Name = "textBox_PolicyholderFirstName";
            this.textBox_PolicyholderFirstName.Size = new System.Drawing.Size(238, 20);
            this.textBox_PolicyholderFirstName.TabIndex = 14;
            // 
            // textBox_PolicyholderLastName
            // 
            this.textBox_PolicyholderLastName.Location = new System.Drawing.Point(323, 167);
            this.textBox_PolicyholderLastName.Name = "textBox_PolicyholderLastName";
            this.textBox_PolicyholderLastName.Size = new System.Drawing.Size(238, 20);
            this.textBox_PolicyholderLastName.TabIndex = 15;
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Submit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Submit.Location = new System.Drawing.Point(486, 193);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 16;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            // 
            // label_ShowAgentFirstName
            // 
            this.label_ShowAgentFirstName.AutoSize = true;
            this.label_ShowAgentFirstName.Location = new System.Drawing.Point(322, 92);
            this.label_ShowAgentFirstName.Name = "label_ShowAgentFirstName";
            this.label_ShowAgentFirstName.Size = new System.Drawing.Size(35, 13);
            this.label_ShowAgentFirstName.TabIndex = 17;
            this.label_ShowAgentFirstName.Text = "label7";
            // 
            // label_ShowAgentLastName
            // 
            this.label_ShowAgentLastName.AutoSize = true;
            this.label_ShowAgentLastName.Location = new System.Drawing.Point(322, 118);
            this.label_ShowAgentLastName.Name = "label_ShowAgentLastName";
            this.label_ShowAgentLastName.Size = new System.Drawing.Size(35, 13);
            this.label_ShowAgentLastName.TabIndex = 18;
            this.label_ShowAgentLastName.Text = "label8";
            // 
            // AgentSearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.label_ShowAgentLastName);
            this.Controls.Add(this.label_ShowAgentFirstName);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_PolicyholderLastName);
            this.Controls.Add(this.textBox_PolicyholderFirstName);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AgentSearchPage";
            this.Text = "Search Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel_Home;
        private LinkLabel linkLabel_Search;
        private LinkLabel linkLabel_CreatePolicy;
        private LinkLabel linkLabel_DelinquentAccounts;
        private LinkLabel linkLabel_Logout;
        private Label label_SearchBy;
        private Label label_PolicyNumber;
        private Label label_AgentFirstName;
        private Label label_AgentLastName;
        private Label label_PolicyholderFirstName;
        private Label label_PolicyholderLastName;
        private TextBox textBox_PolicyNumber;
        private TextBox textBox_PolicyholderFirstName;
        private TextBox textBox_PolicyholderLastName;
        private Button button_Submit;
        private Label label_ShowAgentFirstName;
        private Label label_ShowAgentLastName;
        //private Agent usingAgent;
    }
}