using System.Windows.Forms;
using PAG340MiddleWare;

namespace _340GUI
{
    partial class MakeClaim
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.Input_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Button.Location = new System.Drawing.Point(186, 119);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(93, 32);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Confirm_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Confirm_Button.Location = new System.Drawing.Point(43, 119);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(93, 32);
            this.Confirm_Button.TabIndex = 6;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            // 
            // Input_Label
            // 
            this.Input_Label.AutoSize = true;
            this.Input_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Label.Location = new System.Drawing.Point(117, 67);
            this.Input_Label.Name = "Input_Label";
            this.Input_Label.Size = new System.Drawing.Size(90, 16);
            this.Input_Label.TabIndex = 4;
            this.Input_Label.Text = "Make a Claim";
            // 
            // MakeClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(322, 187);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.Input_Label);
            this.Name = "MakeClaim";
            this.Text = "MakeClaim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel_Button;
        private Button Confirm_Button;
        private Label Input_Label;
    }
}