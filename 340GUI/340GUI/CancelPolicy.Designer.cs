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
            this.radioButton_DelinquentStatus = new System.Windows.Forms.RadioButton();
            this.radioButton_PolicyholderRequest = new System.Windows.Forms.RadioButton();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Asking
            // 
            this.label_Asking.AutoSize = true;
            this.label_Asking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Asking.Location = new System.Drawing.Point(105, 49);
            this.label_Asking.Name = "label_Asking";
            this.label_Asking.Size = new System.Drawing.Size(225, 16);
            this.label_Asking.TabIndex = 0;
            this.label_Asking.Text = "Would you like to  cancel this policy?";
            // 
            // radioButton_DelinquentStatus
            // 
            this.radioButton_DelinquentStatus.AutoSize = true;
            this.radioButton_DelinquentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_DelinquentStatus.Location = new System.Drawing.Point(134, 74);
            this.radioButton_DelinquentStatus.Name = "radioButton_DelinquentStatus";
            this.radioButton_DelinquentStatus.Size = new System.Drawing.Size(130, 20);
            this.radioButton_DelinquentStatus.TabIndex = 1;
            this.radioButton_DelinquentStatus.TabStop = true;
            this.radioButton_DelinquentStatus.Text = "Delinquent Status";
            this.radioButton_DelinquentStatus.UseVisualStyleBackColor = true;
            // 
            // radioButton_PolicyholderRequest
            // 
            this.radioButton_PolicyholderRequest.AutoSize = true;
            this.radioButton_PolicyholderRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_PolicyholderRequest.Location = new System.Drawing.Point(134, 97);
            this.radioButton_PolicyholderRequest.Name = "radioButton_PolicyholderRequest";
            this.radioButton_PolicyholderRequest.Size = new System.Drawing.Size(155, 20);
            this.radioButton_PolicyholderRequest.TabIndex = 2;
            this.radioButton_PolicyholderRequest.TabStop = true;
            this.radioButton_PolicyholderRequest.Text = "Policyholder Request";
            this.radioButton_PolicyholderRequest.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.Location = new System.Drawing.Point(237, 145);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(93, 32);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Save.Location = new System.Drawing.Point(71, 145);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(93, 32);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // CancelPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(410, 209);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.radioButton_PolicyholderRequest);
            this.Controls.Add(this.radioButton_DelinquentStatus);
            this.Controls.Add(this.label_Asking);
            this.Name = "CancelPolicy";
            this.Text = "Cancel Policy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Asking;
        private RadioButton radioButton_DelinquentStatus;
        private RadioButton radioButton_PolicyholderRequest;
        private Button button_Cancel;
        private Button button_Save;
        private Agent usingAgent;
        private PolicyPage previousPage;
    }
}