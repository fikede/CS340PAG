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
            this.Agent_Number_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Agent_Number_textBox = new System.Windows.Forms.TextBox();
            this.Password__textBox = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Agent_Number_Label
            // 
            this.Agent_Number_Label.AutoSize = true;
            this.Agent_Number_Label.Location = new System.Drawing.Point(192, 171);
            this.Agent_Number_Label.Name = "Agent_Number_Label";
            this.Agent_Number_Label.Size = new System.Drawing.Size(78, 13);
            this.Agent_Number_Label.TabIndex = 0;
            this.Agent_Number_Label.Text = "Agent Number:";
            this.Agent_Number_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(214, 203);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(56, 13);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Password:";
            // 
            // Agent_Number_textBox
            // 
            this.Agent_Number_textBox.Location = new System.Drawing.Point(276, 168);
            this.Agent_Number_textBox.Name = "Agent_Number_textBox";
            this.Agent_Number_textBox.Size = new System.Drawing.Size(238, 20);
            this.Agent_Number_textBox.TabIndex = 2;
            this.Agent_Number_textBox.TextChanged += new System.EventHandler(this.Agent_Number_textBox_TextChanged);
            // 
            // Password__textBox
            // 
            this.Password__textBox.Location = new System.Drawing.Point(276, 200);
            this.Password__textBox.Name = "Password__textBox";
            this.Password__textBox.Size = new System.Drawing.Size(238, 20);
            this.Password__textBox.TabIndex = 3;
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Login_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_Button.Location = new System.Drawing.Point(529, 200);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(54, 22);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password__textBox);
            this.Controls.Add(this.Agent_Number_textBox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Agent_Number_Label);
            this.Name = "Login";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Agent_Number_Label;
        private Label Password_Label;
        private TextBox Agent_Number_textBox;
        private TextBox Password__textBox;
        private Button Login_Button;
    }
}

