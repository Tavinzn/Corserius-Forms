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
    public partial class frmExe1 : Form
    {
        public frmExe1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txb1.Text);
            double num2 = Convert.ToDouble(txb2.Text);
            double num3 = Convert.ToDouble(txb3.Text);
            double Result;
            Result = (num1 + num2 + num3) / 3; 
            lblResult.Text = Result.ToString();
        }
    }
}
