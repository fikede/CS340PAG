using System.Windows.Forms;

namespace _340GUI
{
    partial class AddAgentWarning
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
            this.Ok_Button = new System.Windows.Forms.Button();
            this.Incomplete_Information_Text = new System.Windows.Forms.Label();
            this.WarningSign_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WarningSign_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok_Button
            // 
            this.Ok_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ok_Button.Location = new System.Drawing.Point(94, 94);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(84, 30);
            this.Ok_Button.TabIndex = 3;
            this.Ok_Button.Text = "Ok";
            this.Ok_Button.UseVisualStyleBackColor = true;
            this.Ok_Button.Click += new System.EventHandler(this.Ok_Button_Click);
            // 
            // Incomplete_Information_Text
            // 
            this.Incomplete_Information_Text.AutoSize = true;
            this.Incomplete_Information_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Incomplete_Information_Text.Location = new System.Drawing.Point(81, 60);
            this.Incomplete_Information_Text.Name = "Incomplete_Information_Text";
            this.Incomplete_Information_Text.Size = new System.Drawing.Size(114, 13);
            this.Incomplete_Information_Text.TabIndex = 2;
            this.Incomplete_Information_Text.Text = "Incomplete Information";
            // 
            // WarningSign_Image
            // 
            this.WarningSign_Image.Image = global::_340GUI.Properties.Resources.warning;
            this.WarningSign_Image.Location = new System.Drawing.Point(64, 58);
            this.WarningSign_Image.Name = "WarningSign_Image";
            this.WarningSign_Image.Size = new System.Drawing.Size(16, 21);
            this.WarningSign_Image.TabIndex = 4;
            this.WarningSign_Image.TabStop = false;
            // 
            // AddAgentWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(260, 162);
            this.Controls.Add(this.WarningSign_Image);
            this.Controls.Add(this.Ok_Button);
            this.Controls.Add(this.Incomplete_Information_Text);
            this.Name = "AddAgentWarning";
            this.Text = "AddAgentWarning";
            this.Load += new System.EventHandler(this.AddAgentWarning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WarningSign_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Ok_Button;
        private Label Incomplete_Information_Text;
        private PictureBox WarningSign_Image;
    }
}