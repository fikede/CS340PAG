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
    partial class CancelPolicy
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
            this.label_Asking = new System.Windows.Forms.Label();
            this.button_No = new System.Windows.Forms.Button();
            this.button_Yes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Asking
            // 
            this.label_Asking.AutoSize = true;
            this.label_Asking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Asking.Location = new System.Drawing.Point(56, 64);
            this.label_Asking.Name = "label_Asking";
            this.label_Asking.Size = new System.Drawing.Size(225, 16);
            this.label_Asking.TabIndex = 0;
            this.label_Asking.Text = "Would you like to  cancel this policy?";
            // 
            // button_No
            // 
            this.button_No.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_No.Location = new System.Drawing.Point(198, 110);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(93, 32);
            this.button_No.TabIndex = 9;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // button_Yes
            // 
            this.button_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Yes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Yes.Location = new System.Drawing.Point(39, 110);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(93, 32);
            this.button_Yes.TabIndex = 8;
            this.button_Yes.Text = "Yes";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // CancelPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(330, 179);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.label_Asking);
            this.Name = "CancelPolicy";
            this.Text = "Cancel Policy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Asking;
        private Button button_No;
        private Button button_Yes;
        private Policy inPolicy;
        private PolicyPage previousPage;
    }
}