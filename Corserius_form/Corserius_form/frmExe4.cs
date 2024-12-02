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
    public partial class frmExe4 : Form
    {
        public frmExe4()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult.BackColor = Color.Transparent;
                int nascimento = Convert.ToInt32(tbxNascimento.Text);
                int ano = Convert.ToInt32(tbxAno.Text);
                int result = ano - nascimento;
                lblResult.Text = result.ToString();
                if (nascimento > ano || nascimento <= 0 || ano <= 0)
                {
                    lblResult.Text = "Valor invalido!";
                }
            }
            catch
            {
                lblResult.Text = "Numero inserido invalido!";
                lblResult.BackColor = Color.Red;
            }
        }
    }
}
