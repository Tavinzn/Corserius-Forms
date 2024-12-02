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
    public partial class frmExe9 : Form
    {
        public frmExe9()
        {
            InitializeComponent();
        }
        private bool jaClicado = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!jaClicado)
            {
                double mes = Convert.ToDouble(txb1.Text);
                button1.Text = "Limpar";
                button1.ForeColor = Color.Red;
                jaClicado = true;
                switch (mes)
                {
                    case 1:
                        result.Text = ("o mês é Janeiro");
                        break;
                    case 2:
                        result.Text = ("o mês é Fevereiro");
                        break;
                    case 3:
                        result.Text = ("o mês é Março");
                        break;
                    case 4:
                        result.Text = ("o mês é Abril");
                        break;
                    case 5:
                        result.Text = ("o mês é Maio");
                        break;
                    case 6:
                        result.Text = ("o mês é junho");
                        break;
                    case 7:
                        result.Text = ("o mês é julho");
                        break;
                    case 8:
                        result.Text = ("o mês é Agosto");
                        break;
                    case 9:
                        result.Text = ("o mês é Setembro");
                        break;
                    case 10:
                        result.Text = ("o mês é Outubro");
                        break;
                    case 11:
                        result.Text = ("o mês é Novembro");
                        break;
                    case 12:
                        result.Text = ("o mês é Dezembro");
                        break;
                    default:
                        result.Text = ("numero invalido");
                        break;
                }

            }
            else
            {
                button1.ForeColor = Color.Black;
                button1.Text = "Calcular";
                jaClicado = false;
                txb1.Clear();
                result.Text = "";
            }
        }
    }
}
