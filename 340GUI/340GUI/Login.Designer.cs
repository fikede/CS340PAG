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
    partial class Login
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
            this.Label_AgentNumber = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.textBox_AgentNumber = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_AgentNumber
            // 
            this.Label_AgentNumber.AutoSize = true;
            this.Label_AgentNumber.Location = new System.Drawing.Point(192, 171);
            this.Label_AgentNumber.Name = "Label_AgentNumber";
            this.Label_AgentNumber.Size = new System.Drawing.Size(78, 13);
            this.Label_AgentNumber.TabIndex = 0;
            this.Label_AgentNumber.Text = "Agent Number:";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(214, 203);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(56, 13);
            this.Label_Password.TabIndex = 1;
            this.Label_Password.Text = "Password:";
            // 
            // textBox_AgentNumber
            // 
            this.textBox_AgentNumber.Location = new System.Drawing.Point(276, 168);
            this.textBox_AgentNumber.Name = "textBox_AgentNumber";
            this.textBox_AgentNumber.Size = new System.Drawing.Size(238, 20);
            this.textBox_AgentNumber.TabIndex = 2;
            this.textBox_AgentNumber.TextChanged += new System.EventHandler(this.textBox_AgentNumber_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(276, 200);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(238, 20);
            this.textBox_Password.TabIndex = 3;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Login.Location = new System.Drawing.Point(529, 200);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(54, 22);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_AgentNumber);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_AgentNumber);
            this.Name = "Login";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label_AgentNumber;
        private Label Label_Password;
        private TextBox textBox_AgentNumber;
        private TextBox textBox_Password;
        private Button button_Login;
        //private Agent usingAgent;
    }
}

