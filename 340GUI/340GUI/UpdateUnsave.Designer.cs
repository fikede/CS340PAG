using System.Windows.Forms;
using PAG340MiddleWare;

namespace _340GUI
{
    partial class UpdateUnsave
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
            this.Save_Button = new System.Windows.Forms.Button();
            this.Warning_Continued_Label = new System.Windows.Forms.Label();
            this.Unsaved_Changes_Warning_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Button.Location = new System.Drawing.Point(220, 106);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(93, 32);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Save_Button
            // 
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save_Button.Location = new System.Drawing.Point(54, 106);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(93, 32);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Warning_Continued_Label
            // 
            this.Warning_Continued_Label.AutoSize = true;
            this.Warning_Continued_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning_Continued_Label.Location = new System.Drawing.Point(125, 69);
            this.Warning_Continued_Label.Name = "Warning_Continued_Label";
            this.Warning_Continued_Label.Size = new System.Drawing.Size(123, 16);
            this.Warning_Continued_Label.TabIndex = 5;
            this.Warning_Continued_Label.Text = "unsaved changed?";
            // 
            // Unsaved_Changes_Warning_Label
            // 
            this.Unsaved_Changes_Warning_Label.AutoSize = true;
            this.Unsaved_Changes_Warning_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unsaved_Changes_Warning_Label.Location = new System.Drawing.Point(83, 45);
            this.Unsaved_Changes_Warning_Label.Name = "Unsaved_Changes_Warning_Label";
            this.Unsaved_Changes_Warning_Label.Size = new System.Drawing.Size(217, 16);
            this.Unsaved_Changes_Warning_Label.TabIndex = 4;
            this.Unsaved_Changes_Warning_Label.Text = "Are you sure you want to leave with ";
            // 
            // UpdateUnsave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(356, 172);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Warning_Continued_Label);
            this.Controls.Add(this.Unsaved_Changes_Warning_Label);
            this.Name = "UpdateUnsave";
            this.Text = "UpdateUnsave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel_Button;
        private Button Save_Button;
        private Label Warning_Continued_Label;
        private Label Unsaved_Changes_Warning_Label;
    }
}