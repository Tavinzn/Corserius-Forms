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
    public partial class frmExe3 : Form
    {
        public frmExe3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txb1.Text);
            double b = Convert.ToDouble(txb2.Text);
            double c = Convert.ToDouble(txb3.Text);

            if (a < b && a < c)
            {
                lblResult.Text = a.ToString();
            }
            else if (b < c)
            {
                lblResult.Text = b.ToString();
            }
            else
            {
                lblResult.Text = c.ToString();
            }
        }
    }
}
