using System.Windows.Forms;
using PAG340MiddleWare;

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
            this.Login_Button = new System.Windows.Forms.Button();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Agent_Number_textBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Agent_Number_Label = new System.Windows.Forms.Label();
            this.Warning_Prompt_Label = new System.Windows.Forms.Label();
            this.Warning_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Login_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_Button.Location = new System.Drawing.Point(529, 200);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(54, 22);
            this.Login_Button.TabIndex = 9;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(276, 200);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(238, 20);
            this.Password_textBox.TabIndex = 8;
            // 
            // Agent_Number_textBox
            // 
            this.Agent_Number_textBox.Location = new System.Drawing.Point(276, 168);
            this.Agent_Number_textBox.Name = "Agent_Number_textBox";
            this.Agent_Number_textBox.Size = new System.Drawing.Size(238, 20);
            this.Agent_Number_textBox.TabIndex = 7;
            this.Agent_Number_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(214, 203);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(56, 13);
            this.Password_Label.TabIndex = 6;
            this.Password_Label.Text = "Password:";
            // 
            // Agent_Number_Label
            // 
            this.Agent_Number_Label.AutoSize = true;
            this.Agent_Number_Label.Location = new System.Drawing.Point(192, 171);
            this.Agent_Number_Label.Name = "Agent_Number_Label";
            this.Agent_Number_Label.Size = new System.Drawing.Size(78, 13);
            this.Agent_Number_Label.TabIndex = 5;
            this.Agent_Number_Label.Text = "Agent Number:";
            // 
            // Warning_Prompt_Label
            // 
            this.Warning_Prompt_Label.AutoSize = true;
            this.Warning_Prompt_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Warning_Prompt_Label.Location = new System.Drawing.Point(296, 223);
            this.Warning_Prompt_Label.Name = "Warning_Prompt_Label";
            this.Warning_Prompt_Label.Size = new System.Drawing.Size(218, 13);
            this.Warning_Prompt_Label.TabIndex = 10;
            this.Warning_Prompt_Label.Text = "Your Agent Number or Password is incorrect!";
            // 
            // Warning_Image
            // 
            this.Warning_Image.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Warning_Image.Image = global::_340GUI.Properties.Resources.warning;
            this.Warning_Image.Location = new System.Drawing.Point(283, 220);
            this.Warning_Image.Name = "Warning_Image";
            this.Warning_Image.Size = new System.Drawing.Size(16, 16);
            this.Warning_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Warning_Image.TabIndex = 11;
            this.Warning_Image.TabStop = false;
            // 
            // FailToLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.Warning_Image);
            this.Controls.Add(this.Warning_Prompt_Label);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Agent_Number_textBox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Agent_Number_Label);
            this.Name = "FailToLogin";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.FailToLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Login_Button;
        private TextBox Password_textBox;
        private TextBox Agent_Number_textBox;
        private Label Password_Label;
        private Label Agent_Number_Label;
        private Label Warning_Prompt_Label;
        private PictureBox Warning_Image;
    }
}