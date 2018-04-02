using System.Windows.Forms;
using PAG340MiddleWare;

namespace _340GUI
{
    partial class LossWarning
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
            this.Notification_Loss_Label = new System.Windows.Forms.Label();
            this.Loss_Warning_Label = new System.Windows.Forms.Label();
            this.Warning_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(217, 126);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(93, 32);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save_Button.Location = new System.Drawing.Point(51, 126);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(93, 32);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            // 
            // Notification_Loss_Label
            // 
            this.Notification_Loss_Label.AutoSize = true;
            this.Notification_Loss_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification_Loss_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Notification_Loss_Label.Location = new System.Drawing.Point(57, 92);
            this.Notification_Loss_Label.Name = "Notification_Loss_Label";
            this.Notification_Loss_Label.Size = new System.Drawing.Size(253, 16);
            this.Notification_Loss_Label.TabIndex = 5;
            this.Notification_Loss_Label.Text = "please notify the Obfuscation department!";
            // 
            // Loss_Warning_Label
            // 
            this.Loss_Warning_Label.AutoSize = true;
            this.Loss_Warning_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loss_Warning_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Loss_Warning_Label.Location = new System.Drawing.Point(86, 64);
            this.Loss_Warning_Label.Name = "Loss_Warning_Label";
            this.Loss_Warning_Label.Size = new System.Drawing.Size(212, 16);
            this.Loss_Warning_Label.TabIndex = 4;
            this.Loss_Warning_Label.Text = "A loss off 3.2% has been detected,";
            // 
            // Warning_Image
            // 
            this.Warning_Image.Image = global::_340GUI.Properties.Resources.warning;
            this.Warning_Image.Location = new System.Drawing.Point(66, 64);
            this.Warning_Image.Name = "Warning_Image";
            this.Warning_Image.Size = new System.Drawing.Size(16, 16);
            this.Warning_Image.TabIndex = 8;
            this.Warning_Image.TabStop = false;
            // 
            // LossWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(356, 205);
            this.Controls.Add(this.Warning_Image);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Notification_Loss_Label);
            this.Controls.Add(this.Loss_Warning_Label);
            this.Name = "LossWarning";
            this.Text = "LossWarning";
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel_Button;
        private Button Save_Button;
        private Label Notification_Loss_Label;
        private Label Loss_Warning_Label;
        private PictureBox Warning_Image;
    }
}