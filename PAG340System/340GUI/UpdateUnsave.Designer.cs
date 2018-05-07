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
            this.button_No = new System.Windows.Forms.Button();
            this.button_Yes = new System.Windows.Forms.Button();
            this.label_Comment2 = new System.Windows.Forms.Label();
            this.label_Comment1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_No
            // 
            this.button_No.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_No.Location = new System.Drawing.Point(220, 106);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(93, 32);
            this.button_No.TabIndex = 7;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // button_Yes
            // 
            this.button_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Yes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Yes.Location = new System.Drawing.Point(54, 106);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(93, 32);
            this.button_Yes.TabIndex = 6;
            this.button_Yes.Text = "Yes";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // label_Comment2
            // 
            this.label_Comment2.AutoSize = true;
            this.label_Comment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Comment2.Location = new System.Drawing.Point(125, 69);
            this.label_Comment2.Name = "label_Comment2";
            this.label_Comment2.Size = new System.Drawing.Size(122, 16);
            this.label_Comment2.TabIndex = 5;
            this.label_Comment2.Text = "unsaved changes?";
            // 
            // label_Comment1
            // 
            this.label_Comment1.AutoSize = true;
            this.label_Comment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Comment1.Location = new System.Drawing.Point(83, 45);
            this.label_Comment1.Name = "label_Comment1";
            this.label_Comment1.Size = new System.Drawing.Size(217, 16);
            this.label_Comment1.TabIndex = 4;
            this.label_Comment1.Text = "Are you sure you want to leave with ";
            // 
            // UpdateUnsave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(356, 172);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.label_Comment2);
            this.Controls.Add(this.label_Comment1);
            this.Name = "UpdateUnsave";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_No;
        private Button button_Yes;
        private Label label_Comment2;
        private Label label_Comment1;
        private PolicyPage prepreviousPage;
        private UpdatePolicy previousPage;
    }
}