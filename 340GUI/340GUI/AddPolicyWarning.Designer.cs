using System.Windows.Forms;

namespace _340GUI
{
    partial class AddPolicyWarning
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
            this.IncompleteApplication_Text = new System.Windows.Forms.Label();
            this.Ok_Button = new System.Windows.Forms.Button();
            this.Warning_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // IncompleteApplication_Text
            // 
            this.IncompleteApplication_Text.AutoSize = true;
            this.IncompleteApplication_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IncompleteApplication_Text.Location = new System.Drawing.Point(81, 60);
            this.IncompleteApplication_Text.Name = "IncompleteApplication_Text";
            this.IncompleteApplication_Text.Size = new System.Drawing.Size(114, 13);
            this.IncompleteApplication_Text.TabIndex = 0;
            this.IncompleteApplication_Text.Text = "Incomplete Application";
            // 
            // Ok_Button
            // 
            this.Ok_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ok_Button.Location = new System.Drawing.Point(94, 94);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(84, 30);
            this.Ok_Button.TabIndex = 1;
            this.Ok_Button.Text = "Ok";
            this.Ok_Button.UseVisualStyleBackColor = true;
            this.Ok_Button.Click += new System.EventHandler(this.Ok_Button_Click);
            // 
            // Warning_Image
            // 
            this.Warning_Image.Image = global::_340GUI.Properties.Resources.warning;
            this.Warning_Image.Location = new System.Drawing.Point(63, 58);
            this.Warning_Image.Name = "Warning_Image";
            this.Warning_Image.Size = new System.Drawing.Size(16, 21);
            this.Warning_Image.TabIndex = 5;
            this.Warning_Image.TabStop = false;
            // 
            // AddPolicyWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(260, 162);
            this.Controls.Add(this.Warning_Image);
            this.Controls.Add(this.Ok_Button);
            this.Controls.Add(this.IncompleteApplication_Text);
            this.Name = "AddPolicyWarning";
            this.Text = "AddPolicyWarning";
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IncompleteApplication_Text;
        private Button Ok_Button;
        private PictureBox Warning_Image;
    }
}