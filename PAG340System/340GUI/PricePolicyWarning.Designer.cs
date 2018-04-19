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
    partial class PricePolicyWarning
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
            this.label_CancelWarning = new System.Windows.Forms.Label();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.pictureBox_Warning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CancelWarning
            // 
            this.label_CancelWarning.AutoSize = true;
            this.label_CancelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CancelWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_CancelWarning.Location = new System.Drawing.Point(81, 60);
            this.label_CancelWarning.Name = "label_CancelWarning";
            this.label_CancelWarning.Size = new System.Drawing.Size(209, 16);
            this.label_CancelWarning.TabIndex = 0;
            this.label_CancelWarning.Text = "Are you sure to unsave this page?";
            // 
            // button_Yes
            // 
            this.button_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Yes.Location = new System.Drawing.Point(77, 107);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(75, 23);
            this.button_Yes.TabIndex = 2;
            this.button_Yes.Text = "Yes";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_No.Location = new System.Drawing.Point(198, 107);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(75, 23);
            this.button_No.TabIndex = 3;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // pictureBox_Warning
            // 
            this.pictureBox_Warning.Image = global::_340GUI.Properties.Resources.warning;
            this.pictureBox_Warning.Location = new System.Drawing.Point(68, 60);
            this.pictureBox_Warning.Name = "pictureBox_Warning";
            this.pictureBox_Warning.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Warning.TabIndex = 9;
            this.pictureBox_Warning.TabStop = false;
            // 
            // PricePolicyWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(335, 173);
            this.Controls.Add(this.pictureBox_Warning);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.label_CancelWarning);
            this.Name = "PricePolicyWarning";
            this.Text = "Warning";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_CancelWarning;
        private Button button_Yes;
        private Button button_No;
        private PictureBox pictureBox_Warning;
        private Agent usingAgent;
        private PricePolicy previousPage;
    }
}