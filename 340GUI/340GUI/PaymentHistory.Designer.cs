using System.Windows.Forms;
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
            this.Back = new System.Windows.Forms.LinkLabel();
            this.Payment_History_Label = new System.Windows.Forms.Label();
            this.Policy_Number_Label = new System.Windows.Forms.Label();
            this.Policyholder_Name_Label = new System.Windows.Forms.Label();
            this.Payment_History_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Location = new System.Drawing.Point(31, 27);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(32, 13);
            this.Back.TabIndex = 0;
            this.Back.TabStop = true;
            this.Back.Text = "Back";
            // 
            // Payment_History_Label
            // 
            this.Payment_History_Label.AutoSize = true;
            this.Payment_History_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_History_Label.Location = new System.Drawing.Point(330, 61);
            this.Payment_History_Label.Name = "Payment_History_Label";
            this.Payment_History_Label.Size = new System.Drawing.Size(98, 13);
            this.Payment_History_Label.TabIndex = 1;
            this.Payment_History_Label.Text = "Payment History";
            // 
            // Policy_Number_Label
            // 
            this.Policy_Number_Label.AutoSize = true;
            this.Policy_Number_Label.Location = new System.Drawing.Point(85, 98);
            this.Policy_Number_Label.Name = "Policy_Number_Label";
            this.Policy_Number_Label.Size = new System.Drawing.Size(78, 13);
            this.Policy_Number_Label.TabIndex = 2;
            this.Policy_Number_Label.Text = "Policy Number:\r\n";
            // 
            // Policyholder_Name_Label
            // 
            this.Policyholder_Name_Label.AutoSize = true;
            this.Policyholder_Name_Label.Location = new System.Drawing.Point(85, 120);
            this.Policyholder_Name_Label.Name = "Policyholder_Name_Label";
            this.Policyholder_Name_Label.Size = new System.Drawing.Size(98, 13);
            this.Policyholder_Name_Label.TabIndex = 3;
            this.Policyholder_Name_Label.Text = "Policyholder Name:";
            // 
            // Payment_History_listBox
            // 
            this.Payment_History_listBox.FormattingEnabled = true;
            this.Payment_History_listBox.Location = new System.Drawing.Point(88, 172);
            this.Payment_History_listBox.Name = "Payment_History_listBox";
            this.Payment_History_listBox.ScrollAlwaysVisible = true;
            this.Payment_History_listBox.Size = new System.Drawing.Size(581, 199);
            this.Payment_History_listBox.TabIndex = 4;
            this.Payment_History_listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.Payment_History_listBox);
            this.Controls.Add(this.Policyholder_Name_Label);
            this.Controls.Add(this.Policy_Number_Label);
            this.Controls.Add(this.Payment_History_Label);
            this.Controls.Add(this.Back);
            this.Name = "PaymentHistory";
            this.Text = "PaymentHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel Back;
        private Label Payment_History_Label;
        private Label Policy_Number_Label;
        private Label Policyholder_Name_Label;
        private ListBox Payment_History_listBox;
    }
}