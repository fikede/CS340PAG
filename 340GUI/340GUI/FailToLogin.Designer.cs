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
    partial class FailToLogin
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
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_AgentNumber = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_AgentNumber = new System.Windows.Forms.Label();
            this.label_WarningComment = new System.Windows.Forms.Label();
            this.pictureBox_Warning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Login.Location = new System.Drawing.Point(529, 200);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(54, 22);
            this.button_Login.TabIndex = 9;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(276, 200);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(238, 20);
            this.textBox_Password.TabIndex = 8;
            // 
            // textBox_AgentNumber
            // 
            this.textBox_AgentNumber.Location = new System.Drawing.Point(276, 168);
            this.textBox_AgentNumber.Name = "textBox_AgentNumber";
            this.textBox_AgentNumber.Size = new System.Drawing.Size(238, 20);
            this.textBox_AgentNumber.TabIndex = 7;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(214, 203);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(56, 13);
            this.label_Password.TabIndex = 6;
            this.label_Password.Text = "Password:";
            // 
            // label_AgentNumber
            // 
            this.label_AgentNumber.AutoSize = true;
            this.label_AgentNumber.Location = new System.Drawing.Point(192, 171);
            this.label_AgentNumber.Name = "label_AgentNumber";
            this.label_AgentNumber.Size = new System.Drawing.Size(78, 13);
            this.label_AgentNumber.TabIndex = 5;
            this.label_AgentNumber.Text = "Agent Number:";
            // 
            // label_WarningComment
            // 
            this.label_WarningComment.AutoSize = true;
            this.label_WarningComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_WarningComment.Location = new System.Drawing.Point(296, 223);
            this.label_WarningComment.Name = "label_WarningComment";
            this.label_WarningComment.Size = new System.Drawing.Size(218, 13);
            this.label_WarningComment.TabIndex = 10;
            this.label_WarningComment.Text = "Your Agent Number or Password is incorrect!";
            // 
            // pictureBox_Warning
            // 
            this.pictureBox_Warning.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox_Warning.Image = global::_340GUI.Properties.Resources.warning;
            this.pictureBox_Warning.Location = new System.Drawing.Point(283, 220);
            this.pictureBox_Warning.Name = "pictureBox_Warning";
            this.pictureBox_Warning.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Warning.TabIndex = 11;
            this.pictureBox_Warning.TabStop = false;
            // 
            // FailToLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.pictureBox_Warning);
            this.Controls.Add(this.label_WarningComment);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_AgentNumber);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_AgentNumber);
            this.Name = "FailToLogin";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.FailToLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Login;
        private TextBox textBox_Password;
        private TextBox textBox_AgentNumber;
        private Label label_Password;
        private Label label_AgentNumber;
        private Label label_WarningComment;
        private PictureBox pictureBox_Warning;
        //private Agent usingAgent;
    }
}