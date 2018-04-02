using System.Windows.Forms;
using PAG340MiddleWare;

namespace _340GUI
{
    partial class ManagerDelinquent
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
            this.Add_New_Agent = new System.Windows.Forms.LinkLabel();
            this.Log_Out = new System.Windows.Forms.LinkLabel();
            this.Delinquent_Accounts = new System.Windows.Forms.LinkLabel();
            this.Create_A_Policy = new System.Windows.Forms.LinkLabel();
            this.Search = new System.Windows.Forms.LinkLabel();
            this.Home = new System.Windows.Forms.LinkLabel();
            this.State_dropDown_Menu = new System.Windows.Forms.ComboBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Amount_Overdue_textBox = new System.Windows.Forms.TextBox();
            this.Amount_Overdue_Label = new System.Windows.Forms.Label();
            this.Agent_Last_Name_Label = new System.Windows.Forms.Label();
            this.Agent_First_Name_Label = new System.Windows.Forms.Label();
            this.State_Label = new System.Windows.Forms.Label();
            this.Delinquent_Account_Label = new System.Windows.Forms.Label();
            this.Agent_Last_Name_textBox = new System.Windows.Forms.TextBox();
            this.Agent_First_Name_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_New_Agent
            // 
            this.Add_New_Agent.AutoSize = true;
            this.Add_New_Agent.Location = new System.Drawing.Point(12, 144);
            this.Add_New_Agent.Name = "Add_New_Agent";
            this.Add_New_Agent.Size = new System.Drawing.Size(82, 13);
            this.Add_New_Agent.TabIndex = 58;
            this.Add_New_Agent.TabStop = true;
            this.Add_New_Agent.Text = "Add New Agent";
            // 
            // Log_Out
            // 
            this.Log_Out.AutoSize = true;
            this.Log_Out.Location = new System.Drawing.Point(12, 170);
            this.Log_Out.Name = "Log_Out";
            this.Log_Out.Size = new System.Drawing.Size(43, 13);
            this.Log_Out.TabIndex = 57;
            this.Log_Out.TabStop = true;
            this.Log_Out.Text = "Log out";
            // 
            // Delinquent_Accounts
            // 
            this.Delinquent_Accounts.AutoSize = true;
            this.Delinquent_Accounts.Location = new System.Drawing.Point(12, 118);
            this.Delinquent_Accounts.Name = "Delinquent_Accounts";
            this.Delinquent_Accounts.Size = new System.Drawing.Size(106, 13);
            this.Delinquent_Accounts.TabIndex = 56;
            this.Delinquent_Accounts.TabStop = true;
            this.Delinquent_Accounts.Text = "Delinquent Accounts";
            // 
            // Create_A_Policy
            // 
            this.Create_A_Policy.AutoSize = true;
            this.Create_A_Policy.Location = new System.Drawing.Point(12, 92);
            this.Create_A_Policy.Name = "Create_A_Policy";
            this.Create_A_Policy.Size = new System.Drawing.Size(78, 13);
            this.Create_A_Policy.TabIndex = 55;
            this.Create_A_Policy.TabStop = true;
            this.Create_A_Policy.Text = "Create a Policy";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(12, 66);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 54;
            this.Search.TabStop = true;
            this.Search.Text = "Search";
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Location = new System.Drawing.Point(12, 40);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(35, 13);
            this.Home.TabIndex = 53;
            this.Home.TabStop = true;
            this.Home.Text = "Home";
            this.Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // State_dropDown_Menu
            // 
            this.State_dropDown_Menu.FormattingEnabled = true;
            this.State_dropDown_Menu.Location = new System.Drawing.Point(338, 63);
            this.State_dropDown_Menu.Name = "State_dropDown_Menu";
            this.State_dropDown_Menu.Size = new System.Drawing.Size(223, 21);
            this.State_dropDown_Menu.TabIndex = 66;
            // 
            // Submit_Button
            // 
            this.Submit_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Submit_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Submit_Button.Location = new System.Drawing.Point(486, 167);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(75, 23);
            this.Submit_Button.TabIndex = 65;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = false;
            // 
            // Amount_Overdue_textBox
            // 
            this.Amount_Overdue_textBox.Location = new System.Drawing.Point(338, 141);
            this.Amount_Overdue_textBox.Name = "Amount_Overdue_textBox";
            this.Amount_Overdue_textBox.Size = new System.Drawing.Size(223, 20);
            this.Amount_Overdue_textBox.TabIndex = 64;
            // 
            // Amount_Overdue_Label
            // 
            this.Amount_Overdue_Label.AutoSize = true;
            this.Amount_Overdue_Label.Location = new System.Drawing.Point(200, 144);
            this.Amount_Overdue_Label.Name = "Amount_Overdue_Label";
            this.Amount_Overdue_Label.Size = new System.Drawing.Size(134, 13);
            this.Amount_Overdue_Label.TabIndex = 63;
            this.Amount_Overdue_Label.Text = "Amount Overdue is at least";
            // 
            // Agent_Last_Name_Label
            // 
            this.Agent_Last_Name_Label.AutoSize = true;
            this.Agent_Last_Name_Label.Location = new System.Drawing.Point(200, 118);
            this.Agent_Last_Name_Label.Name = "Agent_Last_Name_Label";
            this.Agent_Last_Name_Label.Size = new System.Drawing.Size(89, 13);
            this.Agent_Last_Name_Label.TabIndex = 62;
            this.Agent_Last_Name_Label.Text = "Agent Last Name";
            // 
            // Agent_First_Name_Label
            // 
            this.Agent_First_Name_Label.AutoSize = true;
            this.Agent_First_Name_Label.Location = new System.Drawing.Point(200, 92);
            this.Agent_First_Name_Label.Name = "Agent_First_Name_Label";
            this.Agent_First_Name_Label.Size = new System.Drawing.Size(88, 13);
            this.Agent_First_Name_Label.TabIndex = 61;
            this.Agent_First_Name_Label.Text = "Agent First Name";
            // 
            // State_Label
            // 
            this.State_Label.AutoSize = true;
            this.State_Label.Location = new System.Drawing.Point(200, 66);
            this.State_Label.Name = "State_Label";
            this.State_Label.Size = new System.Drawing.Size(32, 13);
            this.State_Label.TabIndex = 60;
            this.State_Label.Text = "State";
            // 
            // Delinquent_Account_Label
            // 
            this.Delinquent_Account_Label.AutoSize = true;
            this.Delinquent_Account_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delinquent_Account_Label.Location = new System.Drawing.Point(200, 40);
            this.Delinquent_Account_Label.Name = "Delinquent_Account_Label";
            this.Delinquent_Account_Label.Size = new System.Drawing.Size(119, 13);
            this.Delinquent_Account_Label.TabIndex = 59;
            this.Delinquent_Account_Label.Text = "Delinquent Account";
            // 
            // Agent_Last_Name_textBox
            // 
            this.Agent_Last_Name_textBox.Location = new System.Drawing.Point(338, 115);
            this.Agent_Last_Name_textBox.Name = "Agent_Last_Name_textBox";
            this.Agent_Last_Name_textBox.Size = new System.Drawing.Size(223, 20);
            this.Agent_Last_Name_textBox.TabIndex = 67;
            // 
            // Agent_First_Name__textBox
            // 
            this.Agent_First_Name_textBox.Location = new System.Drawing.Point(338, 89);
            this.Agent_First_Name_textBox.Name = "Agent_First_Name__textBox";
            this.Agent_First_Name_textBox.Size = new System.Drawing.Size(223, 20);
            this.Agent_First_Name_textBox.TabIndex = 68;
            // 
            // ManagerDelinquent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.Agent_First_Name_textBox);
            this.Controls.Add(this.Agent_Last_Name_textBox);
            this.Controls.Add(this.State_dropDown_Menu);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Amount_Overdue_textBox);
            this.Controls.Add(this.Amount_Overdue_Label);
            this.Controls.Add(this.Agent_Last_Name_Label);
            this.Controls.Add(this.Agent_First_Name_Label);
            this.Controls.Add(this.State_Label);
            this.Controls.Add(this.Delinquent_Account_Label);
            this.Controls.Add(this.Add_New_Agent);
            this.Controls.Add(this.Log_Out);
            this.Controls.Add(this.Delinquent_Accounts);
            this.Controls.Add(this.Create_A_Policy);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Home);
            this.Name = "ManagerDelinquent";
            this.Text = "ManagerDelinquent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel Add_New_Agent;
        private LinkLabel Log_Out;
        private LinkLabel Delinquent_Accounts;
        private LinkLabel Create_A_Policy;
        private LinkLabel Search;
        private LinkLabel Home;
        private ComboBox State_dropDown_Menu;
        private Button Submit_Button;
        private TextBox Amount_Overdue_textBox;
        private Label Amount_Overdue_Label;
        private Label Agent_Last_Name_Label;
        private Label Agent_First_Name_Label;
        private Label State_Label;
        private Label Delinquent_Account_Label;
        private TextBox Agent_Last_Name_textBox;
        private TextBox Agent_First_Name_textBox;
    }
}