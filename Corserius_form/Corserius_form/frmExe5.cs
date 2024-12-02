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
    public partial class frmExe5 : Form
    {
        public frmExe5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double Num = Convert.ToDouble(txbNum.Text);
                if(Num == 0)
                {
                    lblResult.Text = "Escreva um numero diferente de 0";
                }
                else if(Num < 0)
                {
                    lblResult.Text = "Numero negativo";
                }
                else
                {
                    lblResult.Text = "Numero positivo";
                }
            }
            catch {
                lblResult.Text = "Numero invalido";
            }
        }
    }
}
