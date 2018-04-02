using System.Windows.Forms;
namespace _340GUI
{
    partial class MoreLossWarning
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Notify_Departments_Warning_Text = new System.Windows.Forms.Label();
            this.High_Impact_Loss_Warning_Text = new System.Windows.Forms.Label();
            this.Warning_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(225, 143);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(93, 32);
            this.Cancel_Button.TabIndex = 11;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save_Button.Location = new System.Drawing.Point(59, 143);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(93, 32);
            this.Save_Button.TabIndex = 10;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            // 
            // Notify_Departments_Warning_Text
            // 
            this.Notify_Departments_Warning_Text.AutoSize = true;
            this.Notify_Departments_Warning_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notify_Departments_Warning_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Notify_Departments_Warning_Text.Location = new System.Drawing.Point(28, 97);
            this.Notify_Departments_Warning_Text.Name = "Notify_Departments_Warning_Text";
            this.Notify_Departments_Warning_Text.Size = new System.Drawing.Size(316, 16);
            this.Notify_Departments_Warning_Text.TabIndex = 9;
            this.Notify_Departments_Warning_Text.Text = "please notify the Obfuscation and Legal department!";
            // 
            // High_Impact_Loss_Warning_Text
            // 
            this.High_Impact_Loss_Warning_Text.AutoSize = true;
            this.High_Impact_Loss_Warning_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.High_Impact_Loss_Warning_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.High_Impact_Loss_Warning_Text.Location = new System.Drawing.Point(94, 69);
            this.High_Impact_Loss_Warning_Text.Name = "High_Impact_Loss_Warning_Text";
            this.High_Impact_Loss_Warning_Text.Size = new System.Drawing.Size(212, 16);
            this.High_Impact_Loss_Warning_Text.TabIndex = 8;
            this.High_Impact_Loss_Warning_Text.Text = "A loss off 5.4% has been detected,";
            // 
            // Warning_Image
            // 
            this.Warning_Image.Image = global::_340GUI.Properties.Resources.warning;
            this.Warning_Image.Location = new System.Drawing.Point(76, 66);
            this.Warning_Image.Name = "Warning_Image";
            this.Warning_Image.Size = new System.Drawing.Size(16, 21);
            this.Warning_Image.TabIndex = 12;
            this.Warning_Image.TabStop = false;
            // 
            // MoreLossWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(367, 208);
            this.Controls.Add(this.Warning_Image);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Notify_Departments_Warning_Text);
            this.Controls.Add(this.High_Impact_Loss_Warning_Text);
            this.Name = "MoreLossWarning";
            this.Text = "MoreLossWarning";
            ((System.ComponentModel.ISupportInitialize)(this.Warning_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel_Button;
        private Button Save_Button;
        private Label Notify_Departments_Warning_Text;
        private Label High_Impact_Loss_Warning_Text;
        private PictureBox Warning_Image;
    }
}