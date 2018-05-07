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
    public partial class UpdateUnsave : Form
    {
        public UpdateUnsave(PolicyPage inPage, UpdatePolicy updates)
        {
            InitializeComponent();
            prepreviousPage = inPage;
            previousPage = updates;
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            prepreviousPage.Show();
            previousPage.Close();
            this.Close();
        }
    }
}
