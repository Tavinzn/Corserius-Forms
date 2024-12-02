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
    public partial class frmExe2 : Form
    {
        public frmExe2()
        {
            InitializeComponent();
        }

        private void btnCalular_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txbValor.Text);
                int num2 = Convert.ToInt32(txbQuantidade.Text);
                double result = num1 * num2;

                lblResult.BackColor = Color.Transparent;
                lblResult.Text = $"O valor total a ser pago é de R$ {result.ToString("F2")}";
                lblResult.Padding = new Padding(5);

            }
            catch
            {
                lblResult.Text = "Algo deu errado.";
                lblResult.BackColor = Color.Red;
            }
        }
    }
}
