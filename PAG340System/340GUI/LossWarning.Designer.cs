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
            this.button_OK = new System.Windows.Forms.Button();
            this.label_WarningComment2 = new System.Windows.Forms.Label();
            this.label_WarningComment1 = new System.Windows.Forms.Label();
            this.pictureBox_Warning = new System.Windows.Forms.PictureBox();
            this.label_MoreLoss2 = new System.Windows.Forms.Label();
            this.label_MoreLoss1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(142, 136);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(93, 32);
            this.button_OK.TabIndex = 7;
            this.button_OK.Text = "Ok";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_WarningComment2
            // 
            this.label_WarningComment2.AutoSize = true;
            this.label_WarningComment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningComment2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_WarningComment2.Location = new System.Drawing.Point(57, 92);
            this.label_WarningComment2.Name = "label_WarningComment2";
            this.label_WarningComment2.Size = new System.Drawing.Size(253, 16);
            this.label_WarningComment2.TabIndex = 5;
            this.label_WarningComment2.Text = "please notify the Obfuscation department!";
            // 
            // label_WarningComment1
            // 
            this.label_WarningComment1.AutoSize = true;
            this.label_WarningComment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningComment1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_WarningComment1.Location = new System.Drawing.Point(86, 64);
            this.label_WarningComment1.Name = "label_WarningComment1";
            this.label_WarningComment1.Size = new System.Drawing.Size(209, 16);
            this.label_WarningComment1.TabIndex = 4;
            this.label_WarningComment1.Text = "A loss of 3.2% has been detected,";
            // 
            // pictureBox_Warning
            // 
            this.pictureBox_Warning.Image = global::_340GUI.Properties.Resources.warning;
            this.pictureBox_Warning.Location = new System.Drawing.Point(66, 64);
            this.pictureBox_Warning.Name = "pictureBox_Warning";
            this.pictureBox_Warning.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Warning.TabIndex = 8;
            this.pictureBox_Warning.TabStop = false;
            // 
            // label_MoreLoss2
            // 
            this.label_MoreLoss2.AutoSize = true;
            this.label_MoreLoss2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MoreLoss2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_MoreLoss2.Location = new System.Drawing.Point(20, 92);
            this.label_MoreLoss2.Name = "label_MoreLoss2";
            this.label_MoreLoss2.Size = new System.Drawing.Size(316, 16);
            this.label_MoreLoss2.TabIndex = 11;
            this.label_MoreLoss2.Text = "please notify the Obfuscation and Legal department!";
            // 
            // label_MoreLoss1
            // 
            this.label_MoreLoss1.AutoSize = true;
            this.label_MoreLoss1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MoreLoss1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_MoreLoss1.Location = new System.Drawing.Point(88, 64);
            this.label_MoreLoss1.Name = "label_MoreLoss1";
            this.label_MoreLoss1.Size = new System.Drawing.Size(209, 16);
            this.label_MoreLoss1.TabIndex = 10;
            this.label_MoreLoss1.Text = "A loss of 5.4% has been detected,";
            // 
            // LossWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(356, 205);
            this.Controls.Add(this.label_MoreLoss2);
            this.Controls.Add(this.label_MoreLoss1);
            this.Controls.Add(this.pictureBox_Warning);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_WarningComment2);
            this.Controls.Add(this.label_WarningComment1);
            this.Name = "LossWarning";
            this.Text = "Warning";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_OK;
        private Label label_WarningComment2;
        private Label label_WarningComment1;
        private PictureBox pictureBox_Warning;
        private Label label_MoreLoss2;
        private Label label_MoreLoss1;
        private PolicyPage prepreviousPage;
        private MakeClaim previousPage;
        //private Agent usingAgent;
    }
}