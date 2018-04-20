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
    partial class AddAgentMakeSure
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
            this.label_CancelConfirm = new System.Windows.Forms.Label();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.label_SubmitSuccess = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_CancelConfirm
            // 
            this.label_CancelConfirm.AutoSize = true;
            this.label_CancelConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CancelConfirm.Location = new System.Drawing.Point(70, 58);
            this.label_CancelConfirm.Name = "label_CancelConfirm";
            this.label_CancelConfirm.Size = new System.Drawing.Size(147, 16);
            this.label_CancelConfirm.TabIndex = 0;
            this.label_CancelConfirm.Text = "Are you sure to cancel?";
            // 
            // button_Yes
            // 
            this.button_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Yes.Location = new System.Drawing.Point(46, 103);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(75, 23);
            this.button_Yes.TabIndex = 1;
            this.button_Yes.Text = "Yes";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_No.Location = new System.Drawing.Point(157, 103);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(75, 23);
            this.button_No.TabIndex = 2;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // label_SubmitSuccess
            // 
            this.label_SubmitSuccess.AutoSize = true;
            this.label_SubmitSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SubmitSuccess.Location = new System.Drawing.Point(43, 58);
            this.label_SubmitSuccess.Name = "label_SubmitSuccess";
            this.label_SubmitSuccess.Size = new System.Drawing.Size(193, 16);
            this.label_SubmitSuccess.TabIndex = 3;
            this.label_SubmitSuccess.Text = "Successfully added new agent.";
            // 
            // button_Ok
            // 
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Ok.Location = new System.Drawing.Point(98, 103);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 4;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // AddAgentMakeSure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(276, 159);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label_SubmitSuccess);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.label_CancelConfirm);
            this.Name = "AddAgentMakeSure";
            this.Text = "AddAgentMakeSure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_CancelConfirm;
        private Button button_Yes;
        private Button button_No;
        private AddNewAgent previousPage;
        private Agent usingAgent;
        private Label label_SubmitSuccess;
        private Button button_Ok;
    }
}