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
    partial class PaymentHistory
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
            System.Windows.Forms.TextBox textBox_Categories;
            this.linkLabel_Back = new System.Windows.Forms.LinkLabel();
            this.label_PaymentHistory = new System.Windows.Forms.Label();
            this.label_PolicyNumber = new System.Windows.Forms.Label();
            this.label_PolicyholderName = new System.Windows.Forms.Label();
            this.listBox_PaymentHiotory = new System.Windows.Forms.ListBox();
            this.label_ShowPolicyNum = new System.Windows.Forms.Label();
            this.label_ShowPolicyholderName = new System.Windows.Forms.Label();
            textBox_Categories = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Categories
            // 
            textBox_Categories.BackColor = System.Drawing.Color.Silver;
            textBox_Categories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox_Categories.Location = new System.Drawing.Point(88, 153);
            textBox_Categories.Name = "textBox_Categories";
            textBox_Categories.Size = new System.Drawing.Size(581, 20);
            textBox_Categories.TabIndex = 5;
            // 
            // linkLabel_Back
            // 
            this.linkLabel_Back.AutoSize = true;
            this.linkLabel_Back.Location = new System.Drawing.Point(31, 27);
            this.linkLabel_Back.Name = "linkLabel_Back";
            this.linkLabel_Back.Size = new System.Drawing.Size(32, 13);
            this.linkLabel_Back.TabIndex = 0;
            this.linkLabel_Back.TabStop = true;
            this.linkLabel_Back.Text = "Back";
            // 
            // label_PaymentHistory
            // 
            this.label_PaymentHistory.AutoSize = true;
            this.label_PaymentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PaymentHistory.Location = new System.Drawing.Point(330, 61);
            this.label_PaymentHistory.Name = "label_PaymentHistory";
            this.label_PaymentHistory.Size = new System.Drawing.Size(98, 13);
            this.label_PaymentHistory.TabIndex = 1;
            this.label_PaymentHistory.Text = "Payment History";
            // 
            // label_PolicyNumber
            // 
            this.label_PolicyNumber.AutoSize = true;
            this.label_PolicyNumber.Location = new System.Drawing.Point(85, 98);
            this.label_PolicyNumber.Name = "label_PolicyNumber";
            this.label_PolicyNumber.Size = new System.Drawing.Size(78, 13);
            this.label_PolicyNumber.TabIndex = 2;
            this.label_PolicyNumber.Text = "Policy Number:\r\n";
            // 
            // label_PolicyholderName
            // 
            this.label_PolicyholderName.AutoSize = true;
            this.label_PolicyholderName.Location = new System.Drawing.Point(85, 120);
            this.label_PolicyholderName.Name = "label_PolicyholderName";
            this.label_PolicyholderName.Size = new System.Drawing.Size(98, 13);
            this.label_PolicyholderName.TabIndex = 3;
            this.label_PolicyholderName.Text = "Policyholder Name:";
            // 
            // listBox_PaymentHiotory
            // 
            this.listBox_PaymentHiotory.FormattingEnabled = true;
            this.listBox_PaymentHiotory.Location = new System.Drawing.Point(88, 172);
            this.listBox_PaymentHiotory.Name = "listBox_PaymentHiotory";
            this.listBox_PaymentHiotory.ScrollAlwaysVisible = true;
            this.listBox_PaymentHiotory.Size = new System.Drawing.Size(581, 199);
            this.listBox_PaymentHiotory.TabIndex = 4;
            this.listBox_PaymentHiotory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label_ShowPolicyNum
            // 
            this.label_ShowPolicyNum.Location = new System.Drawing.Point(169, 98);
            this.label_ShowPolicyNum.Name = "label_ShowPolicyNum";
            this.label_ShowPolicyNum.Size = new System.Drawing.Size(100, 23);
            this.label_ShowPolicyNum.TabIndex = 6;
            this.label_ShowPolicyNum.Text = "label4";
            this.label_ShowPolicyNum.Click += new System.EventHandler(this.PolicyNum_Click);
            // 
            // label_ShowPolicyholderName
            // 
            this.label_ShowPolicyholderName.Location = new System.Drawing.Point(189, 120);
            this.label_ShowPolicyholderName.Name = "label_ShowPolicyholderName";
            this.label_ShowPolicyholderName.Size = new System.Drawing.Size(100, 23);
            this.label_ShowPolicyholderName.TabIndex = 7;
            this.label_ShowPolicyholderName.Text = "HolderName";
            this.label_ShowPolicyholderName.Click += new System.EventHandler(this.label5_Click);
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.label_ShowPolicyholderName);
            this.Controls.Add(this.label_ShowPolicyNum);
            this.Controls.Add(textBox_Categories);
            this.Controls.Add(this.listBox_PaymentHiotory);
            this.Controls.Add(this.label_PolicyholderName);
            this.Controls.Add(this.label_PolicyNumber);
            this.Controls.Add(this.label_PaymentHistory);
            this.Controls.Add(this.linkLabel_Back);
            this.Name = "PaymentHistory";
            this.Text = "Payment History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel_Back;
        private Label label_PaymentHistory;
        private Label label_PolicyNumber;
        private Label label_PolicyholderName;
        private ListBox listBox_PaymentHiotory;
        private Label label_ShowPolicyNum;
        private Label label_ShowPolicyholderName;
        //private Agent usingAgent;
    }
}