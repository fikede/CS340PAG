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
    partial class AddNewAgent
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
            this.comboBox_Department = new System.Windows.Forms.ComboBox();
            this.comboBox_UserType = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Submit = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_AgentLastName = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_AgentFirstName = new System.Windows.Forms.TextBox();
            this.label_Department = new System.Windows.Forms.Label();
            this.label_UserType = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_AgentLastName = new System.Windows.Forms.Label();
            this.label_AgentFirstName = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_AgentNumber = new System.Windows.Forms.Label();
            this.label_AddNewAgent = new System.Windows.Forms.Label();
            this.label_ShowAgentNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Department
            // 
            this.comboBox_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Department.FormattingEnabled = true;
            this.comboBox_Department.Items.AddRange(new object[] {
            "Claims",
            "Customer Service",
            "Finance",
            "Freelancer",
            "Human Resources",
            "Legal",
            "Marketing",
            "Obfuscation",
            "Sales"});
            this.comboBox_Department.Location = new System.Drawing.Point(296, 251);
            this.comboBox_Department.Name = "comboBox_Department";
            this.comboBox_Department.Size = new System.Drawing.Size(261, 21);
            this.comboBox_Department.TabIndex = 33;
            // 
            // comboBox_UserType
            // 
            this.comboBox_UserType.AutoCompleteCustomSource.AddRange(new string[] {
            "Agent"});
            this.comboBox_UserType.DisplayMember = "Agent";
            this.comboBox_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UserType.FormattingEnabled = true;
            this.comboBox_UserType.Items.AddRange(new object[] {
            "Manager",
            "Agent"});
            this.comboBox_UserType.Location = new System.Drawing.Point(296, 224);
            this.comboBox_UserType.Name = "comboBox_UserType";
            this.comboBox_UserType.Size = new System.Drawing.Size(261, 21);
            this.comboBox_UserType.TabIndex = 32;
            this.comboBox_UserType.ValueMember = "Agent";
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Cancel.Location = new System.Drawing.Point(455, 320);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(105, 33);
            this.button_Cancel.TabIndex = 35;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Submit
            // 
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Submit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Submit.Location = new System.Drawing.Point(237, 320);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(105, 33);
            this.button_Submit.TabIndex = 34;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(296, 198);
            this.textBox_Password.MaxLength = 255;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(261, 20);
            this.textBox_Password.TabIndex = 30;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_AgentLastName
            // 
            this.textBox_AgentLastName.Location = new System.Drawing.Point(296, 172);
            this.textBox_AgentLastName.MaxLength = 100;
            this.textBox_AgentLastName.Name = "textBox_AgentLastName";
            this.textBox_AgentLastName.Size = new System.Drawing.Size(261, 20);
            this.textBox_AgentLastName.TabIndex = 29;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(296, 120);
            this.textBox_Username.MaxLength = 20;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(261, 20);
            this.textBox_Username.TabIndex = 26;
            // 
            // textBox_AgentFirstName
            // 
            this.textBox_AgentFirstName.Location = new System.Drawing.Point(296, 146);
            this.textBox_AgentFirstName.MaxLength = 100;
            this.textBox_AgentFirstName.Name = "textBox_AgentFirstName";
            this.textBox_AgentFirstName.Size = new System.Drawing.Size(261, 20);
            this.textBox_AgentFirstName.TabIndex = 27;
            // 
            // label_Department
            // 
            this.label_Department.AutoSize = true;
            this.label_Department.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Department.Location = new System.Drawing.Point(225, 254);
            this.label_Department.Name = "label_Department";
            this.label_Department.Size = new System.Drawing.Size(65, 13);
            this.label_Department.TabIndex = 28;
            this.label_Department.Text = "Department:";
            // 
            // label_UserType
            // 
            this.label_UserType.AutoSize = true;
            this.label_UserType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_UserType.Location = new System.Drawing.Point(232, 227);
            this.label_UserType.Name = "label_UserType";
            this.label_UserType.Size = new System.Drawing.Size(59, 13);
            this.label_UserType.TabIndex = 24;
            this.label_UserType.Text = "User Type:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Password.Location = new System.Drawing.Point(235, 201);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(56, 13);
            this.label_Password.TabIndex = 23;
            this.label_Password.Text = "Password:";
            // 
            // label_AgentLastName
            // 
            this.label_AgentLastName.AutoSize = true;
            this.label_AgentLastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_AgentLastName.Location = new System.Drawing.Point(198, 175);
            this.label_AgentLastName.Name = "label_AgentLastName";
            this.label_AgentLastName.Size = new System.Drawing.Size(92, 13);
            this.label_AgentLastName.TabIndex = 22;
            this.label_AgentLastName.Text = "Agent Last Name:";
            // 
            // label_AgentFirstName
            // 
            this.label_AgentFirstName.AutoSize = true;
            this.label_AgentFirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_AgentFirstName.Location = new System.Drawing.Point(200, 149);
            this.label_AgentFirstName.Name = "label_AgentFirstName";
            this.label_AgentFirstName.Size = new System.Drawing.Size(91, 13);
            this.label_AgentFirstName.TabIndex = 21;
            this.label_AgentFirstName.Text = "Agent First Name:";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Username.Location = new System.Drawing.Point(232, 123);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(58, 13);
            this.label_Username.TabIndex = 20;
            this.label_Username.Text = "Username:";
            // 
            // label_AgentNumber
            // 
            this.label_AgentNumber.AutoSize = true;
            this.label_AgentNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_AgentNumber.Location = new System.Drawing.Point(212, 100);
            this.label_AgentNumber.Name = "label_AgentNumber";
            this.label_AgentNumber.Size = new System.Drawing.Size(78, 13);
            this.label_AgentNumber.TabIndex = 19;
            this.label_AgentNumber.Text = "Agent Number:";
            // 
            // label_AddNewAgent
            // 
            this.label_AddNewAgent.AutoSize = true;
            this.label_AddNewAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label_AddNewAgent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_AddNewAgent.Location = new System.Drawing.Point(326, 59);
            this.label_AddNewAgent.Name = "label_AddNewAgent";
            this.label_AddNewAgent.Size = new System.Drawing.Size(95, 13);
            this.label_AddNewAgent.TabIndex = 18;
            this.label_AddNewAgent.Text = "Add New Agent";
            // 
            // label_ShowAgentNumber
            // 
            this.label_ShowAgentNumber.AutoSize = true;
            this.label_ShowAgentNumber.Location = new System.Drawing.Point(298, 100);
            this.label_ShowAgentNumber.Name = "label_ShowAgentNumber";
            this.label_ShowAgentNumber.Size = new System.Drawing.Size(41, 13);
            this.label_ShowAgentNumber.TabIndex = 36;
            this.label_ShowAgentNumber.Text = "label10";
            // 
            // AddNewAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.label_ShowAgentNumber);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.comboBox_Department);
            this.Controls.Add(this.comboBox_UserType);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_AgentLastName);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_AgentFirstName);
            this.Controls.Add(this.label_Department);
            this.Controls.Add(this.label_UserType);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_AgentLastName);
            this.Controls.Add(this.label_AgentFirstName);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_AgentNumber);
            this.Controls.Add(this.label_AddNewAgent);
            this.Name = "AddNewAgent";
            this.Text = "Add New Agent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Cancel;
        private Button button_Submit;
        private TextBox textBox_Password;
        private TextBox textBox_AgentLastName;
        private TextBox textBox_Username;
        private TextBox textBox_AgentFirstName;
        private Label label_Department;
        private Label label_UserType;
        private Label label_Password;
        private Label label_AgentLastName;
        private Label label_AgentFirstName;
        private Label label_Username;
        private Label label_AgentNumber;
        private Label label_AddNewAgent;
        private Label label_ShowAgentNumber;
        private Manager usingManager;
        private ComboBox comboBox_Department;
        private ComboBox comboBox_UserType;
    }
}