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
    public partial class frmExe6 : Form
    {
        public frmExe6()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txb1.Text);
            double fatorial = 1;
            if (num1 == 0 || num1 == 1)
            {
                Result.Text = "1";
            }
            else if (num1 < 0)
            {
                Result.Text = "Erro, numero negativos não contem fatorial!";
            }
            else
            {
                for (double i = num1; i >= 1; i--)
                {
                    fatorial *= i;
                }
                Result.Text = fatorial.ToString();
            }
        }
    }
}
