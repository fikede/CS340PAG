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
            this.Prompt_Label = new System.Windows.Forms.Label();
            this.Delinquent_Status_radioButton = new System.Windows.Forms.RadioButton();
            this.Policyholder_Request_radioButton = new System.Windows.Forms.RadioButton();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prompt_Label
            // 
            this.Prompt_Label.AutoSize = true;
            this.Prompt_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt_Label.Location = new System.Drawing.Point(105, 49);
            this.Prompt_Label.Name = "Prompt_Label";
            this.Prompt_Label.Size = new System.Drawing.Size(225, 16);
            this.Prompt_Label.TabIndex = 0;
            this.Prompt_Label.Text = "Would you like to  cancel this policy?";
            // 
            // Delinquent_Status_radioButton
            // 
            this.Delinquent_Status_radioButton.AutoSize = true;
            this.Delinquent_Status_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delinquent_Status_radioButton.Location = new System.Drawing.Point(134, 74);
            this.Delinquent_Status_radioButton.Name = "Delinquent_Status_radioButton";
            this.Delinquent_Status_radioButton.Size = new System.Drawing.Size(130, 20);
            this.Delinquent_Status_radioButton.TabIndex = 1;
            this.Delinquent_Status_radioButton.TabStop = true;
            this.Delinquent_Status_radioButton.Text = "Delinquent Status";
            this.Delinquent_Status_radioButton.UseVisualStyleBackColor = true;
            // 
            // Policyholder_Request_radioButton
            // 
            this.Policyholder_Request_radioButton.AutoSize = true;
            this.Policyholder_Request_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Policyholder_Request_radioButton.Location = new System.Drawing.Point(134, 97);
            this.Policyholder_Request_radioButton.Name = "Policyholder_Request_radioButton";
            this.Policyholder_Request_radioButton.Size = new System.Drawing.Size(155, 20);
            this.Policyholder_Request_radioButton.TabIndex = 2;
            this.Policyholder_Request_radioButton.TabStop = true;
            this.Policyholder_Request_radioButton.Text = "Policyholder Request";
            this.Policyholder_Request_radioButton.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Button.Location = new System.Drawing.Point(237, 145);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(93, 32);
            this.Cancel_Button.TabIndex = 9;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save_Button.Location = new System.Drawing.Point(71, 145);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(93, 32);
            this.Save_Button.TabIndex = 8;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            // 
            // CancelPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(410, 209);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Policyholder_Request_radioButton);
            this.Controls.Add(this.Delinquent_Status_radioButton);
            this.Controls.Add(this.Prompt_Label);
            this.Name = "CancelPolicy";
            this.Text = "CancelPolicy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Prompt_Label;
        private RadioButton Delinquent_Status_radioButton;
        private RadioButton Policyholder_Request_radioButton;
        private Button Cancel_Button;
        private Button Save_Button;
    }
}