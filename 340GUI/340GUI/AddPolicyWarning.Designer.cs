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
    partial class AddPolicyWarning
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
            this.label_WarningComment = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.pictureBox_Warning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // label_WarningComment
            // 
            this.label_WarningComment.AutoSize = true;
            this.label_WarningComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_WarningComment.Location = new System.Drawing.Point(81, 60);
            this.label_WarningComment.Name = "label_WarningComment";
            this.label_WarningComment.Size = new System.Drawing.Size(114, 13);
            this.label_WarningComment.TabIndex = 0;
            this.label_WarningComment.Text = "Incomplete Application";
            // 
            // button_OK
            // 
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OK.Location = new System.Drawing.Point(94, 94);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(84, 30);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "Ok";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Warning
            // 
            this.pictureBox_Warning.Image = global::_340GUI.Properties.Resources.warning;
            this.pictureBox_Warning.Location = new System.Drawing.Point(63, 58);
            this.pictureBox_Warning.Name = "pictureBox_Warning";
            this.pictureBox_Warning.Size = new System.Drawing.Size(16, 21);
            this.pictureBox_Warning.TabIndex = 5;
            this.pictureBox_Warning.TabStop = false;
            // 
            // AddPolicyWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(260, 162);
            this.Controls.Add(this.pictureBox_Warning);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_WarningComment);
            this.Name = "AddPolicyWarning";
            this.Text = "Warning";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_WarningComment;
        private Button button_OK;
        private PictureBox pictureBox_Warning;
        //private Agent usingAgent;
    }
}