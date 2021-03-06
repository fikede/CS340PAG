﻿using System;
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
    public partial class AddPolicyMakeSure : Form
    {
        public AddPolicyMakeSure(bool forSave, Policy policy, AddPolicy addPolicy, Agent inUsingAgent, PricePolicy pricePolicy)
        {
            InitializeComponent();
            completePolicy = policy;
            previousPage = addPolicy;
            usingAgent = inUsingAgent;
            prepreviousPage = pricePolicy;
            if(forSave)
            {
                label_CancelWarning.Visible = false;
                pictureBox_Warning.Visible = false;
                button_Yes.Visible = false;
                button_No.Visible = false;
            }
            else
            {
                label_SaveMakeSure.Visible = false;
                button_Save.Visible = false;
                button_Cancel.Visible = false;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            completePolicy.saveToDataBase();
            Home home = new Home(usingAgent);
            home.Show();
            SuccessPage success = new SuccessPage();
            success.Show();
            previousPage.Close();
            this.Close();
            prepreviousPage.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            prepreviousPage.Show();
            previousPage.Close();
            this.Close();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
