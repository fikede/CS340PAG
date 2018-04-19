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
    partial class PriceButtonWarning
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
            this.label_PriceFirst = new System.Windows.Forms.Label();
            this.pictureBox_Warning = new System.Windows.Forms.PictureBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_IncompleteInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // label_PriceFirst
            // 
            this.label_PriceFirst.AutoSize = true;
            this.label_PriceFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PriceFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_PriceFirst.Location = new System.Drawing.Point(69, 64);
            this.label_PriceFirst.Name = "label_PriceFirst";
            this.label_PriceFirst.Size = new System.Drawing.Size(194, 16);
            this.label_PriceFirst.TabIndex = 10;
            this.label_PriceFirst.Text = "You should price the policy first!";
            // 
            // pictureBox_Warning
            // 
            this.pictureBox_Warning.Image = global::_340GUI.Properties.Resources.warning;
            this.pictureBox_Warning.Location = new System.Drawing.Point(52, 63);
            this.pictureBox_Warning.Name = "pictureBox_Warning";
            this.pictureBox_Warning.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Warning.TabIndex = 11;
            this.pictureBox_Warning.TabStop = false;
            // 
            // button_OK
            // 
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OK.Location = new System.Drawing.Point(118, 109);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 12;
            this.button_OK.Text = "Ok";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_IncompleteInfo
            // 
            this.label_IncompleteInfo.AutoSize = true;
            this.label_IncompleteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IncompleteInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_IncompleteInfo.Location = new System.Drawing.Point(86, 64);
            this.label_IncompleteInfo.Name = "label_IncompleteInfo";
            this.label_IncompleteInfo.Size = new System.Drawing.Size(145, 16);
            this.label_IncompleteInfo.TabIndex = 13;
            this.label_IncompleteInfo.Text = "Incomplete Information!";
            // 
            // PriceFirstError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(305, 177);
            this.Controls.Add(this.label_IncompleteInfo);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.pictureBox_Warning);
            this.Controls.Add(this.label_PriceFirst);
            this.Name = "PriceFirstError";
            this.Text = "PriceFirstError";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Warning;
        private System.Windows.Forms.Label label_PriceFirst;
        private System.Windows.Forms.Button button_OK;
        private Label label_IncompleteInfo;
    }
}