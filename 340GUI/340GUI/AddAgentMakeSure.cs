using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _340GUI
{
    public partial class AddAgentMakeSure : Form
    {
        public AddAgentMakeSure(AddNewAgent inPage, Home inHomePage)
        {
            InitializeComponent();
            previousPage = inPage;
            homePage = inHomePage;
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            previousPage.Close();
            this.Close();
            homePage.Show();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
