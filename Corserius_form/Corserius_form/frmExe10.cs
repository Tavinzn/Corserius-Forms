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
    public partial class frmExe10 : Form
    {
        public frmExe10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txb1.TextLength == 0)
                {
                    MessageBox.Show("Insira algo!");
                }
                else
                {
                    double idade = Convert.ToDouble(txb1.Text);

                    if (idade >= 5 && idade <= 10)
                    {
                        MessageBox.Show("Categoria Infantil");
                    }
                    else if (idade >= 11 && idade <= 15)
                    {
                        MessageBox.Show("Categoria Juvenil");
                    }
                    else if (idade >= 16 && idade <= 20)
                    {
                        MessageBox.Show("Categoria Junior");
                    }
                    else if (idade >= 21 && idade <= 25)
                    {
                        MessageBox.Show("Categoria Profissional");
                    }
                    else
                    {
                        MessageBox.Show("Idade não permitida");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Insira um valor valido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txb1.Clear();
        }
    }
}
