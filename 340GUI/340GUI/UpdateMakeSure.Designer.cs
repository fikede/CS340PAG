using System.Windows.Forms;
using PAG340MiddleWare;

namespace _340GUI
{
    partial class UpdateMakeSure
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
            this.Prompt_Text_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Button.Location = new System.Drawing.Point(232, 109);
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
            this.Save_Button.Location = new System.Drawing.Point(66, 109);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(93, 32);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            // 
            // Prompt_Text_Label
            // 
            this.Prompt_Text_Label.AutoSize = true;
            this.Prompt_Text_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt_Text_Label.Location = new System.Drawing.Point(77, 64);
            this.Prompt_Text_Label.Name = "Prompt_Text_Label";
            this.Prompt_Text_Label.Size = new System.Drawing.Size(239, 16);
            this.Prompt_Text_Label.TabIndex = 4;
            this.Prompt_Text_Label.Text = "Would you like to save the information?";
            // 
            // UpdateMakeSure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(375, 187);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Prompt_Text_Label);
            this.Name = "UpdateMakeSure";
            this.Text = "UpdateMakeSure";
            this.Load += new System.EventHandler(this.UpdateMakeSure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel_Button;
        private Button Save_Button;
        private Label Prompt_Text_Label;
    }
}