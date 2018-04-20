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
    partial class IncompleteFeature
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
            this.Comment = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.ForeColor = System.Drawing.Color.Maroon;
            this.Comment.Location = new System.Drawing.Point(113, 65);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(166, 20);
            this.Comment.TabIndex = 0;
            this.Comment.Text = "Incomplete Feature";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(155, 115);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // IncompleteFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(368, 176);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.Comment);
            this.Name = "IncompleteFeature";
            this.Text = "IncompleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.Button button_OK;
    }
}