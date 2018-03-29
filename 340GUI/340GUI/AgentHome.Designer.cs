namespace _340GUI
{
    partial class AgentHome
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
            this.Search = new System.Windows.Forms.LinkLabel();
            this.Create_A_Policy = new System.Windows.Forms.LinkLabel();
            this.Delinquent_Accounts = new System.Windows.Forms.LinkLabel();
            this.Log_Out = new System.Windows.Forms.LinkLabel();
            this.LIC_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LIC_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(109, 357);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 1;
            this.Search.TabStop = true;
            this.Search.Text = "Search";
            this.Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Create_A_Policy
            // 
            this.Create_A_Policy.AutoSize = true;
            this.Create_A_Policy.Location = new System.Drawing.Point(256, 357);
            this.Create_A_Policy.Name = "Create_A_Policy";
            this.Create_A_Policy.Size = new System.Drawing.Size(78, 13);
            this.Create_A_Policy.TabIndex = 2;
            this.Create_A_Policy.TabStop = true;
            this.Create_A_Policy.Text = "Create a Policy";
            // 
            // Delinquent_Accounts
            // 
            this.Delinquent_Accounts.AutoSize = true;
            this.Delinquent_Accounts.Location = new System.Drawing.Point(429, 357);
            this.Delinquent_Accounts.Name = "Delinquent_Accounts";
            this.Delinquent_Accounts.Size = new System.Drawing.Size(106, 13);
            this.Delinquent_Accounts.TabIndex = 3;
            this.Delinquent_Accounts.TabStop = true;
            this.Delinquent_Accounts.Text = "Delinquent Accounts";
            this.Delinquent_Accounts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Log_Out
            // 
            this.Log_Out.AutoSize = true;
            this.Log_Out.Location = new System.Drawing.Point(612, 357);
            this.Log_Out.Name = "Log_Out";
            this.Log_Out.Size = new System.Drawing.Size(43, 13);
            this.Log_Out.TabIndex = 4;
            this.Log_Out.TabStop = true;
            this.Log_Out.Text = "Log out";
            // 
            // LIC_Logo
            // 
            this.LIC_Logo.Image = global::_340GUI.Properties.Resources.LIC;
            this.LIC_Logo.ImageLocation = "";
            this.LIC_Logo.Location = new System.Drawing.Point(0, 1);
            this.LIC_Logo.Name = "LIC_Logo";
            this.LIC_Logo.Size = new System.Drawing.Size(756, 319);
            this.LIC_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LIC_Logo.TabIndex = 0;
            this.LIC_Logo.TabStop = false;
            // 
            // AgentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.Log_Out);
            this.Controls.Add(this.Delinquent_Accounts);
            this.Controls.Add(this.Create_A_Policy);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.LIC_Logo);
            this.Name = "AgentHome";
            this.Text = "Agent Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.LIC_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LIC_Logo;
        private System.Windows.Forms.LinkLabel Search;
        private System.Windows.Forms.LinkLabel Create_A_Policy;
        private System.Windows.Forms.LinkLabel Delinquent_Accounts;
        private System.Windows.Forms.LinkLabel Log_Out;
    }
}