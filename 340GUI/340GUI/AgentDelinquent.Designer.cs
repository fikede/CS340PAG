using System.Windows.Forms;
using PAG340MiddleWare;

namespace _340GUI
{
    partial class AgentDelinquent
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
            this.Log_Out_Label = new System.Windows.Forms.LinkLabel();
            this.Delinquent_Accounts_Label = new System.Windows.Forms.LinkLabel();
            this.Creat_A_Policy_Label = new System.Windows.Forms.LinkLabel();
            this.Search_Label = new System.Windows.Forms.LinkLabel();
            this.Home_Label = new System.Windows.Forms.LinkLabel();
            this.Delinquent_Account_Label = new System.Windows.Forms.Label();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Amount_Overdue_isAt_Least_textBox = new System.Windows.Forms.TextBox();
            this.Amount_Overdue_isAt_Least = new System.Windows.Forms.Label();
            this.Agent_Last_Name_Label = new System.Windows.Forms.Label();
            this.Agent_First_Name_Label = new System.Windows.Forms.Label();
            this.State_Label = new System.Windows.Forms.Label();
            this.State_dropDown_Menu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Log_Out_Label
            // 
            this.Log_Out_Label.AutoSize = true;
            this.Log_Out_Label.Location = new System.Drawing.Point(12, 144);
            this.Log_Out_Label.Name = "Log_Out_Label";
            this.Log_Out_Label.Size = new System.Drawing.Size(43, 13);
            this.Log_Out_Label.TabIndex = 26;
            this.Log_Out_Label.TabStop = true;
            this.Log_Out_Label.Text = "Log out";
            // 
            // Delinquent_Accounts_Label
            // 
            this.Delinquent_Accounts_Label.AutoSize = true;
            this.Delinquent_Accounts_Label.Location = new System.Drawing.Point(12, 118);
            this.Delinquent_Accounts_Label.Name = "Delinquent_Accounts_Label";
            this.Delinquent_Accounts_Label.Size = new System.Drawing.Size(106, 13);
            this.Delinquent_Accounts_Label.TabIndex = 25;
            this.Delinquent_Accounts_Label.TabStop = true;
            this.Delinquent_Accounts_Label.Text = "Delinquent Accounts";
            // 
            // Creat_A_Policy_Label
            // 
            this.Creat_A_Policy_Label.AutoSize = true;
            this.Creat_A_Policy_Label.Location = new System.Drawing.Point(12, 92);
            this.Creat_A_Policy_Label.Name = "Creat_A_Policy_Label";
            this.Creat_A_Policy_Label.Size = new System.Drawing.Size(78, 13);
            this.Creat_A_Policy_Label.TabIndex = 24;
            this.Creat_A_Policy_Label.TabStop = true;
            this.Creat_A_Policy_Label.Text = "Create a Policy";
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Location = new System.Drawing.Point(12, 66);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(41, 13);
            this.Search_Label.TabIndex = 23;
            this.Search_Label.TabStop = true;
            this.Search_Label.Text = "Search";
            // 
            // Home_Label
            // 
            this.Home_Label.AutoSize = true;
            this.Home_Label.Location = new System.Drawing.Point(12, 40);
            this.Home_Label.Name = "Home_Label";
            this.Home_Label.Size = new System.Drawing.Size(35, 13);
            this.Home_Label.TabIndex = 22;
            this.Home_Label.TabStop = true;
            this.Home_Label.Text = "Home";
            // 
            // Delinquent_Account_Label
            // 
            this.Delinquent_Account_Label.AutoSize = true;
            this.Delinquent_Account_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delinquent_Account_Label.Location = new System.Drawing.Point(200, 40);
            this.Delinquent_Account_Label.Name = "Delinquent_Account_Label";
            this.Delinquent_Account_Label.Size = new System.Drawing.Size(119, 13);
            this.Delinquent_Account_Label.TabIndex = 27;
            this.Delinquent_Account_Label.Text = "Delinquent Account";
            // 
            // Submit_Button
            // 
            this.Submit_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Submit_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Submit_Button.Location = new System.Drawing.Point(486, 167);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(75, 23);
            this.Submit_Button.TabIndex = 42;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = false;
            // 
            // Amount_Overdue_isAt_Least_textBox
            // 
            this.Amount_Overdue_isAt_Least_textBox.Location = new System.Drawing.Point(338, 141);
            this.Amount_Overdue_isAt_Least_textBox.Name = "Amount_Overdue_isAt_Least_textBox";
            this.Amount_Overdue_isAt_Least_textBox.Size = new System.Drawing.Size(223, 20);
            this.Amount_Overdue_isAt_Least_textBox.TabIndex = 40;
            this.Amount_Overdue_isAt_Least_textBox.TextChanged += new System.EventHandler(this.Amount_Overdue_isAt_Least_textBox_TextChanged);
            // 
            // Amount_Overdue_isAt_Least
            // 
            this.Amount_Overdue_isAt_Least.AutoSize = true;
            this.Amount_Overdue_isAt_Least.Location = new System.Drawing.Point(200, 144);
            this.Amount_Overdue_isAt_Least.Name = "Amount_Overdue_isAt_Least";
            this.Amount_Overdue_isAt_Least.Size = new System.Drawing.Size(134, 13);
            this.Amount_Overdue_isAt_Least.TabIndex = 37;
            this.Amount_Overdue_isAt_Least.Text = "Amount Overdue is at least";
            // 
            // Agent_Last_Name_Label
            // 
            this.Agent_Last_Name_Label.AutoSize = true;
            this.Agent_Last_Name_Label.Location = new System.Drawing.Point(200, 118);
            this.Agent_Last_Name_Label.Name = "Agent_Last_Name_Label";
            this.Agent_Last_Name_Label.Size = new System.Drawing.Size(89, 13);
            this.Agent_Last_Name_Label.TabIndex = 36;
            this.Agent_Last_Name_Label.Text = "Agent Last Name";
            // 
            // Agent_First_Name_Label
            // 
            this.Agent_First_Name_Label.AutoSize = true;
            this.Agent_First_Name_Label.Location = new System.Drawing.Point(200, 92);
            this.Agent_First_Name_Label.Name = "Agent_First_Name_Label";
            this.Agent_First_Name_Label.Size = new System.Drawing.Size(88, 13);
            this.Agent_First_Name_Label.TabIndex = 35;
            this.Agent_First_Name_Label.Text = "Agent First Name";
            // 
            // State_Label
            // 
            this.State_Label.AutoSize = true;
            this.State_Label.Location = new System.Drawing.Point(200, 66);
            this.State_Label.Name = "State_Label";
            this.State_Label.Size = new System.Drawing.Size(32, 13);
            this.State_Label.TabIndex = 34;
            this.State_Label.Text = "State";
            // 
            // State_dropDown_Menu
            // 
            this.State_dropDown_Menu.FormattingEnabled = true;
            this.State_dropDown_Menu.Location = new System.Drawing.Point(338, 63);
            this.State_dropDown_Menu.Name = "State_dropDown_Menu";
            this.State_dropDown_Menu.Size = new System.Drawing.Size(223, 21);
            this.State_dropDown_Menu.TabIndex = 43;
            // 
            // AgentDelinquent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.State_dropDown_Menu);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Amount_Overdue_isAt_Least_textBox);
            this.Controls.Add(this.Amount_Overdue_isAt_Least);
            this.Controls.Add(this.Agent_Last_Name_Label);
            this.Controls.Add(this.Agent_First_Name_Label);
            this.Controls.Add(this.State_Label);
            this.Controls.Add(this.Delinquent_Account_Label);
            this.Controls.Add(this.Log_Out_Label);
            this.Controls.Add(this.Delinquent_Accounts_Label);
            this.Controls.Add(this.Creat_A_Policy_Label);
            this.Controls.Add(this.Search_Label);
            this.Controls.Add(this.Home_Label);
            this.Name = "AgentDelinquent";
            this.Text = "AgentDelinquent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel Log_Out_Label;
        private LinkLabel Delinquent_Accounts_Label;
        private LinkLabel Creat_A_Policy_Label;
        private LinkLabel Search_Label;
        private LinkLabel Home_Label;
        private Label Delinquent_Account_Label;
        private Button Submit_Button;
        private TextBox Amount_Overdue_isAt_Least_textBox;
        private Label Amount_Overdue_isAt_Least;
        private Label Agent_Last_Name_Label;
        private Label Agent_First_Name_Label;
        private Label State_Label;
        private ComboBox State_dropDown_Menu;
    }
}