using System;
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
    public partial class UpdatePolicy : Form
    {
        public UpdatePolicy(Agent inUsingAgent, PolicyPage policy)
        {
            InitializeComponent();
            usingAgent = inUsingAgent;
            previousPage = policy;
        }


    }
}
