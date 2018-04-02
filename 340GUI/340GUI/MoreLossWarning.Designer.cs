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
    partial class MoreLossWarning
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_WarningComment2 = new System.Windows.Forms.Label();
            this.label_WarningComment1 = new System.Windows.Forms.Label();
            this.pictureBox_Warning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(225, 143);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(93, 32);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Save.Location = new System.Drawing.Point(59, 143);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(93, 32);
            this.button_Save.TabIndex = 10;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // label_WarningComment2
            // 
            this.label_WarningComment2.AutoSize = true;
            this.label_WarningComment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningComment2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_WarningComment2.Location = new System.Drawing.Point(28, 97);
            this.label_WarningComment2.Name = "label_WarningComment2";
            this.label_WarningComment2.Size = new System.Drawing.Size(316, 16);
            this.label_WarningComment2.TabIndex = 9;
            this.label_WarningComment2.Text = "please notify the Obfuscation and Legal department!";
            // 
            // label_WarningComment1
            // 
            this.label_WarningComment1.AutoSize = true;
            this.label_WarningComment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningComment1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_WarningComment1.Location = new System.Drawing.Point(94, 69);
            this.label_WarningComment1.Name = "label_WarningComment1";
            this.label_WarningComment1.Size = new System.Drawing.Size(212, 16);
            this.label_WarningComment1.TabIndex = 8;
            this.label_WarningComment1.Text = "A loss off 5.4% has been detected,";
            // 
            // pictureBox_Warning
            // 
            this.pictureBox_Warning.Image = global::_340GUI.Properties.Resources.warning;
            this.pictureBox_Warning.Location = new System.Drawing.Point(76, 66);
            this.pictureBox_Warning.Name = "pictureBox_Warning";
            this.pictureBox_Warning.Size = new System.Drawing.Size(16, 21);
            this.pictureBox_Warning.TabIndex = 12;
            this.pictureBox_Warning.TabStop = false;
            // 
            // MoreLossWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(367, 208);
            this.Controls.Add(this.pictureBox_Warning);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_WarningComment2);
            this.Controls.Add(this.label_WarningComment1);
            this.Name = "MoreLossWarning";
            this.Text = "Warning";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Cancel;
        private Button button_Save;
        private Label label_WarningComment2;
        private Label label_WarningComment1;
        private PictureBox pictureBox_Warning;
        //private Agent usingAgent;
    }
}