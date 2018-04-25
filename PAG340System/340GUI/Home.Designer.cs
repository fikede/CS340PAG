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
    partial class Home
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
            this.linkLabel_Logout = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DelinquentAccounts = new System.Windows.Forms.LinkLabel();
            this.linkLabel_CreatePolicy = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Search = new System.Windows.Forms.LinkLabel();
            this.linkLabel_AddNewAgent = new System.Windows.Forms.LinkLabel();
            this.pictureBox_LICLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LICLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_Logout
            // 
            this.linkLabel_Logout.AutoSize = true;
            this.linkLabel_Logout.Location = new System.Drawing.Point(645, 357);
            this.linkLabel_Logout.Name = "linkLabel_Logout";
            this.linkLabel_Logout.Size = new System.Drawing.Size(43, 13);
            this.linkLabel_Logout.TabIndex = 6;
            this.linkLabel_Logout.TabStop = true;
            this.linkLabel_Logout.Text = "Log out";
            this.linkLabel_Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Logout_LinkClicked);
            // 
            // linkLabel_DelinquentAccounts
            // 
            this.linkLabel_DelinquentAccounts.AutoSize = true;
            this.linkLabel_DelinquentAccounts.Location = new System.Drawing.Point(333, 357);
            this.linkLabel_DelinquentAccounts.Name = "linkLabel_DelinquentAccounts";
            this.linkLabel_DelinquentAccounts.Size = new System.Drawing.Size(106, 13);
            this.linkLabel_DelinquentAccounts.TabIndex = 4;
            this.linkLabel_DelinquentAccounts.TabStop = true;
            this.linkLabel_DelinquentAccounts.Text = "Delinquent Accounts";
            this.linkLabel_DelinquentAccounts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DelinquentAccounts_LinkClicked);
            // 
            // linkLabel_CreatePolicy
            // 
            this.linkLabel_CreatePolicy.AutoSize = true;
            this.linkLabel_CreatePolicy.Location = new System.Drawing.Point(185, 357);
            this.linkLabel_CreatePolicy.Name = "linkLabel_CreatePolicy";
            this.linkLabel_CreatePolicy.Size = new System.Drawing.Size(78, 13);
            this.linkLabel_CreatePolicy.TabIndex = 3;
            this.linkLabel_CreatePolicy.TabStop = true;
            this.linkLabel_CreatePolicy.Text = "Create a Policy";
            this.linkLabel_CreatePolicy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_CreatePolicy_LinkClicked);
            // 
            // linkLabel_Search
            // 
            this.linkLabel_Search.AutoSize = true;
            this.linkLabel_Search.Location = new System.Drawing.Point(71, 357);
            this.linkLabel_Search.Name = "linkLabel_Search";
            this.linkLabel_Search.Size = new System.Drawing.Size(41, 13);
            this.linkLabel_Search.TabIndex = 2;
            this.linkLabel_Search.TabStop = true;
            this.linkLabel_Search.Text = "Search";
            this.linkLabel_Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Search_LinkClicked);
            // 
            // linkLabel_AddNewAgent
            // 
            this.linkLabel_AddNewAgent.AutoSize = true;
            this.linkLabel_AddNewAgent.Location = new System.Drawing.Point(501, 357);
            this.linkLabel_AddNewAgent.Name = "linkLabel_AddNewAgent";
            this.linkLabel_AddNewAgent.Size = new System.Drawing.Size(82, 13);
            this.linkLabel_AddNewAgent.TabIndex = 5;
            this.linkLabel_AddNewAgent.TabStop = true;
            this.linkLabel_AddNewAgent.Text = "Add New Agent";
            this.linkLabel_AddNewAgent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AddNewAgent_LinkClicked);
            // 
            // pictureBox_LICLogo
            // 
            this.pictureBox_LICLogo.Image = global::_340GUI.Properties.Resources.LIC;
            this.pictureBox_LICLogo.ImageLocation = "";
            this.pictureBox_LICLogo.Location = new System.Drawing.Point(0, 1);
            this.pictureBox_LICLogo.Name = "pictureBox_LICLogo";
            this.pictureBox_LICLogo.Size = new System.Drawing.Size(756, 319);
            this.pictureBox_LICLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LICLogo.TabIndex = 10;
            this.pictureBox_LICLogo.TabStop = false;
            this.pictureBox_LICLogo.Click += new System.EventHandler(this.pictureBox_LICLogo_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.pictureBox_LICLogo);
            this.Controls.Add(this.linkLabel_AddNewAgent);
            this.Controls.Add(this.linkLabel_Logout);
            this.Controls.Add(this.linkLabel_DelinquentAccounts);
            this.Controls.Add(this.linkLabel_CreatePolicy);
            this.Controls.Add(this.linkLabel_Search);
            this.Name = "Home";
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LICLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel linkLabel_Logout;
        private LinkLabel linkLabel_DelinquentAccounts;
        private LinkLabel linkLabel_CreatePolicy;
        private LinkLabel linkLabel_Search;
        private LinkLabel linkLabel_AddNewAgent;
        private PictureBox pictureBox_LICLogo;
        private Agent usingAgent;
    }
}