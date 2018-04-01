using System.Windows.Forms;
namespace _340GUI
{
    partial class AgentFailToSearch
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
            this.Policy_Number_textBox = new System.Windows.Forms.TextBox();
            this.Policyholder_Last_Name_Label = new System.Windows.Forms.Label();
            this.Policyholder_First_Name_Label = new System.Windows.Forms.Label();
            this.Agent_Last_Name_Label = new System.Windows.Forms.Label();
            this.Agent_First_Name_Label = new System.Windows.Forms.Label();
            this.Policy_Number_Label = new System.Windows.Forms.Label();
            this.Search_by_Label = new System.Windows.Forms.Label();
            this.Log_Out_Label = new System.Windows.Forms.LinkLabel();
            this.Delinquent_Accounts_Label = new System.Windows.Forms.LinkLabel();
            this.Create_A_Policy_Label = new System.Windows.Forms.LinkLabel();
            this.Search_Label = new System.Windows.Forms.LinkLabel();
            this.Home_Label = new System.Windows.Forms.LinkLabel();
            this.Invalid_Input_Warning_Label = new System.Windows.Forms.Label();
            this.Warning_Label = new System.Windows.Forms.Label();
            this.Warning_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).BeginInit();
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
            // 
            // Policyholder_Last_Name_textBox
            // 
            this.Policyholder_Last_Name_textBox.Location = new System.Drawing.Point(323, 167);
            this.Policyholder_Last_Name_textBox.Name = "Policyholder_Last_Name_textBox";
            this.Policyholder_Last_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policyholder_Last_Name_textBox.TabIndex = 32;
            // 
            // Policyholder_First_Name_textBox
            // 
            this.Policyholder_First_Name_textBox.Location = new System.Drawing.Point(323, 141);
            this.Policyholder_First_Name_textBox.Name = "Policyholder_First_Name_textBox";
            this.Policyholder_First_Name_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policyholder_First_Name_textBox.TabIndex = 31;
            // 
            // Policy_Number_textBox
            // 
            this.Policy_Number_textBox.Location = new System.Drawing.Point(323, 63);
            this.Policy_Number_textBox.Name = "Policy_Number_textBox";
            this.Policy_Number_textBox.Size = new System.Drawing.Size(238, 20);
            this.Policy_Number_textBox.TabIndex = 28;
            // 
            // Policyholder_Last_Name_Label
            // 
            this.Policyholder_Last_Name_Label.AutoSize = true;
            this.Policyholder_Last_Name_Label.Location = new System.Drawing.Point(200, 170);
            this.Policyholder_Last_Name_Label.Name = "Policyholder_Last_Name_Label";
            this.Policyholder_Last_Name_Label.Size = new System.Drawing.Size(118, 13);
            this.Policyholder_Last_Name_Label.TabIndex = 27;
            this.Policyholder_Last_Name_Label.Text = "Policyholder Last Name";
            // 
            // Policyholder_First_Name_Label
            // 
            this.Policyholder_First_Name_Label.AutoSize = true;
            this.Policyholder_First_Name_Label.Location = new System.Drawing.Point(200, 144);
            this.Policyholder_First_Name_Label.Name = "Policyholder_First_Name_Label";
            this.Policyholder_First_Name_Label.Size = new System.Drawing.Size(117, 13);
            this.Policyholder_First_Name_Label.TabIndex = 26;
            this.Policyholder_First_Name_Label.Text = "Policyholder First Name";
            // 
            // Agent_Last_Name_Label
            // 
            this.Agent_Last_Name_Label.AutoSize = true;
            this.Agent_Last_Name_Label.Location = new System.Drawing.Point(200, 118);
            this.Agent_Last_Name_Label.Name = "Agent_Last_Name_Label";
            this.Agent_Last_Name_Label.Size = new System.Drawing.Size(89, 13);
            this.Agent_Last_Name_Label.TabIndex = 25;
            this.Agent_Last_Name_Label.Text = "Agent Last Name";
            // 
            // Agent_First_Name_Label
            // 
            this.Agent_First_Name_Label.AutoSize = true;
            this.Agent_First_Name_Label.Location = new System.Drawing.Point(200, 92);
            this.Agent_First_Name_Label.Name = "Agent_First_Name_Label";
            this.Agent_First_Name_Label.Size = new System.Drawing.Size(88, 13);
            this.Agent_First_Name_Label.TabIndex = 24;
            this.Agent_First_Name_Label.Text = "Agent First Name";
            // 
            // Policy_Number_Label
            // 
            this.Policy_Number_Label.AutoSize = true;
            this.Policy_Number_Label.Location = new System.Drawing.Point(200, 66);
            this.Policy_Number_Label.Name = "Policy_Number_Label";
            this.Policy_Number_Label.Size = new System.Drawing.Size(75, 13);
            this.Policy_Number_Label.TabIndex = 23;
            this.Policy_Number_Label.Text = "Policy Number";
            // 
            // Search_by_Label
            // 
            this.Search_by_Label.AutoSize = true;
            this.Search_by_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_by_Label.Location = new System.Drawing.Point(200, 40);
            this.Search_by_Label.Name = "Search_by_Label";
            this.Search_by_Label.Size = new System.Drawing.Size(64, 13);
            this.Search_by_Label.TabIndex = 22;
            this.Search_by_Label.Text = "Search by";
            this.Search_by_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Log_Out_Label
            // 
            this.Log_Out_Label.AutoSize = true;
            this.Log_Out_Label.Location = new System.Drawing.Point(12, 144);
            this.Log_Out_Label.Name = "Log_Out_Label";
            this.Log_Out_Label.Size = new System.Drawing.Size(43, 13);
            this.Log_Out_Label.TabIndex = 21;
            this.Log_Out_Label.TabStop = true;
            this.Log_Out_Label.Text = "Log out";
            this.Log_Out_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Log_Out_Label_LinkClicked);
            // 
            // Delinquent_Accounts_Label
            // 
            this.Delinquent_Accounts_Label.AutoSize = true;
            this.Delinquent_Accounts_Label.Location = new System.Drawing.Point(12, 118);
            this.Delinquent_Accounts_Label.Name = "Delinquent_Accounts_Label";
            this.Delinquent_Accounts_Label.Size = new System.Drawing.Size(106, 13);
            this.Delinquent_Accounts_Label.TabIndex = 20;
            this.Delinquent_Accounts_Label.TabStop = true;
            this.Delinquent_Accounts_Label.Text = "Delinquent Accounts";
            // 
            // Create_A_Policy_Label
            // 
            this.Create_A_Policy_Label.AutoSize = true;
            this.Create_A_Policy_Label.Location = new System.Drawing.Point(12, 92);
            this.Create_A_Policy_Label.Name = "Create_A_Policy_Label";
            this.Create_A_Policy_Label.Size = new System.Drawing.Size(78, 13);
            this.Create_A_Policy_Label.TabIndex = 19;
            this.Create_A_Policy_Label.TabStop = true;
            this.Create_A_Policy_Label.Text = "Create a Policy";
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Location = new System.Drawing.Point(12, 66);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(41, 13);
            this.Search_Label.TabIndex = 18;
            this.Search_Label.TabStop = true;
            this.Search_Label.Text = "Search";
            // 
            // Home_Label
            // 
            this.Home_Label.AutoSize = true;
            this.Home_Label.Location = new System.Drawing.Point(12, 40);
            this.Home_Label.Name = "Home_Label";
            this.Home_Label.Size = new System.Drawing.Size(35, 13);
            this.Home_Label.TabIndex = 17;
            this.Home_Label.TabStop = true;
            this.Home_Label.Text = "Home";
            // 
            // Invalid_Input_Warning_Label
            // 
            this.Invalid_Input_Warning_Label.AutoSize = true;
            this.Invalid_Input_Warning_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Invalid_Input_Warning_Label.Location = new System.Drawing.Point(232, 219);
            this.Invalid_Input_Warning_Label.Name = "Invalid_Input_Warning_Label";
            this.Invalid_Input_Warning_Label.Size = new System.Drawing.Size(279, 13);
            this.Invalid_Input_Warning_Label.TabIndex = 34;
            this.Invalid_Input_Warning_Label.Text = "Invalid input. Please enter a valid Policyholder First Name,";
            // 
            // Warning_Label
            // 
            this.Warning_Label.AutoSize = true;
            this.Warning_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Warning_Label.Location = new System.Drawing.Point(232, 232);
            this.Warning_Label.Name = "Warning_Label";
            this.Warning_Label.Size = new System.Drawing.Size(207, 13);
            this.Warning_Label.TabIndex = 35;
            this.Warning_Label.Text = "Policyholder Last Name, or Policy Number.";
            // 
            // Warning_Image
            // 
            this.Warning_Image.Image = global::_340GUI.Properties.Resources.warning;
            this.Warning_Image.Location = new System.Drawing.Point(214, 216);
            this.Warning_Image.Name = "Warning_Image";
            this.Warning_Image.Size = new System.Drawing.Size(16, 21);
            this.Warning_Image.TabIndex = 36;
            this.Warning_Image.TabStop = false;
            // 
            // AgentFailToSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.Warning_Image);
            this.Controls.Add(this.Warning_Label);
            this.Controls.Add(this.Invalid_Input_Warning_Label);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Policyholder_Last_Name_textBox);
            this.Controls.Add(this.Policyholder_First_Name_textBox);
            this.Controls.Add(this.Policy_Number_textBox);
            this.Controls.Add(this.Policyholder_Last_Name_Label);
            this.Controls.Add(this.Policyholder_First_Name_Label);
            this.Controls.Add(this.Agent_Last_Name_Label);
            this.Controls.Add(this.Agent_First_Name_Label);
            this.Controls.Add(this.Policy_Number_Label);
            this.Controls.Add(this.Search_by_Label);
            this.Controls.Add(this.Log_Out_Label);
            this.Controls.Add(this.Delinquent_Accounts_Label);
            this.Controls.Add(this.Create_A_Policy_Label);
            this.Controls.Add(this.Search_Label);
            this.Controls.Add(this.Home_Label);
            this.Name = "AgentFailToSearch";
            this.Text = "AgentFailToSearch";
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Submit_Button;
        private TextBox Policyholder_Last_Name_textBox;
        private TextBox Policyholder_First_Name_textBox;
        private TextBox Policy_Number_textBox;
        private Label Policyholder_Last_Name_Label;
        private Label Policyholder_First_Name_Label;
        private Label Agent_Last_Name_Label;
        private Label Agent_First_Name_Label;
        private Label Policy_Number_Label;
        private Label Search_by_Label;
        private LinkLabel Log_Out_Label;
        private LinkLabel Delinquent_Accounts_Label;
        private LinkLabel Create_A_Policy_Label;
        private LinkLabel Search_Label;
        private LinkLabel Home_Label;
        private Label Invalid_Input_Warning_Label;
        private Label Warning_Label;
        private PictureBox Warning_Image;
    }
}