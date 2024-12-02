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
    public partial class frmExe7 : Form
    {
        public frmExe7()
        {
            InitializeComponent();
        }
        private List<int> numeros = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbAdd.Text, out int numero))
            {
                numeros.Add(numero);
                lstNumbers.Items.Add(numero); // Exibe na lista
                txbAdd.Clear();
                txbAdd.Focus();

                if (numeros.Count == 20)
                {
                    MessageBox.Show("Você digitou 20 números. Agora clique em 'Calcular'.");
                    button1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 20)
            {
                int maior = numeros.Max();
                int menor = numeros.Min();
                lblResult.Text = $"Maior: {maior} | Menor: {menor}";
            }
            else
            {
                MessageBox.Show("Você ainda não digitou 20 números.");
            }
        }
    }
}
