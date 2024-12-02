using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corserius_form
{
    public partial class frmExe8 : Form
    {
        public frmExe8()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0,1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }
    }
}
