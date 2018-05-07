namespace _340GUI
{
    partial class SuccessPage
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
            this.label_Success = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Success
            // 
            this.label_Success.AutoSize = true;
            this.label_Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Success.Location = new System.Drawing.Point(89, 69);
            this.label_Success.Name = "label_Success";
            this.label_Success.Size = new System.Drawing.Size(126, 16);
            this.label_Success.TabIndex = 0;
            this.label_Success.Text = "Successfully Saved";
            // 
            // button_Ok
            // 
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Ok.Location = new System.Drawing.Point(113, 107);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 1;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // SuccessPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(292, 174);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label_Success);
            this.Name = "SuccessPage";
            this.Text = "Success";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Success;
        private System.Windows.Forms.Button button_Ok;
    }
}