using System.Windows.Forms;
namespace _340GUI
{
    partial class UpdateWarning
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
            this.Invalid_Information_Warning_Label = new System.Windows.Forms.Label();
            this.Ok_Button = new System.Windows.Forms.Button();
            this.Warning_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Invalid_Information_Warning_Label
            // 
            this.Invalid_Information_Warning_Label.AutoSize = true;
            this.Invalid_Information_Warning_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invalid_Information_Warning_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Invalid_Information_Warning_Label.Location = new System.Drawing.Point(94, 69);
            this.Invalid_Information_Warning_Label.Name = "Invalid_Information_Warning_Label";
            this.Invalid_Information_Warning_Label.Size = new System.Drawing.Size(184, 16);
            this.Invalid_Information_Warning_Label.TabIndex = 0;
            this.Invalid_Information_Warning_Label.Text = "Invalid or incorrect information";
            // 
            // Ok_Button
            // 
            this.Ok_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ok_Button.Location = new System.Drawing.Point(142, 106);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(75, 23);
            this.Ok_Button.TabIndex = 1;
            this.Ok_Button.Text = "Ok";
            this.Ok_Button.UseVisualStyleBackColor = true;
            this.Ok_Button.Click += new System.EventHandler(this.Ok_Button_Click);
            // 
            // Warning_Image
            // 
            this.Warning_Image.Image = global::_340GUI.Properties.Resources.warning;
            this.Warning_Image.Location = new System.Drawing.Point(81, 67);
            this.Warning_Image.Name = "Warning_Image";
            this.Warning_Image.Size = new System.Drawing.Size(16, 21);
            this.Warning_Image.TabIndex = 5;
            this.Warning_Image.TabStop = false;
            // 
            // UpdateWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(345, 177);
            this.Controls.Add(this.Warning_Image);
            this.Controls.Add(this.Ok_Button);
            this.Controls.Add(this.Invalid_Information_Warning_Label);
            this.Name = "UpdateWarning";
            this.Text = "UpdateWarning";
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Invalid_Information_Warning_Label;
        private Button Ok_Button;
        private PictureBox Warning_Image;
    }
}