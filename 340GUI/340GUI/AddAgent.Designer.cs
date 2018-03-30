using System.Windows.Forms;

namespace _340GUI
{
    partial class AddAgent
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
            this.AddNewAgent_Label = new System.Windows.Forms.Label();
            this.AgentNumber = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Agent_First_Name = new System.Windows.Forms.Label();
            this.Agent_Last_Name = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Agent_First_Name_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Agent_Last_Name_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.DOB_textBox = new System.Windows.Forms.TextBox();
            this.UserType_dropDown_Menu = new System.Windows.Forms.ComboBox();
            this.Department_dropDown_Menu = new System.Windows.Forms.ComboBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewAgent_Label
            // 
            this.AddNewAgent_Label.AutoSize = true;
            this.AddNewAgent_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewAgent_Label.Location = new System.Drawing.Point(330, 28);
            this.AddNewAgent_Label.Name = "AddNewAgent_Label";
            this.AddNewAgent_Label.Size = new System.Drawing.Size(95, 13);
            this.AddNewAgent_Label.TabIndex = 0;
            this.AddNewAgent_Label.Text = "Add New Agent";
            // 
            // AgentNumber
            // 
            this.AgentNumber.AutoSize = true;
            this.AgentNumber.Location = new System.Drawing.Point(216, 69);
            this.AgentNumber.Name = "AgentNumber";
            this.AgentNumber.Size = new System.Drawing.Size(78, 13);
            this.AgentNumber.TabIndex = 1;
            this.AgentNumber.Text = "Agent Number:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(236, 92);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(58, 13);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Username:";
            // 
            // Agent_First_Name
            // 
            this.Agent_First_Name.AutoSize = true;
            this.Agent_First_Name.Location = new System.Drawing.Point(203, 115);
            this.Agent_First_Name.Name = "Agent_First_Name";
            this.Agent_First_Name.Size = new System.Drawing.Size(91, 13);
            this.Agent_First_Name.TabIndex = 3;
            this.Agent_First_Name.Text = "Agent First Name:";
            // 
            // Agent_Last_Name
            // 
            this.Agent_Last_Name.AutoSize = true;
            this.Agent_Last_Name.Location = new System.Drawing.Point(202, 138);
            this.Agent_Last_Name.Name = "Agent_Last_Name";
            this.Agent_Last_Name.Size = new System.Drawing.Size(92, 13);
            this.Agent_Last_Name.TabIndex = 4;
            this.Agent_Last_Name.Text = "Agent Last Name:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(238, 161);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password:";
            // 
            // UserType
            // 
            this.UserType.AutoSize = true;
            this.UserType.Location = new System.Drawing.Point(235, 184);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(59, 13);
            this.UserType.TabIndex = 6;
            this.UserType.Text = "User Type:";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(225, 207);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(69, 13);
            this.DOB.TabIndex = 7;
            this.DOB.Text = "Date of Birth:";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(229, 230);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(65, 13);
            this.Department.TabIndex = 8;
            this.Department.Text = "Department:";
            // 
            // Agent_First_Name_textBox
            // 
            this.Agent_First_Name_textBox.Location = new System.Drawing.Point(300, 112);
            this.Agent_First_Name_textBox.Name = "Agent_First_Name_textBox";
            this.Agent_First_Name_textBox.Size = new System.Drawing.Size(261, 20);
            this.Agent_First_Name_textBox.TabIndex = 9;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(300, 89);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(261, 20);
            this.Username_textBox.TabIndex = 10;
            // 
            // Agent_Last_Name_textBox
            // 
            this.Agent_Last_Name_textBox.Location = new System.Drawing.Point(300, 135);
            this.Agent_Last_Name_textBox.Name = "Agent_Last_Name_textBox";
            this.Agent_Last_Name_textBox.Size = new System.Drawing.Size(261, 20);
            this.Agent_Last_Name_textBox.TabIndex = 11;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(300, 158);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(261, 20);
            this.Password_textBox.TabIndex = 12;
            // 
            // DOB_textBox
            // 
            this.DOB_textBox.Location = new System.Drawing.Point(300, 204);
            this.DOB_textBox.Name = "DOB_textBox";
            this.DOB_textBox.Size = new System.Drawing.Size(261, 20);
            this.DOB_textBox.TabIndex = 13;
            // 
            // UserType_dropDown_Menu
            // 
            this.UserType_dropDown_Menu.FormattingEnabled = true;
            this.UserType_dropDown_Menu.Location = new System.Drawing.Point(300, 181);
            this.UserType_dropDown_Menu.Name = "UserType_dropDown_Menu";
            this.UserType_dropDown_Menu.Size = new System.Drawing.Size(261, 21);
            this.UserType_dropDown_Menu.TabIndex = 14;
            // 
            // Department_dropDown_Menu
            // 
            this.Department_dropDown_Menu.FormattingEnabled = true;
            this.Department_dropDown_Menu.Location = new System.Drawing.Point(300, 227);
            this.Department_dropDown_Menu.Name = "Department_dropDown_Menu";
            this.Department_dropDown_Menu.Size = new System.Drawing.Size(261, 21);
            this.Department_dropDown_Menu.TabIndex = 15;
            // 
            // Submit_Button
            // 
            this.Submit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit_Button.Location = new System.Drawing.Point(238, 310);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(105, 33);
            this.Submit_Button.TabIndex = 16;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Button.Location = new System.Drawing.Point(456, 310);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(105, 33);
            this.Cancel_Button.TabIndex = 17;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // AddAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Department_dropDown_Menu);
            this.Controls.Add(this.UserType_dropDown_Menu);
            this.Controls.Add(this.DOB_textBox);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Agent_Last_Name_textBox);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.Agent_First_Name_textBox);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Agent_Last_Name);
            this.Controls.Add(this.Agent_First_Name);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.AgentNumber);
            this.Controls.Add(this.AddNewAgent_Label);
            this.Name = "AddAgent";
            this.Text = "AddAgent";
            this.Load += new System.EventHandler(this.AddAgent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AddNewAgent_Label;
        private Label AgentNumber;
        private Label UserName;
        private Label Agent_First_Name;
        private Label Agent_Last_Name;
        private Label Password;
        private Label UserType;
        private Label DOB;
        private Label Department;
        private TextBox Agent_First_Name_textBox;
        private TextBox Username_textBox;
        private TextBox Agent_Last_Name_textBox;
        private TextBox Password_textBox;
        private TextBox DOB_textBox;
        private ComboBox UserType_dropDown_Menu;
        private ComboBox Department_dropDown_Menu;
        private Button Submit_Button;
        private Button Cancel_Button;
    }
}