using System.Windows.Forms;

namespace _340GUI
{
    partial class ManagerHome
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
            this.Create_A_Policy_Label = new System.Windows.Forms.LinkLabel();
            this.Search_Label = new System.Windows.Forms.LinkLabel();
            this.Add_New_Agent_Label = new System.Windows.Forms.LinkLabel();
            this.LIC_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LIC_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Log_Out_Label
            // 
            this.Log_Out_Label.AutoSize = true;
            this.Log_Out_Label.Location = new System.Drawing.Point(645, 357);
            this.Log_Out_Label.Name = "Log_Out_Label";
            this.Log_Out_Label.Size = new System.Drawing.Size(43, 13);
            this.Log_Out_Label.TabIndex = 8;
            this.Log_Out_Label.TabStop = true;
            this.Log_Out_Label.Text = "Log out";
            // 
            // Delinquent_Accounts_Label
            // 
            this.Delinquent_Accounts_Label.AutoSize = true;
            this.Delinquent_Accounts_Label.Location = new System.Drawing.Point(333, 357);
            this.Delinquent_Accounts_Label.Name = "Delinquent_Accounts_Label";
            this.Delinquent_Accounts_Label.Size = new System.Drawing.Size(106, 13);
            this.Delinquent_Accounts_Label.TabIndex = 7;
            this.Delinquent_Accounts_Label.TabStop = true;
            this.Delinquent_Accounts_Label.Text = "Delinquent Accounts";
            // 
            // Create_A_Policy_Label
            // 
            this.Create_A_Policy_Label.AutoSize = true;
            this.Create_A_Policy_Label.Location = new System.Drawing.Point(185, 357);
            this.Create_A_Policy_Label.Name = "Create_A_Policy_Label";
            this.Create_A_Policy_Label.Size = new System.Drawing.Size(78, 13);
            this.Create_A_Policy_Label.TabIndex = 6;
            this.Create_A_Policy_Label.TabStop = true;
            this.Create_A_Policy_Label.Text = "Create a Policy";
            this.Create_A_Policy_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Location = new System.Drawing.Point(71, 357);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(41, 13);
            this.Search_Label.TabIndex = 5;
            this.Search_Label.TabStop = true;
            this.Search_Label.Text = "Search";
            // 
            // Add_New_Agent_Label
            // 
            this.Add_New_Agent_Label.AutoSize = true;
            this.Add_New_Agent_Label.Location = new System.Drawing.Point(501, 357);
            this.Add_New_Agent_Label.Name = "Add_New_Agent_Label";
            this.Add_New_Agent_Label.Size = new System.Drawing.Size(82, 13);
            this.Add_New_Agent_Label.TabIndex = 9;
            this.Add_New_Agent_Label.TabStop = true;
            this.Add_New_Agent_Label.Text = "Add New Agent";
            // 
            // LIC_Logo
            // 
            this.LIC_Logo.Image = global::_340GUI.Properties.Resources.LIC;
            this.LIC_Logo.ImageLocation = "";
            this.LIC_Logo.Location = new System.Drawing.Point(0, 1);
            this.LIC_Logo.Name = "LIC_Logo";
            this.LIC_Logo.Size = new System.Drawing.Size(756, 319);
            this.LIC_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LIC_Logo.TabIndex = 10;
            this.LIC_Logo.TabStop = false;
            this.LIC_Logo.Click += new System.EventHandler(this.LIC_Logo_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.LIC_Logo);
            this.Controls.Add(this.Add_New_Agent_Label);
            this.Controls.Add(this.Log_Out_Label);
            this.Controls.Add(this.Delinquent_Accounts_Label);
            this.Controls.Add(this.Create_A_Policy_Label);
            this.Controls.Add(this.Search_Label);
            this.Name = "ManagerHome";
            this.Text = "Manager Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.LIC_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel Log_Out_Label;
        private LinkLabel Delinquent_Accounts_Label;
        private LinkLabel Create_A_Policy_Label;
        private LinkLabel Search_Label;
        private LinkLabel Add_New_Agent_Label;
        private PictureBox LIC_Logo;
    }
}